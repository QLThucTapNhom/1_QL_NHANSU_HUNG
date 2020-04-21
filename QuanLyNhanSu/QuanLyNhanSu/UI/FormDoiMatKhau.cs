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
    public partial class FormDoiMatKhau : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

       

        private void buttonHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = textBoxUsername.Text.Trim();
                string oldPass = textBoxOldPassword.Text.Trim();
                string confirm = textBoxConfirm.Text.Trim();
                string newPass = textBoxNewPassword.Text.Trim();
                bool check = db.Check(oldPass, "SELECT MatKhau FROM dbo.TaiKhoan WHERE Username=N'" + userName + "'");
                bool check1 = db.Check(userName, "SELECT Username FROM dbo.TaiKhoan");

                if (userName.Length != 0 && oldPass.Length != 0 && confirm.Length != 0 && newPass.Length != 0)
                {

                    if (check1 == true)  //Nếu tài khoản tồn tại
                    {
                        if (check == true) //Nếu mật khẩu là đúng
                        {
                            if (newPass == confirm)
                            {
                                string update = "UPDATE dbo.TaiKhoan SET MatKhau=N'" + newPass + "' WHERE Username=N'" + userName + "'";
                                db.ThucThiKetNoi(update);
                                MessageBox.Show("Mật khẩu của bạn đã được cập nhật!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                            }
                            else
                            {
                                MessageBox.Show("Confirm không đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các trường!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng thử lại!", "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
            
        }

        private void buttonNhapLai_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxOldPassword.Text = "";
            textBoxConfirm.Text = "";
            textBoxNewPassword.Text = "";
            checkBoxShow.Checked = false;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxOldPassword.UseSystemPasswordChar = true;
                textBoxNewPassword.UseSystemPasswordChar = true;
                textBoxConfirm.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxOldPassword.UseSystemPasswordChar = false;
                textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxConfirm.UseSystemPasswordChar = false;
            }
        }
    }
}
