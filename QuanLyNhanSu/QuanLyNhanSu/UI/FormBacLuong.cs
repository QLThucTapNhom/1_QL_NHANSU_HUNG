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
        ConnectDatabase db = new ConnectDatabase();
        public FormBacLuong()
        {
            InitializeComponent();
        }

        private void FormBacLuong_Load(object sender, EventArgs e)
        {
            db.loadComboBox(comboBoxBacLuong, "SELECT MaLuong FROM dbo.Luong");
        }

        private void comboBoxBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLuong = comboBoxBacLuong.Text.TrimEnd();
            db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLuong + "'");
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            comboBoxBacLuong.Text = "";
            textBoxLuongCB.Text = "";
            textBoxHSLuong.Text = "";
            textBoxHSPhuCap.Text = "";
            dataGridView1.DataSource = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text.Trim();
                string LuongCB = textBoxLuongCB.Text.Trim();
                string HSLuong = textBoxHSLuong.Text.Trim();
                string HSPhuCap = textBoxHSPhuCap.Text.Trim();
                if (MaLuong.Length != 0 && LuongCB.Length != 0 && HSLuong.Length != 0 && HSPhuCap.Length != 0)
                {
                    bool check = db.Check(MaLuong, "SELECT MaLuong FROM dbo.Luong");
                    if (check == false)
                    {
                        string insert = "INSERT INTO dbo.Luong VALUES  ( N'" + MaLuong + "', N'" + LuongCB + "', N'" + HSLuong + "', N'" + HSPhuCap + "')";
                        db.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm Bậc Lương Thành Công!");
                        db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLuong + "'");
                        comboBoxBacLuong.Items.Clear();
                        db.loadComboBox(comboBoxBacLuong, "SELECT MaLuong FROM dbo.Luong");
                    }
                    else
                    {
                        MessageBox.Show("Mã Bậc Lương đã tồn lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                

            }
            catch
            {
                MessageBox.Show("Lỗi không thể thêm!","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text.Trim();
                string LuongCB = textBoxLuongCB.Text.Trim();
                string HSLuong = textBoxHSLuong.Text.Trim();
                string HSPhuCap = textBoxHSPhuCap.Text.Trim();
                if (MaLuong.Length != 0 && LuongCB.Length != 0 && HSLuong.Length != 0 && HSPhuCap.Length != 0)
                {
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
                        MessageBox.Show("Mã Lương không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = comboBoxBacLuong.Text.TrimEnd();
                bool check = db.Check(MaLuong, "SELECT MaLuong from dbo.Luong");
                if (check == true)
                {

                    string del = "EXEC dbo.DEL_Luong @MaLuong='" + MaLuong + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa hoàn tất!");
                    //Tải lại datagridview và combobox Bậc lương
                    dataGridView1.DataSource = "";
                    comboBoxBacLuong.Items.Clear();
                    db.loadComboBox(comboBoxBacLuong, "SELECT MaLuong FROM dbo.Luong");


                }
                else
                {
                    MessageBox.Show("Mã Lương không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Đã xả ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void textBoxLuongCB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDSach_Click(object sender, EventArgs e)
        {

            db.loadDataGridView(dataGridView1, "select * from dbo.luong");
        }
    }
}
