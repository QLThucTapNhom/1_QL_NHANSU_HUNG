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
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }
        ConnectDatabase db = new ConnectDatabase();
        public int check = 0;
        
        private void radioButtonMaNV_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void radioButtonMaPB_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void radioButtonHoTen_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            if (search.Length!=0)
            {
                if (check == 0)
                {
                    MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (check == 1)
                {


                    try
                    {
                        string MaNV = textBoxSearch.Text.Trim();
                        string timkiem = "EXEC.TimKiemMaNV @MaNV=N'" + MaNV + "'";
                        db.loadDataGridView(dataGridView1, timkiem);
                        textBoxSearch.Text = "";

                    }
                    catch
                    {

                    }
                }
                else if (check == 2)
                {

                    try
                    {
                        string PB = textBoxSearch.Text.Trim();
                        bool temp = db.Check(PB, "SELECT * FROM dbo.PhongBan WHERE MaPB = N'" + PB + "'");

                        //MessageBox.Show(temp.ToString());

                        if (temp == false)
                        {
                            db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.PhongBan WHERE TenPB LIKE N'%" + PB + "%'");
                            textBoxSearch.Text = "";
                        }
                        else
                        {
                            db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.PhongBan WHERE MaPB = N'" + PB + "'");
                            textBoxSearch.Text = "";
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                   
                    db.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HoSoNV WHERE TenNV LIKE N'%" + search + "%'");
                    textBoxSearch.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập khóa để tìm kiếm", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
