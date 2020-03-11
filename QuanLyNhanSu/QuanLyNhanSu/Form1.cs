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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viTriBanDau();
        }

        int temp;
        public void viTriBanDau()
        {
            buttonTaiKhoan.Location = new Point(45, 80);
            buttonDanhMuc.Location = new Point(45, 130);
            buttonQuanLy.Location = new Point(45, 180);
            buttonChucNang.Location = new Point(45, 230);
            panelTaiKhoan.Hide();
            panelDanhMuc.Hide();
            panelChucNang.Hide();
            panelQuanLy.Hide();
        }
       
               

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                panelTaiKhoan.Show();
                panelTaiKhoan.Location = new Point(45, 125);
                buttonDanhMuc.Location = new Point(45, 220);
                buttonQuanLy.Location = new Point(45, 270);
                buttonChucNang.Location = new Point(45, 320);
                temp = 1;
            }
            else if (temp == 1)
            {
                viTriBanDau();
                temp = 0;
            }
        }

        private void buttonDanhMuc_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                panelDanhMuc.Show();
                panelDanhMuc.Location = new Point(45, 175);
                buttonQuanLy.Location = new Point(45, 310);
                buttonChucNang.Location = new Point(45, 360);
                temp = 1;
            }
            else if (temp == 1)
            {
                viTriBanDau();
                temp = 0;
            }
        }
        
        private void buttonQuanLy_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                panelQuanLy.Show();
                panelQuanLy.Location = new Point(45, 225);
                buttonChucNang.Location = new Point(45, 360);
                temp = 1;
            }
            else if (temp == 1)
            {
                viTriBanDau();
                temp = 0;
            }
        }

        private void buttonChucNang_Click(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                panelChucNang.Show();
                panelChucNang.Location = new Point(45, 275);
                temp = 1;
            }
            else if (temp == 1)
            {
                viTriBanDau();
                temp = 0;
            }
        }
    }
}
