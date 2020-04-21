using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.UI
{


    public partial class FormLOGIN : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void buttonNhapLai_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            checkBoxShow.Checked = false;
        }
        public static string useraccount;

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            
            if(textBoxUsername.Text.TrimEnd().Length!=0 &&  textBoxPassword.Text.TrimEnd().Length!=0)
            {

                string username = textBoxUsername.Text.TrimEnd();
                string password = textBoxPassword.Text.TrimEnd();


                bool check = database.Check(password, "SELECT MatKhau FROM dbo.TaiKhoan WHERE Username='"+username+"'");
                if (check == true)
                {
                    useraccount = username;
                    FormMain m = new FormMain();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Username hoặc password không chính xác!","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    checkBoxShow.Checked = false;
                }

            }
            else
            {
                
                MessageBox.Show("Vui lòng nhập đầy đủ username và password!","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                checkBoxShow.Checked = false;
            }
            

        }

        private void linkLabelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy2 dk = new FormDangKy2();
            dk.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát hay không?", "",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)

            {
                //FormMain f = new FormMain();
                //f.Show();
                Application.Exit();
            }
        }

        private void FormLOGIN_Load(object sender, EventArgs e)
        {

        }

       

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
