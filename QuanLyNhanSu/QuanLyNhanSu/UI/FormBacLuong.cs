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
            db.loadComboBox(cbbBacLuong, "SELECT MaLuong FROM dbo.Luong");
            db.loadDataGridView(dgvBacLuong, "SELECT * FROM dbo.Luong");
        }

        private void comboBoxBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string MaLuong = comboBoxBacLuong.Text.TrimEnd();
            //db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.Luong WHERE MaLuong='" + MaLuong + "'");
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            cbbBacLuong.Text = "";
            txtLuongCB.Text = "";
            txtHSLuong.Text = "";
            txtHSPhuCap.Text = "";
            dgvBacLuong.DataSource = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLuong = cbbBacLuong.Text.Trim();
                string LuongCB = txtLuongCB.Text.Trim();
                string HSLuong = txtHSLuong.Text.Trim();
                string HSPhuCap = txtHSPhuCap.Text.Trim();
                if (MaLuong.Length != 0 && LuongCB.Length != 0 && HSLuong.Length != 0 && HSPhuCap.Length != 0)
                {
                    bool check = db.Check(MaLuong, "SELECT MaLuong FROM dbo.Luong");
                    if (check == false)
                    {
                        string insert = "INSERT INTO dbo.Luong VALUES  ( N'" + MaLuong + "', N'" + LuongCB + "', N'" + HSLuong + "', N'" + HSPhuCap + "')";
                        db.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm Bậc Lương Thành Công!");
                        db.loadDataGridView(dgvBacLuong, "SELECT * FROM dbo.Luong");
                        cbbBacLuong.Items.Clear();
                        db.loadComboBox(cbbBacLuong, "SELECT MaLuong FROM dbo.Luong");
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
                string MaLuong = cbbBacLuong.Text.Trim();
                string LuongCB = txtLuongCB.Text.Trim();
                string HSLuong = txtHSLuong.Text.Trim();
                string HSPhuCap = txtHSPhuCap.Text.Trim();
                if (MaLuong.Length != 0 && LuongCB.Length != 0 && HSLuong.Length != 0 && HSPhuCap.Length != 0)
                {
                    bool check = db.Check(MaLuong, "SELECT MaLuong FROM dbo.Luong");
                    if (check == true)
                    {
                        string update = "UPDATE dbo.Luong SET LuongCB=N'" + LuongCB + "', HSLuong=N'" + HSLuong
                            + "', HSPhuCap=N'" + HSPhuCap + "'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa Lương Thành Công!");
                        db.loadDataGridView(dgvBacLuong, "SELECT * FROM dbo.Luong");
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
                string MaLuong = cbbBacLuong.Text.TrimEnd();
                bool check = db.Check(MaLuong, "SELECT MaLuong from dbo.Luong");
                if (check == true)
                {

                    string del = "EXEC dbo.DEL_Luong @MaLuong='" + MaLuong + "'";
                    db.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa hoàn tất!");
                    //Tải lại datagridview và combobox Bậc lương
                    dgvBacLuong.DataSource = "";
                    cbbBacLuong.Items.Clear();
                    db.loadComboBox(cbbBacLuong, "SELECT MaLuong FROM dbo.Luong");
                    db.loadDataGridView(dgvBacLuong, "SELECT * FROM dbo.Luong");


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

            db.loadDataGridView(dgvBacLuong, "select * from dbo.luong");
        }

        private void dgvBacLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBacLuong.CurrentRow.Index;
            cbbBacLuong.Text = dgvBacLuong.Rows[i].Cells[0].Value.ToString();
            txtLuongCB.Text = dgvBacLuong.Rows[i].Cells[1].Value.ToString();
            txtHSLuong.Text = dgvBacLuong.Rows[i].Cells[2].Value.ToString();
            txtHSPhuCap.Text = dgvBacLuong.Rows[i].Cells[3].Value.ToString();
         
        }
    }
}
