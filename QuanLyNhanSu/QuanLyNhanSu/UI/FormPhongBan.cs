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
            comboBoxMaPB.Text = "";
            textBoxChucNangPB.Text = "";
            textBoxTenPB.Text = "";
            textBoxChucNangPB.Text = "";
            textBoxDCPhong.Text = "";
            textBoxGhiChu.Text = "";
            comboBoxMaTruongPhong.Text = "";
            textBoxSDTPB.Text = "";
            dataGridView.DataSource = "";
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            db.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
            db.loadComboBox(comboBoxMaTruongPhong, "SELECT MaNV FROM dbo.HoSoNV");
            db.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan");

        }

        private void comboBoxMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaPB = comboBoxMaPB.SelectedItem.ToString();
            db.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan WHERE MaPB=N'"+MaPB+"'");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaPB = comboBoxMaPB.Text.Trim();
                string TenPB = textBoxTenPB.Text.Trim();
                string ChucNang = textBoxChucNangPB.Text.Trim();
                string NgayThanhLap = dateTimePickerNgayTL.Value.ToShortDateString();
                string SDT_Fax = textBoxSDTPB.Text.Trim();
                string DiaChiPB = textBoxDCPhong.Text.Trim();
                string GhiChu = textBoxGhiChu.Text.Trim();
                string MaTruongPhong = comboBoxMaTruongPhong.Text.Trim();
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
                        db.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan");
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
                string MaPB = comboBoxMaPB.Text.Trim();
                string TenPB = textBoxTenPB.Text.Trim();
                string ChucNang = textBoxChucNangPB.Text.Trim();
                string NgayThanhLap = dateTimePickerNgayTL.Value.ToShortDateString();
                string SDT_Fax = textBoxSDTPB.Text.Trim();
                string DiaChiPB = textBoxDCPhong.Text.Trim();
                string GhiChu = textBoxGhiChu.Text.Trim();
                string MaTruongPhong = comboBoxMaTruongPhong.Text.Trim();
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
                        db.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan");
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
                string MaPB = comboBoxMaPB.Text.Trim();
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
                    dataGridView.DataSource = "";
                    comboBoxMaPB.Items.Clear();
                    db.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
                    db.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan");


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
            db.loadDataGridView(dataGridView, "select * from dbo.PhongBan");
        }
    }
}
