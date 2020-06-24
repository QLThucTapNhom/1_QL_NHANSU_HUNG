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
    public partial class FormHoSoNV : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormHoSoNV()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            cbbMaNV.Text = "";
            txtTenNV.Text = "";
            txtHoNV.Text = "";
            cbbMaPB.Text = "";
            txtChucVu.Text = "";
            cbbLuong.Text = "";
        }

        private void FormHoSoNV_Load(object sender, EventArgs e)
        {
           
            database.loadComboBox(cbbMaPB, "SELECT MaPB FROM dbo.PhongBan");
            database.loadComboBox(cbbLuong, "SELECT MaLuong FROM dbo.Luong");
            database.loadComboBox(cbbMaNV, "SELECT MaNV FROM dbo.HoSoNV");
            database.loadDataGridView(dgvHoSo, "SELECT * FROM dbo.HoSoNV");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbbMaNV.Items.Clear();
            string MaPB= cbbMaPB.SelectedItem.ToString();
            database.loadComboBox(cbbMaNV, "SELECT MaNV FROM dbo.HoSoNV WHERE MaPB='" + MaPB + "'");

        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNV = cbbMaNV.SelectedItem.ToString();
            database.loadTextBox(txtTenNV, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(txtHoNV, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(txtChucVu, "SELECT ChucVu FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            //database.loadComboBox_Show(comboBoxMaPB, "SELECT MaPB FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            //database.loadComboBox_Show(comboBoxLuong, "SELECT MaLuong FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");

            //string query = "SELECT * FROM dbo.HoSoNV WHERE MaNV='"+MaNV+"'";
            //database.loadDataGridView(dataGridView, query);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV.Text.Trim();
                string TenNV = txtTenNV.Text.Trim();
                string HoNV = txtHoNV.Text.Trim();
                string MaPB = cbbMaPB.Text.Trim();
                string NgayKyHD = dtpNgayKyHD.Value.ToShortDateString();
                string NgayHH = dtpNgayHH.Value.ToShortDateString();
                string Chucvu = txtChucVu.Text.Trim();
                string Luong = cbbLuong.Text.Trim();
                if (MaNV.Length!=0&&TenNV.Length != 0 &&HoNV.Length != 0 &&MaPB.Length != 0&&Chucvu.Length != 0 &&Luong.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                    if (check == false)
                    {
                        string input = "INSERT INTO dbo.HoSoNV VALUES  ( N'" + MaNV + "' , N'" + TenNV + "' , N'" + HoNV + "' ,N'" + Chucvu + "' ,  N'" + MaPB + "' , '" + NgayHH + "' , '" + NgayHH + "', N'" + Luong + "' )";
                        database.ThucThiKetNoi(input);
                        MessageBox.Show("Thêm hồ sơ "+HoNV+" "+TenNV+" thành công!", "Hoàn tất", MessageBoxButtons.OK);
                        //load lại combobox Mã NV
                        cbbMaNV.Items.Clear();
                        database.loadComboBox(cbbMaNV, "SELECT MaNV FROM dbo.HoSoNV");
                        string query = "SELECT * FROM dbo.HoSoNV ";
                        database.loadDataGridView(dgvHoSo, query);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm! Nhân viên đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                
            }
            catch(Exception) {


                MessageBox.Show("Đã xảy ra lỗi hệ thống!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try {
                string MaNV = cbbMaNV.Text.TrimEnd();
                string TenNV = txtTenNV.Text.TrimEnd();
                string HoNV = txtHoNV.Text.TrimEnd();
                string MaPB = cbbMaPB.Text.TrimEnd();
                string NgayKyHD = dtpNgayKyHD.Value.ToShortDateString();
                string NgayHH = dtpNgayHH.Value.ToShortDateString();
                string Chucvu = txtChucVu.Text.TrimEnd();
                string Luong = cbbLuong.Text.TrimEnd();
                if (MaNV.Length != 0 && TenNV.Length != 0 && HoNV.Length != 0 && MaPB.Length != 0 && Chucvu.Length != 0 && Luong.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                    if (check == true)
                    {
                        string update = "UPDATE dbo.HoSoNV SET TenNV = N'" + TenNV + "' ,HoDemNV= N'" + HoNV + "' ,ChucVu=N'" + Chucvu + "' ,MaPB= N'" + MaPB + "' ,NgayKyHD= '" + NgayHH + "' ,NgayHetHanHD= '" + NgayHH + "',MaLuong= N'" + Luong + "' WHERE MaNV ='" + MaNV + "'";
                        database.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa hồ sơ NV "+MaNV+" hoàn tất!", "", MessageBoxButtons.OK);

                        string query = "SELECT * FROM dbo.HoSoNV ";
                        database.loadDataGridView(dgvHoSo, query);
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                
            }
            catch {

                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV.Text.TrimEnd();
                bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                if (check == true)
                {
                    string del = "EXEC dbo.DEL_HoSoNV @MaNV =N'"+MaNV+"'";
                    database.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa NV: "+MaNV+" hoàn tất!", "", MessageBoxButtons.OK);
                    dgvHoSo.DataSource = "";
                    //load lại combobox Mã NV
                    cbbMaNV.Items.Clear();
                    database.loadComboBox(cbbMaNV, "SELECT MaNV FROM dbo.HoSoNV");
                    string query = "SELECT * FROM dbo.HoSoNV ";
                    database.loadDataGridView(dgvHoSo, query);
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDSach_Click(object sender, EventArgs e)
        {
            database.loadDataGridView(dgvHoSo, "select * from dbo.hosonv");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHoSo.CurrentRow.Index;
            cbbMaNV.Text = dgvHoSo.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvHoSo.Rows[i].Cells[1].Value.ToString();
            txtHoNV.Text = dgvHoSo.Rows[i].Cells[2].Value.ToString();
            cbbMaPB.Text = dgvHoSo.Rows[i].Cells[4].Value.ToString();
            dtpNgayKyHD.Text = dgvHoSo.Rows[i].Cells[5].Value.ToString();
            dtpNgayHH.Text = dgvHoSo.Rows[i].Cells[6].Value.ToString();
            txtChucVu.Text = dgvHoSo.Rows[i].Cells[3].Value.ToString();
            cbbLuong.Text = dgvHoSo.Rows[i].Cells[7].Value.ToString();
        }
    }
}
