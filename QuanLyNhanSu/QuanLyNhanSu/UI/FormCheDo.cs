using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormCheDo : Form
    {

        ConnectDatabase db = new ConnectDatabase();
        public FormCheDo()
        {
            InitializeComponent();
        }

       

        private void FormCheDo_Load(object sender, EventArgs e)
        {
            dgvTS.AllowUserToResizeColumns = true;
            dgvBH.AllowUserToResizeColumns = true;
            db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");
            db.loadDataGridView(dgvBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");
            db.loadComboBox(cbbMaNV1, "SELECT MaNV FROM dbo.HoSoNV");
            db.loadComboBox(cbbMaNV2, "SELECT HS.MaNV FROM dbo.HoSoNV HS, dbo.TTNhanVienCoBan TT WHERE HS.MaNV = TT.MaNV AND TT.GioiTinh = N'Nữ'");

        }
        //Tab page Chế độ bảo hiểm xã hội

        public void Reset()
        {
            
            txtMaLuong1.Text = ""; ;
            txtTenNV1.Text = "";
            txtMaBHXH.Text = "";
            txtGhiChu1.Text = "";
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            cbbMaNV1.Text = "";
            Reset();
        }
        private void comboBoxMaNV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            string MaNV = cbbMaNV1.SelectedItem.ToString();
            db.loadTextBox(txtMaLuong1, "SELECT MaLuong FROM dbo.HoSoNV WHERE MaNV=N'"+MaNV+"'");

            db.loadTextBox(txtTenNV1, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ten = txtTenNV1.Text.Trim();
            db.loadTextBox(txtTenNV1, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ho = txtTenNV1.Text.Trim();
            string HoTenNV = ho + " " + ten;
            txtTenNV1.Text = HoTenNV;

            //db.loadTextBox(textBoxGhiChu1, "SELECT GhiChu FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");

            //db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDBaoHiemXaHoi WHERE MaNV=N'" + MaNV + "'");

            try
            {
                db.loadTextBox(txtMaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi WHERE MaNV='"+MaNV+"'");
            }
            catch
            {

            }


        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV1.Text.Trim();
                string HoTenNV = txtTenNV1.Text.Trim();
                string MaLuong = txtMaLuong1.Text.Trim();
                string MaBHXH = txtMaBHXH.Text.Trim();
                string NgayCap = dtpNC.Value.ToShortDateString();
                string GhiChu = txtGhiChu1.Text.Trim();
                if (MaNV.Length != 0 && HoTenNV.Length != 0 && MaLuong.Length != 0 && MaBHXH.Length != 0)
                {
                    bool check1 = db.Check(MaNV, "SELECT MaNV FROM dbo.CDBaoHiemXaHoi");
                    bool check2 = db.Check(MaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi");
                    if (check1 == false)
                    {
                        if (check2 == false)
                        {

                            string insert = "INSERT dbo.CDBaoHiemXaHoi( MaNV ,HoTenNV ,MaLuong ,MaBHXH ,NgayCapSo ,GhiChu)"
                                + "  VALUES  ( N'" + MaNV + "' , N'" + HoTenNV + "' , N'" + MaLuong + "' ,  N'" + MaBHXH + "' ,  '" + NgayCap + "' , N'" + GhiChu + "')";
                            db.ThucThiKetNoi(insert);
                            MessageBox.Show("Thêm sổ BHXH cho NV: " + HoTenNV + " hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.loadDataGridView(dgvBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");
                        }
                        else
                        {
                            MessageBox.Show("Mã sổ BHXH: " + MaBHXH + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NV: " + HoTenNV + " đã có sổ BHXH", "Không thể thêm mới!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
                
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV1.Text.Trim();
                string HoTenNV = txtTenNV1.Text.Trim();
                //string MaLuong = textBoxMaLuong1.Text.Trim();
                string MaBHXH = txtMaBHXH.Text.Trim();
                string NgayCap = dtpNC.Value.ToShortDateString();
                string GhiChu = txtGhiChu1.Text.Trim();
                if (MaNV.Length != 0 && HoTenNV.Length != 0 && MaBHXH.Length != 0)
                {
                    bool check1 = db.Check(MaNV, "SELECT MaNV FROM dbo.CDBaoHiemXaHoi");
                    bool check2 = db.Check(MaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi");
                    if (check1 == true)
                    {
                        if (check2 == true)
                        {

                            string update = "UPDATE dbo.CDBaoHiemXaHoi SET NgayCapSo='" + NgayCap + "' ,GhiChu = N'" + GhiChu + "' WHERE MaNV='"+ MaNV+"'";
                            db.ThucThiKetNoi(update);
                            MessageBox.Show("Sửa sổ BHXH cho NV: " + HoTenNV + " hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.loadDataGridView(dgvBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");
                        }
                        else
                        {
                            MessageBox.Show("Sổ BHXH: " + MaBHXH + " không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("NV: " + HoTenNV + " chưa có sổ BHXH", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV1.Text.Trim();
                string HoTenNV = txtTenNV1.Text.Trim();
                bool check1 = db.Check(MaNV, "SELECT MaNV FROM dbo.CDBaoHiemXaHoi");
                //bool check2 = db.Check(MaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi");
                if (check1 == true)
                {
                    string del = "DELETE FROM dbo.CDBaoHiemXaHoi WHERE MaNV='" + MaNV + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa sổ BHXH của NV: " + HoTenNV + " hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Load lại
                    dgvBH.DataSource = "";
                    db.loadDataGridView(dgvBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");
                }
                else
                {
                    MessageBox.Show("NV: " + HoTenNV + " chưa có sổ BHXH", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                Close();
            }
        }
        private void buttonDS1_Click(object sender, EventArgs e)
        {
            dgvBH.DataSource = null;
            db.loadDataGridView(dgvBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Tab page Chế độ thai sản
        public void Reset2()
        {


            cbbMaNV2.Text = "";
            txtTenNV2.Text = "";
            cbbMaPB.Text = "";
            txtGhiChu2.Text = "";
            dgvTS.DataSource = "";
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {
            Reset2();
        }
        
        private void comboBoxMaNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset2();
            string MaNV = cbbMaNV2.SelectedItem.ToString();

            //db.loadTextBox(textBoxTenNV2, "SELECT HoTenNV FROM dbo.HoSoNV WHERE MaNV=N'" + "'"); 

            db.loadTextBox(txtTenNV2, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ten = txtTenNV2.Text.Trim();
            db.loadTextBox(txtTenNV2, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ho = txtTenNV2.Text.Trim();
            string HoTenNV = ho + " " + ten;
            txtTenNV2.Text = HoTenNV;

            db.loadComboBox_Show(cbbMaPB, "SELECT MaPB FROM dbo.HoSoNV WHERE MaNV=N'"+MaNV+"'");

            db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");

        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV2.Text.Trim();
                string HoTenNV = txtTenNV2.Text.Trim();
                string MaPB = cbbMaPB.Text.Trim();
                string NgayBD = dtpNgayBD.Value.ToShortDateString();
                string NgayTL = dtpNgayTL.Value.ToShortDateString();
                string GhiChu = txtGhiChu2.Text.Trim();

                if (MaNV.Length != 0 && HoTenNV.Length != 0 && MaPB.Length != 0 && MaPB.Length != 0)
                {
                    bool check = db.Check(MaNV, "SELECT MaNV FROM dbo.CDThaiSan");
                    bool check1 = db.Check(MaNV, "SELECT HS.MaNV FROM dbo.HoSoNV HS, dbo.TTNhanVienCoBan TT WHERE HS.MaNV=TT.MaNV AND TT.GioiTinh=N'Nữ'");
                    if (check == false)
                    {
                        if (check1 == true)
                        {
                            string insert = "INSERT INTO dbo.CDThaiSan( MaNV ,HoTenNV ,MaPB ,NgayBDNghi ,NgayTroLai ,GhiChu)"
                            + "VALUES(N'" + MaNV + "', N'" + HoTenNV + "', N'" + MaPB + "', '" + NgayBD + "', '" + NgayTL + "', N'" + GhiChu + "')";
                            db.ThucThiKetNoi(insert);
                            MessageBox.Show("Hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");
                        }
                        else
                        {
                            MessageBox.Show("NV: " + MaNV + " không là NV Nữ!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
              

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void buttonUpdate2_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV2.Text.Trim();
                string HoTenNV = txtTenNV2.Text.Trim();
                string MaPB = cbbMaPB.Text.Trim();
                string NgayBD = dtpNgayBD.Value.ToShortDateString();
                string NgayTL = dtpNgayTL.Value.ToShortDateString();
                string GhiChu = txtGhiChu2.Text.Trim();
                if (MaNV.Length != 0 && HoTenNV.Length != 0 && MaPB.Length != 0 && MaPB.Length != 0)
                {
                    bool check = db.Check(MaNV, "SELECT MaNV FROM dbo.CDThaiSan");
                    if (check == true)
                    {

                        //( MaNV ,HoTenNV ,MaPB ,NgayBDNghi ,NgayTroLai ,GhiChu)
                        string update = "UPDATE dbo.CDThaiSan SET "
                        + "NgayBDNghi= '" + NgayBD + "',NgayTroLai= '" + NgayTL + "',GhiChu= N'" + GhiChu + "' WHERE MaNV =N'" + MaNV + "'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");


                    }
                    else
                    {
                        MessageBox.Show("NV: " + HoTenNV + " không thuộc chế độ!", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDel2_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV2.Text.Trim();
                string HoTenNV = txtTenNV2.Text.Trim();
                bool check = db.Check(MaNV, "SELECT MaNV FROM dbo.CDThaiSan");
                if (check == true)
                {

                    //( MaNV ,HoTenNV ,MaPB ,NgayBDNghi ,NgayTroLai ,GhiChu)
                    string update = "DELETE FROM dbo.CDThaiSan WHERE MaNV =N'" + MaNV + "'";
                    db.ThucThiKetNoi(update);
                    MessageBox.Show("Xóa hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTS.DataSource = "";
                    db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");


                }
                else
                {
                    MessageBox.Show("NV: " + HoTenNV + " không thuộc chế độ!", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //public void deldrv(DataGridView dat)
        //{
        //    int numRows = dat.Rows.Count;
        //    for (int i = 0; i < numRows; i++)
        //    {
        //        try
        //        {
        //            int max = dat.Rows.Count - 1;
        //            dat.Rows.Remove(dat.Rows[max]);

        //        }
        //        catch
        //        {
                  
        //        }
        //    }
        //}

        private void buttonDS2_Click(object sender, EventArgs e)
        {
            dgvTS.DataSource = null;
            //deldrv(dataGridViewTS);


            db.loadDataGridView(dgvTS, "SELECT * FROM dbo.CDThaiSan");
        }

        private void dataGridViewBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBH.CurrentRow.Index;
            cbbMaNV1.Text = dgvBH.Rows[i].Cells[0].Value.ToString();
            txtTenNV1.Text = dgvBH.Rows[i].Cells[1].Value.ToString();
            txtMaLuong1.Text = dgvBH.Rows[i].Cells[2].Value.ToString();
            txtMaBHXH.Text = dgvBH.Rows[i].Cells[3].Value.ToString();
            dtpNC.Text = dgvBH.Rows[i].Cells[4].Value.ToString();
            txtGhiChu1.Text = dgvBH.Rows[i].Cells[5].Value.ToString();
  
        }

        private void dgvTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTS.CurrentRow.Index;
            cbbMaNV2.Text = dgvTS.Rows[i].Cells[0].Value.ToString();
            txtTenNV2.Text = dgvTS.Rows[i].Cells[1].Value.ToString();
            cbbMaPB.Text = dgvTS.Rows[i].Cells[2].Value.ToString();
            dtpNgayBD.Text = dgvTS.Rows[i].Cells[3].Value.ToString();
            dtpNgayTL.Text = dgvTS.Rows[i].Cells[4].Value.ToString();
            txtGhiChu2.Text = dgvTS.Rows[i].Cells[5].Value.ToString();
        }
    }
}
