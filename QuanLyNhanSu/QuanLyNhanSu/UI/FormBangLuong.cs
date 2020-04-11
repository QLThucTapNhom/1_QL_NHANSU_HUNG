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
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }

        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBacLuong.TinhLuongNhanVien' table. You can move, or remove it, as needed.
            this.TinhLuongNhanVienTableAdapter.Fill(this.DataSetBacLuong.TinhLuongNhanVien);
            // TODO: This line of code loads data into the 'DataSetBangLuong.TinhLuongNhanVien' table. You can move, or remove it, as needed.
            //this.TinhLuongNhanVienTableAdapter.Fill(this.DataSetBangLuong.TinhLuongNhanVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
