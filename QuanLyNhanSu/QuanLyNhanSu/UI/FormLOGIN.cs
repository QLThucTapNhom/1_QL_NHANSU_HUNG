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
            
            if(textBoxUsername.Text.Length==0 && textBoxPassword.Text.Length==0)
            {
                MessageBox.Show("Please typing your username and password!");
            }
            else
            {
                FormMain main = new FormMain();
                main.Show();
                this.Hide();
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
        }
    }
}
