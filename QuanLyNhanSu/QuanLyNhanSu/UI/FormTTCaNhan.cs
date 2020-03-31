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
    public partial class FormTTCaNhan : Form
    {
        public FormTTCaNhan()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxHoNV.Text = "";
            textBoxDanToc.Text = "";
            textBoxQuocTich.Text = "";
            textBoxNguyenQuan.Text = "";
            textBoxDiaChi.Text = "";
            textBoxEmail.Text = "";
            textBoxNgoaiNgu.Text = "";
            textBoxChucVu.Text = "";
            textBoxPhongBan.Text = "";
            textBoxGhiChu.Text = "";


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
