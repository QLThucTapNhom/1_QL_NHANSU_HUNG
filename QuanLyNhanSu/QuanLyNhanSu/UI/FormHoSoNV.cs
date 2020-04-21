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
            comboBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxHoNV.Text = "";
            comboBoxMaPB.Text = "";
            textBoxChucVu.Text = "";
            comboBoxLuong.Text = "";
        }

        private void FormHoSoNV_Load(object sender, EventArgs e)
        {
           
            database.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
            database.loadComboBox(comboBoxLuong, "SELECT MaLuong FROM dbo.Luong");
            database.loadComboBox(comboBoxMaNV, "SELECT MaNV FROM dbo.HoSoNV");
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

            comboBoxMaNV.Items.Clear();
            string MaPB= comboBoxMaPB.SelectedItem.ToString();
            database.loadComboBox(comboBoxMaNV, "SELECT MaNV FROM dbo.HoSoNV WHERE MaPB='" + MaPB + "'");

        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNV = comboBoxMaNV.SelectedItem.ToString();
            string query = "SELECT * FROM dbo.HoSoNV WHERE MaNV='"+MaNV+"'";
            database.loadDataGridView(dataGridView, query);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = comboBoxMaNV.Text.Trim();
                string TenNV = textBoxTenNV.Text.Trim();
                string HoNV = textBoxHoNV.Text.Trim();
                string MaPB = comboBoxMaPB.Text.Trim();
                string NgayKyHD = dateTimePicker2.Value.ToShortDateString();
                string NgayHH = dateTimePicker1.Value.ToShortDateString();
                string Chucvu = textBoxChucVu.Text.Trim();
                string Luong = comboBoxLuong.Text.Trim();
                if (MaNV.Length!=0&&TenNV.Length != 0 &&HoNV.Length != 0 &&MaPB.Length != 0&&Chucvu.Length != 0 &&Luong.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                    if (check == false)
                    {
                        string input = "INSERT INTO dbo.HoSoNV VALUES  ( N'" + MaNV + "' , N'" + TenNV + "' , N'" + HoNV + "' ,N'" + Chucvu + "' ,  N'" + MaPB + "' , '" + NgayHH + "' , '" + NgayHH + "', N'" + Luong + "' )";
                        database.ThucThiKetNoi(input);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //load lại combobox Mã NV
                        comboBoxMaNV.Items.Clear();
                        database.loadComboBox(comboBoxMaNV, "SELECT MaNV FROM dbo.HoSoNV");
                        string query = "SELECT * FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'";
                        database.loadDataGridView(dataGridView, query);
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


                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try {
                string MaNV = comboBoxMaNV.Text.TrimEnd();
                string TenNV = textBoxTenNV.Text.TrimEnd();
                string HoNV = textBoxHoNV.Text.TrimEnd();
                string MaPB = comboBoxMaPB.Text.TrimEnd();
                string NgayKyHD = dateTimePicker2.Value.ToShortDateString();
                string NgayHH = dateTimePicker1.Value.ToShortDateString();
                string Chucvu = textBoxChucVu.Text.TrimEnd();
                string Luong = comboBoxLuong.Text.TrimEnd();
                if (MaNV.Length != 0 && TenNV.Length != 0 && HoNV.Length != 0 && MaPB.Length != 0 && Chucvu.Length != 0 && Luong.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                    if (check == true)
                    {
                        string update = "UPDATE dbo.HoSoNV SET TenNV = N'" + TenNV + "' ,HoDemNV= N'" + HoNV + "' ,ChucVu=N'" + Chucvu + "' ,MaPB= N'" + MaPB + "' ,NgayKyHD= '" + NgayHH + "' ,NgayHetHanHD= '" + NgayHH + "',MaLuong= N'" + Luong + "' WHERE MaNV ='" + MaNV + "'";
                        database.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        string query = "SELECT * FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'";
                        database.loadDataGridView(dataGridView, query);
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
                string MaNV = comboBoxMaNV.Text.TrimEnd();
                bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.HoSoNV");
                if (check == true)
                {
                    string del = "EXEC dbo.DEL_HoSoNV @MaNV =N'"+MaNV+"'";
                    database.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView.DataSource = "";
                    //load lại combobox Mã NV
                    comboBoxMaNV.Items.Clear();
                    database.loadComboBox(comboBoxMaNV, "SELECT MaNV FROM dbo.HoSoNV");
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
            database.loadDataGridView(dataGridView, "select * from dbo.hosonv");
        }
    }
}
