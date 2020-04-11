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
    public partial class FormPhongBan : Form
    {
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            comboBoxMaPB.Text = "";
            textBoxChucNangPB.Text = "";
            textBoxTenPB.Text = "";
            textBoxChucNangPB.Text = "";
            textBoxDCPhong.Text = "";
            textBoxGhiChu.Text = "";
            comboBoxMaTruongPhong.Text = "";
            textBoxSDTPB.Text = "";
        }
    }
}
