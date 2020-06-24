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
    public partial class FormPhongBan : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            cbbMaPB.Text = "";
            txtChucNangPB.Text = "";
            txtTenPB.Text = "";
            txtChucNangPB.Text = "";
            txtDCPhong.Text = "";
            txtGhiChu.Text = "";
            cbbMaTruongPhong.Text = "";
            txtSDTPB.Text = "";
            dgvPhongBan.DataSource = "";
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            db.loadComboBox(cbbMaPB, "SELECT MaPB FROM dbo.PhongBan");
            db.loadComboBox(cbbMaTruongPhong, "SELECT MaNV FROM dbo.HoSoNV");
            db.loadDataGridView(dgvPhongBan, "SELECT * FROM dbo.PhongBan");

        }

        private void comboBoxMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string MaPB = cbbMaPB.SelectedItem.ToString();
            //db.loadDataGridView(dgvPhongBan, "SELECT * FROM dbo.PhongBan WHERE MaPB=N'"+MaPB+"'");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPB = cbbMaPB.Text.Trim();
                string TenPB = txtTenPB.Text.Trim();
                string ChucNang = txtChucNangPB.Text.Trim();
                string NgayThanhLap = dtpNgayTL.Value.ToShortDateString();
                string SDT_Fax = txtSDTPB.Text.Trim();
                string DiaChiPB = txtDCPhong.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();
                string MaTruongPhong = cbbMaTruongPhong.Text.Trim();
                if (MaPB.Length != 0 && TenPB.Length != 0 && ChucNang.Length != 0 && SDT_Fax.Length != 0 && DiaChiPB.Length != 0 && MaTruongPhong.Length != 0)
                {
                    bool check = db.Check(MaPB, "SELECT MaPB FROM dbo.PhongBan");
                    if (check == false)
                    {
                        //( MaPB ,TenPB ,ChucNang ,NgayThanhLap ,SDT_Fax ,DiaChiPB ,GhiChu ,MaTruongPhong)
                        string insert = "INSERT INTO dbo.PhongBan VALUES  ( N'" + MaPB + "' , N'" + TenPB + "' , N'" + ChucNang + "' , '" + NgayThanhLap + "' , N'" + SDT_Fax + "' , N'" + DiaChiPB + "' , N'" + GhiChu + "' , N'" + MaTruongPhong + "'   )";
                        db.ThucThiKetNoi(insert);
                        // Update chức vụ cho trưởng phòng.
                        string updtruongphong = "UPDATE dbo.HoSoNV SET ChucVu=N'Trưởng Phòng' WHERE MaNV=N'" + MaTruongPhong + "'";
                        db.ThucThiKetNoi(updtruongphong);
                        //update trưởng phòng thuộc phòng ban.
                        string updtruongphongpb = "UPDATE dbo.HoSoNV SET MaPB=N'" + MaPB + "' WHERE MaNV=N'" + MaTruongPhong + "'";
                        db.ThucThiKetNoi(updtruongphongpb);

                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.loadDataGridView(dgvPhongBan, "SELECT * FROM dbo.PhongBan");
                    }
                    else
                    {
                        MessageBox.Show("Phòng ban đã tồn lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPB = cbbMaPB.Text.Trim();
                string TenPB = txtTenPB.Text.Trim();
                string ChucNang = txtChucNangPB.Text.Trim();
                string NgayThanhLap = dtpNgayTL.Value.ToShortDateString();
                string SDT_Fax = txtSDTPB.Text.Trim();
                string DiaChiPB = txtDCPhong.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();
                string MaTruongPhong = cbbMaTruongPhong.Text.Trim();
                if (MaPB.Length != 0 && TenPB.Length != 0 && ChucNang.Length != 0 && SDT_Fax.Length != 0 && DiaChiPB.Length != 0 && MaTruongPhong.Length != 0)
                {
                    bool check = db.Check(MaPB, "SELECT MaPB FROM dbo.PhongBan");
                    if (check == true)
                    {
                        //( MaPB ,TenPB ,ChucNang ,NgayThanhLap ,SDT_Fax ,DiaChiPB ,GhiChu ,MaTruongPhong)
                        string update = "UPDATE dbo.PhongBan SET  TenPB= N'" + TenPB + "' ,ChucNang= N'" + ChucNang + "' ,NgayThanhLap= '" + NgayThanhLap + "' ,SDT_Fax= N'" + SDT_Fax
                            + "' , DiaChiPB= N'" + DiaChiPB + "' ,GhiChu= N'" + GhiChu + "' ,MaTruongPhong = N'" + MaTruongPhong + "' WHERE MaPB=N'" + MaPB + "'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.loadDataGridView(dgvPhongBan, "SELECT * FROM dbo.PhongBan");
                    }
                    else
                    {
                        MessageBox.Show("Phòng ban không tồn lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPB = cbbMaPB.Text.Trim();
                bool check = db.Check(MaPB, "SELECT MaPB FROM dbo.PhongBan");
                if (check == true)
                {
                    /* CREATE PROC DEL_PB @MaPB NCHAR(20) AS
                     * BEGIN
                     * UPDATE dbo.HoSoNV SET MaPB=NULL WHERE MaPB=@MaPB 
                     * DELETE FROM dbo.PhongBan WHERE MaPB=@MaPB
                     * END*/
                    string del = "EXEC dbo.DEL_PB @MaPB='" + MaPB + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Tải lại datagridview và combobox PB
                    dgvPhongBan.DataSource = "";
                    cbbMaPB.Items.Clear();
                    db.loadComboBox(cbbMaPB, "SELECT MaPB FROM dbo.PhongBan");
                    db.loadDataGridView(dgvPhongBan, "SELECT * FROM dbo.PhongBan");


                }
                else
                {
                    MessageBox.Show("Phòng ban không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                //FormMain f = new FormMain();
                //f.Show();
                Close();
            }
        }

        private void buttonDSach_Click(object sender, EventArgs e)
        {
            db.loadDataGridView(dgvPhongBan, "select * from dbo.PhongBan");
        }

        private void textBoxDCPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhongBan.CurrentRow.Index;
            cbbMaPB.Text = dgvPhongBan.Rows[i].Cells[0].Value.ToString();
            txtTenPB.Text = dgvPhongBan.Rows[i].Cells[1].Value.ToString();
            txtChucNangPB.Text = dgvPhongBan.Rows[i].Cells[2].Value.ToString();
            dtpNgayTL.Text = dgvPhongBan.Rows[i].Cells[3].Value.ToString();
            txtSDTPB.Text = dgvPhongBan.Rows[i].Cells[4].Value.ToString();
            txtDCPhong.Text = dgvPhongBan.Rows[i].Cells[5].Value.ToString();
            txtGhiChu.Text = dgvPhongBan.Rows[i].Cells[6].Value.ToString();
            cbbMaTruongPhong.Text = dgvPhongBan.Rows[i].Cells[7].Value.ToString();

        }
    }
}
