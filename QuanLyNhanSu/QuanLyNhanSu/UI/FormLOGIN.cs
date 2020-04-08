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
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            
            if(textBoxUsername.Text.TrimEnd().Length!=0 &&  textBoxPassword.Text.TrimEnd().Length!=0)
            {

                string username = textBoxUsername.Text.TrimEnd();
                string password = textBoxPassword.Text.TrimEnd();


                bool check = database.Check(password, "SELECT MatKhau FROM dbo.TaiKhoan WHERE Username='"+username+"'");
                if (check == true)
                {
                    FormMain main = new FormMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password doesn't correct!","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                //FormMain main = new FormMain();
                //main.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Please typing your username and password!","", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy2 dk2 = new FormDangKy2();
            dk2.Show();
            this.Hide();
 
        }
    }
}
