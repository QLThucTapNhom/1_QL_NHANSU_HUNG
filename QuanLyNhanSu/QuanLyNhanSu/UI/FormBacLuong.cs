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
    public partial class FormBacLuong : Form
    {
        public FormBacLuong()
        {
            InitializeComponent();
        }
        ConnectDatabase db = new ConnectDatabase();
        private void ComboBoxBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLop = comboBoxBacLuong.Text.TrimEnd();
            db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLop + "'");
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            db.loadComboBox(comboBoxBacLuong, "SELECT MaLuong FROM dbo.Luong");
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            comboBoxBacLuong.Text = "";
            textBoxLuongCB.Text = "";
            textBoxHSLuong.Text = "";
            comboBoxHSPhuCap.Text = "";
            dataGridView1.DataSource = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text;
                string LuongCB = textBoxLuongCB.Text;
                string HSLuong = textBoxHSLuong.Text;
                string HSPhuCap = comboBoxHSPhuCap.Text;  
                bool check = db.Check(MaLuong, "SELECT MaLuong FROM dbo.Luong");

                if (check == false)
                {
                    string insert = "INSERT INTO dbo.Luong VALUES  ( N'" + MaLuong + "', N'" + LuongCB + "', N'" + HSLuong + "', N'" + HSPhuCap  + "')";
                    db.ThucThiKetNoi(insert);
                    MessageBox.Show("Thêm Bậc Lương Thành Công!");
                    db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLuong + "'");
                }
                else
                {
                    MessageBox.Show("Mã Bậc Lương đã tồn lại!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text.TrimEnd();
                bool check = db.Check(MaLuong, "SELECT MaLuong from dbo.Luong");
                if (check == true)
                {

                    string del = "EXEC dbo.DEL_Luong @MaLuong='" + MaLuong + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa Mã Lương thành công!");
                    dataGridView1.DataSource = "";

                }
                else
                {
                    MessageBox.Show("Mã Lương không tồn tại!");
                }
            }
            catch
            {
                MessageBox.Show("Đã xả ra lỗi!");
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                FormMain f = new FormMain();
                f.Show();
                Close();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text;
                string LuongCB = textBoxLuongCB.Text;
                string HSLuong = textBoxHSLuong.Text;
                string HSPhuCap = comboBoxHSPhuCap.Text;
                bool check = db.Check(MaLuong, "SELECT MaLuong FROM dbo.Luong");
                if (check == true)
                {
                    string update = "UPDATE dbo.Luong SET LuongCB=N'" + LuongCB + "', HSLuong=N'" + HSLuong
                        + "', HSPhuCap=N'" + HSPhuCap + "'";
                    db.ThucThiKetNoi(update);
                    MessageBox.Show("Sửa Lương Thành Công!");
                    db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLuong + "'");
                }
                else
                {
                    MessageBox.Show("Mã Lương không tồn tại!");
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }
    }
}
