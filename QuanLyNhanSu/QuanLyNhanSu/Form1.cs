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

        public string user;

        ConnectDatabase database = new ConnectDatabase();
        public FormMain()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            viTriBanDau();
            user = UI.FormLOGIN.useraccount;
            string loichao ="Hello "+ user + "!";
            labelChao.Text = loichao;
            int toado = 787 - 10* user.Length;
            labelChao.Location= new Point(toado, 50);
            
            string query = "SELECT * FROM dbo.HoSoNV";
            database.loadDataGridView(dataGridView1, query);

        }

        int temp;
        public void viTriBanDau()
        {
            buttonTaiKhoan.Location = new Point(15, 80);
            buttonDanhMuc.Location = new Point(15, 130);
            buttonQuanLy.Location = new Point(15, 180);
            buttonChucNang.Location = new Point(15, 230);
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
                panelTaiKhoan.Location = new Point(15, 125);
                buttonDanhMuc.Location = new Point(15, 220);
                buttonQuanLy.Location = new Point(15, 270);
                buttonChucNang.Location = new Point(15, 320);
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
                panelDanhMuc.Location = new Point(15, 175);
                buttonQuanLy.Location = new Point(15, 305);
                buttonChucNang.Location = new Point(15, 355);
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
                panelQuanLy.Location = new Point(15, 225);
                buttonChucNang.Location = new Point(15, 318);
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
                panelChucNang.Location = new Point(15, 275);
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

            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không?", "Tạm biệt "+user+"!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)

            {
                //FormMain f = new FormMain();
                //f.Show();
                Application.Exit();
            }
            
        }

        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ToolStripMenuItemDN_Click(object sender, EventArgs e)
        {
            UI.FormLOGIN lg = new UI.FormLOGIN() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lg.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(lg);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != lg)
                    ctrl.Dispose();
            }
            lg.Show();

            //FormDangNhap dangNhap = new FormDangNhap();
            //dangNhap.Show();
        }


        private void buttonNhanVien_Click(object sender, EventArgs e)
        {

            FormHoSoNV hs = new FormHoSoNV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hs.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(hs);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != hs)
                    ctrl.Dispose();
            }
            hs.Show();

            //FormHoSoNV hs = new FormHoSoNV();
            //hs.Show();
        }

        private void buttonTTCaNhan_Click(object sender, EventArgs e)
        {

            FormTTCaNhan ttCaNhan = new FormTTCaNhan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ttCaNhan.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(ttCaNhan);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != ttCaNhan)
                    ctrl.Dispose();
            }
            ttCaNhan.Show();


            //FormTTCaNhan ttCaNhan = new FormTTCaNhan();
            //ttCaNhan.Show();
        }
        

        private void buttonCheDo_Click(object sender, EventArgs e)
        {


            FormCheDo cd = new FormCheDo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cd.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(cd);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != cd)
                    ctrl.Dispose();
            }
            cd.Show();
            //FormCheDo cd = new FormCheDo();
            //cd.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormTimKiem search = new FormTimKiem() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            search.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(search);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != search)
                    ctrl.Dispose();
            }
            search.Show();
            //FormTimKiem search = new FormTimKiem();
            //search.Show();
        }


        private void buttonPhongBan_Click(object sender, EventArgs e)
        {

            FormPhongBan PB = new FormPhongBan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PB.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(PB);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != PB)
                    ctrl.Dispose();
            }
            PB.Show();
            //FormPhongBan pb = new FormPhongBan();
            //pb.Show();
        }

        

        

        private void buttonBacLuong_Click(object sender, EventArgs e)
        {

            FormBacLuong bl = new FormBacLuong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bl.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(bl);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != bl)
                    ctrl.Dispose();
            }
            bl.Show();
            //FormBacLuong bl = new FormBacLuong();
            //bl.Show();
        }


        private void buttonBangLuong_Click(object sender, EventArgs e)
        {
            FormBangLuong bangluong = new FormBangLuong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bangluong.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(bangluong);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != bangluong)
                    ctrl.Dispose();
            }
            bangluong.Show();
            //FormBangLuong bangluong = new FormBangLuong();
            //bangluong.Show();
        }

        
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.FormDangKy2 dk = new UI.FormDangKy2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dk.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(dk);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != dk)
                    ctrl.Dispose();
            }
            dk.Show();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn đăng xuất không, "+user+"!", "",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)

            {
                UI.FormLOGIN lg = new UI.FormLOGIN();
                lg.Show();
                this.Hide();
            }
            


        }

        private void ToolStripMenuItemDoiMK_Click(object sender, EventArgs e)
        {

            FormDoiMatKhau changepass = new FormDoiMatKhau() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            changepass.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(changepass);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != changepass)
                    ctrl.Dispose();
            }
            changepass.Show();
            //FormDoiMatKhau changepass = new FormDoiMatKhau();
            //changepass.Show();
        }

        private void buttonTroGiup_Click(object sender, EventArgs e)
        {
            UI.FormTroGiup support = new UI.FormTroGiup() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            support.FormBorderStyle = FormBorderStyle.None;
            this.panelShow.Controls.Add(support);
            foreach (Control ctrl in panelShow.Controls)
            {
                if (ctrl != support)
                    ctrl.Dispose();
            }
            support.Show();
        }
    }
}
