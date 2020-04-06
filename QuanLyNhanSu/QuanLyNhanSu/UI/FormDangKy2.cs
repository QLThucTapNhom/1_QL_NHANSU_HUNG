﻿using System;
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
    public partial class FormDangKy2 : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormDangKy2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelThongBao_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.TrimEnd();
            string pass = textBoxPassword.Text.Trim();
            string confirm = textBoxConfirm.Text.TrimEnd();
            string email = textBoxEmail.Text.Trim();

            bool check = database.Check(username, "SELECT Username FROM dbo.TaiKhoan");

            if(username.Length!=0 && pass.Length!=0 && confirm.Length!=0 && email.Length != 0)
            {
                if (check == false)
                {
                    if (confirm == pass)
                    {
                        string insert = "INSERT INTO dbo.TaiKhoan VALUES  ( '" + username + "' ,'" + pass + "' ,N'" + email + "' ,1)";
                        database.ThucThiKetNoi(insert);
                        DialogResult result;
                        result = MessageBox.Show("Bạn muốn đăng nhập không?", "Đăng Ký Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            FormLOGIN lg = new FormLOGIN();
                            lg.Show();
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        labelThongBao.Text = "Confirm Password doesn't correct!";
                    }
                    

                }
                else {
                    labelThongBao.Text = "Tài khoản đã tồn tại! Vui lòng thử lại!";
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            FormLOGIN lg = new FormLOGIN();
            lg.Show();
            this.Close();
        }

        private void buttonNhapLai_Click(object sender, EventArgs e)
        {

            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirm.Text = "";
            textBoxEmail.Text = "";
            labelThongBao.Text = "";
        }
    }
}
