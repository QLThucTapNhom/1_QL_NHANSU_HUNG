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
        ConnectDatabase database = new ConnectDatabase();
        public FormMain()
        {            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            viTriBanDau();
            
            string query = "SELECT * FROM dbo.HoSoNV";
            database.loadDataGridView(dataGridView, query);

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
                buttonQuanLy.Location = new Point(45, 350);
                buttonChucNang.Location = new Point(45, 400);
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
                buttonChucNang.Location = new Point(45, 318);
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

        private void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                //FormMain f = new FormMain();
                //f.Show();
                Application.Exit();
            }
            
        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            UI.FormLOGIN dangNhap = new UI.FormLOGIN();
            dangNhap.Show();
            this.Close();
        }
        private void ToolStripMenuItemDN_Click(object sender, EventArgs e)
        {
            FormDangNhap dangNhap = new FormDangNhap();
            dangNhap.Show();
        }

        

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy dangKy = new FormDangKy();
            dangKy.Show();
        }
        private void ToolStripMenuItemDK_Click(object sender, EventArgs e)
        {
            FormDangKy dangKy = new FormDangKy();
            dangKy.Show();
        }



        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            FormHoSoNV hs = new FormHoSoNV();
            hs.Show();
        }

        private void buttonTTCaNhan_Click(object sender, EventArgs e)
        {
            FormTTCaNhan ttCaNhan = new FormTTCaNhan();
            ttCaNhan.Show();
        }
        private void ToolStripMenuItemTTCaNhan_Click(object sender, EventArgs e)
        {
            FormTTCaNhan ttCaNhan = new FormTTCaNhan();
            ttCaNhan.Show();
        }

        private void buttonCheDo_Click(object sender, EventArgs e)
        {
            FormCheDo cd = new FormCheDo();
            cd.Show();
        }

        private void ToolStripMenuItemDoiMK_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau changepass = new FormDoiMatKhau();
            changepass.Show();
        }

        private void ToolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            FormTimKiem search = new FormTimKiem();
            search.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormTimKiem search = new FormTimKiem();
            search.Show();
        }

        private void ToolStripMenuItemPB_Click(object sender, EventArgs e)
        {
            FormPhongBan pb = new FormPhongBan();
            pb.Show();
        }

        private void buttonPhongBan_Click(object sender, EventArgs e)
        {
            FormPhongBan pb = new FormPhongBan();
            pb.Show();
        }

        private void ToolStripMenuItemCheDo_Click(object sender, EventArgs e)
        {
            FormCheDo cd = new FormCheDo();
            cd.Show();
        }

        private void ToolStripMenuItemNhanVien_Click(object sender, EventArgs e)
        {
            FormHoSoNV hs = new FormHoSoNV();
            hs.Show();
        }

        private void buttonBacLuong_Click(object sender, EventArgs e)
        {
            FormBacLuong bl = new FormBacLuong();
            bl.Show();
        }

        private void ToolStripMenuItemBacLuong_Click(object sender, EventArgs e)
        {
            FormBacLuong bl = new FormBacLuong();
            bl.Show();
        }

        private void ToolStripMenuItemBangLuong_Click(object sender, EventArgs e)
        {
            FormBangLuong bangluong = new FormBangLuong();
            bangluong.Show();
        }

        private void buttonBangLuong_Click(object sender, EventArgs e)
        {
            FormBangLuong bangluong = new FormBangLuong();
            bangluong.Show();
        }

        private void ToolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            UI.FormLOGIN login = new UI.FormLOGIN();
            this.Hide();
            login.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
