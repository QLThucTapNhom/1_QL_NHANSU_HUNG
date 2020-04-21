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
            dataGridViewTS.AllowUserToResizeColumns = true;
            dataGridViewBH.AllowUserToResizeColumns = true;
            db.loadComboBox(comboBoxMaNV1, "SELECT MaNV FROM dbo.HoSoNV");
            db.loadComboBox(comboBoxMaNV2, "SELECT HS.MaNV FROM dbo.HoSoNV HS, dbo.TTNhanVienCoBan TT WHERE HS.MaNV = TT.MaNV AND TT.GioiTinh = N'Nữ'");

        }
        //Tab page Chế độ bảo hiểm xã hội

        public void Reset()
        {
            
            textBoxMaLuong1.Text = ""; ;
            textBoxTenNV1.Text = "";
            textBoxMaBHXH.Text = "";
            textBoxGhiChu1.Text = "";
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            comboBoxMaNV1.Text = "";
            Reset();
        }
        private void comboBoxMaNV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            string MaNV = comboBoxMaNV1.SelectedItem.ToString();
            db.loadTextBox(textBoxMaLuong1, "SELECT MaLuong FROM dbo.HoSoNV WHERE MaNV=N'"+MaNV+"'");

            db.loadTextBox(textBoxTenNV1, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ten = textBoxTenNV1.Text.Trim();
            db.loadTextBox(textBoxTenNV1, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ho = textBoxTenNV1.Text.Trim();
            string HoTenNV = ho + " " + ten;
            textBoxTenNV1.Text = HoTenNV;

            db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDBaoHiemXaHoi WHERE MaNV=N'" + MaNV + "'");

            try
            {
                db.loadTextBox(textBoxMaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi WHERE MaNV='"+MaNV+"'");
            }
            catch
            {

            }


        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = comboBoxMaNV1.Text.Trim();
                string HoTenNV = textBoxTenNV1.Text.Trim();
                string MaLuong = textBoxMaLuong1.Text.Trim();
                string MaBHXH = textBoxMaBHXH.Text.Trim();
                string NgayCap = dateTimePickerNC.Value.ToShortDateString();
                string GhiChu = textBoxGhiChu1.Text.Trim();
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
                            db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDBaoHiemXaHoi WHERE MaNV=N'" + MaNV + "'");
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
                string MaNV = comboBoxMaNV1.Text.Trim();
                string HoTenNV = textBoxTenNV1.Text.Trim();
                //string MaLuong = textBoxMaLuong1.Text.Trim();
                string MaBHXH = textBoxMaBHXH.Text.Trim();
                string NgayCap = dateTimePickerNC.Value.ToShortDateString();
                string GhiChu = textBoxGhiChu1.Text.Trim();
                if (MaNV.Length != 0 && HoTenNV.Length != 0 && MaBHXH.Length != 0)
                {
                    bool check1 = db.Check(MaNV, "SELECT MaNV FROM dbo.CDBaoHiemXaHoi");
                    bool check2 = db.Check(MaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi");
                    if (check1 == true)
                    {
                        if (check2 == true)
                        {

                            string update = "UPDATE dbo.CDBaoHiemXaHoi SET NgayCapSo='" + NgayCap + "' ,GhiChu = N'" + GhiChu + "' ";
                            db.ThucThiKetNoi(update);
                            MessageBox.Show("Sửa sổ BHXH cho NV: " + HoTenNV + " hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDBaoHiemXaHoi WHERE MaNV=N'" + MaNV + "'");
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
                string MaNV = comboBoxMaNV1.Text.Trim();
                string HoTenNV = textBoxTenNV1.Text.Trim();
                bool check1 = db.Check(MaNV, "SELECT MaNV FROM dbo.CDBaoHiemXaHoi");
                //bool check2 = db.Check(MaBHXH, "SELECT MaBHXH FROM dbo.CDBaoHiemXaHoi");
                if (check1 == true)
                {
                    string del = "DELETE FROM dbo.CDBaoHiemXaHoi WHERE MaNV='" + MaNV + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa sổ BHXH của NV: " + HoTenNV + " hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Load lại
                    dataGridViewBH.DataSource = "";
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
            dataGridViewBH.DataSource = null;
            db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDBaoHiemXaHoi");

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Tab page Chế độ thai sản
        public void Reset2()
        {


            comboBoxMaNV2.Text = "";
            textBoxTenNV2.Text = "";
            comboBoxMaPB.Text = "";
            textBoxGhiChu2.Text = "";
            dataGridViewTS.DataSource = "";
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {
            Reset2();
        }
        
        private void comboBoxMaNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset2();
            string MaNV = comboBoxMaNV2.SelectedItem.ToString();

            //db.loadTextBox(textBoxTenNV2, "SELECT HoTenNV FROM dbo.HoSoNV WHERE MaNV=N'" + "'"); 

            db.loadTextBox(textBoxTenNV2, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ten = textBoxTenNV2.Text.Trim();
            db.loadTextBox(textBoxTenNV2, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV=N'" + MaNV + "'");
            string ho = textBoxTenNV2.Text.Trim();
            string HoTenNV = ho + " " + ten;
            textBoxTenNV2.Text = HoTenNV;

            db.loadComboBox_Show(comboBoxMaPB, "SELECT MaPB FROM dbo.HoSoNV WHERE MaNV=N'"+MaNV+"'");

            db.loadDataGridView(dataGridViewTS, "SELECT * FROM dbo.CDThaiSan WHERE MaNV=N'" + MaNV + "'");

        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = comboBoxMaNV2.Text.Trim();
                string HoTenNV = textBoxTenNV2.Text.Trim();
                string MaPB = comboBoxMaPB.Text.Trim();
                string NgayBD = dateTimePicker2.Value.ToShortDateString();
                string NgayTL = dateTimePicker1.Value.ToShortDateString();
                string GhiChu = textBoxGhiChu2.Text.Trim();

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
                            db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDThaiSan WHERE MaNV=N'" + MaNV + "'");
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
                string MaNV = comboBoxMaNV2.Text.Trim();
                string HoTenNV = textBoxTenNV2.Text.Trim();
                string MaPB = comboBoxMaPB.Text.Trim();
                string NgayBD = dateTimePicker2.Value.ToShortDateString();
                string NgayTL = dateTimePicker1.Value.ToShortDateString();
                string GhiChu = textBoxGhiChu2.Text.Trim();
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
                        db.loadDataGridView(dataGridViewBH, "SELECT * FROM dbo.CDThaiSan WHERE MaNV=N'" + MaNV + "'");


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
                string MaNV = comboBoxMaNV2.Text.Trim();
                string HoTenNV = textBoxTenNV2.Text.Trim();
                bool check = db.Check(MaNV, "SELECT MaNV FROM dbo.CDThaiSan");
                if (check == true)
                {

                    //( MaNV ,HoTenNV ,MaPB ,NgayBDNghi ,NgayTroLai ,GhiChu)
                    string update = "DELETE FROM dbo.CDThaiSan WHERE MaNV =N'" + MaNV + "'";
                    db.ThucThiKetNoi(update);
                    MessageBox.Show("Xóa hoàn tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewTS.DataSource = "";


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
            dataGridViewTS.DataSource = null;
            //deldrv(dataGridViewTS);


            db.loadDataGridView(dataGridViewTS, "SELECT * FROM dbo.CDThaiSan");
        }

        private void dataGridViewBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
