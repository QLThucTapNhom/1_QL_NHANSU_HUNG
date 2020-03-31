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
    public partial class FormHoSoNV : Form
    {
        ConnectDatabase database = new ConnectDatabase();
        public FormHoSoNV()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void FormHoSoNV_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.HoSoNV";
            database.loadDataGridView(dataGridView, query);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
