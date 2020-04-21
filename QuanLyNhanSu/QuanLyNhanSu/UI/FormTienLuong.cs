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
    public partial class FormTienLuong : Form
    {
        ConnectDatabase db = new ConnectDatabase();
        public FormTienLuong()
        {
            InitializeComponent();
        }

        private void FormTienLuong_Load(object sender, EventArgs e)
        {
            db.loadDataGridView(dataGridView1, "select * from dbo.TinhLuong");
        }
    }
}
