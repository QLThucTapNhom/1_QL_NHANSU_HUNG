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
        ConnectDatabase data = new ConnectDatabase();
        
        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void clean()
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
        private void buttonNew_Click(object sender, EventArgs e)
        {
            clean();
            
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            data.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
            data.loadComboBox(comboBoxMaTruongPhong, "SELECT MaNV FROM dbo.HoSoNV WHERE ChucVu = N'Trưởng Phòng'");
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void comboBoxMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPB = comboBoxMaPB.SelectedItem.ToString();
            string query = "SELECT * FROM dbo.PhongBan WHERE MaPB='" + maPB + "'";
            data.loadDataGridView(dataGridView, query);
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string maPB = comboBoxMaPB.Text.TrimEnd();
                string tenPB = textBoxTenPB.Text.TrimEnd();
                string chucnang = textBoxChucNangPB.Text.TrimEnd();
                string ngayTL = dateTimePickerNgayTL.Value.ToShortDateString();
                string sdt = textBoxSDTPB.Text.TrimEnd();
                string phong = textBoxDCPhong.Text.TrimEnd();
                string ghichu = textBoxGhiChu.Text.TrimEnd();                
                string maTP = comboBoxMaTruongPhong.Text.TrimEnd();

                bool check = data.Check(maPB, "SELECT MaPB FROM dbo.PhongBan");               
                
                if (check == false)
                {
                    string insert = "INSERT INTO dbo.PhongBan VALUES  ( N'" + maPB + "', N'" + tenPB + "', N'" + chucnang + "', N'" + ngayTL + "', N'" + sdt + "', N'" + phong + "', N'" + ghichu + "', N'" + maTP + "')";
                    data.ThucThiKetNoi(insert);
                    MessageBox.Show("Thêm Phòng Ban Thành Công!");
                    data.loadDataGridView(dataGridView, "SELECT * FROM dbo.PhongBan WHERE maPB='" + maPB + "'");                  
                    
                    comboBoxMaPB.Items.Clear();
                    data.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
                    
                }
                else
                {
                    MessageBox.Show("Mã Phòng ban đã tồn lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                  
                  
                
            }
            catch {
                MessageBox.Show("Lỗi không thể thêm!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maPB = comboBoxMaPB.Text.TrimEnd();
                bool check = data.Check(maPB, "SELECT MaPB FROM dbo.PhongBan");
                if (check == true)
                {
                    string del = "EXEC dbo.DEL_PhongBan @MaPB =N'" + maPB + "'";
                    data.ThucThiKetNoi(del);
                    MessageBox.Show("Xóa Thành Công!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView.DataSource = "";                    
                    comboBoxMaPB.Items.Clear();
                    data.loadComboBox(comboBoxMaPB, "SELECT MaPB FROM dbo.PhongBan");
                }
                else
                {
                    MessageBox.Show("Phòng ban không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                clean();
            }
            catch
            {
                MessageBox.Show("Không thể xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string maPB = comboBoxMaPB.Text.TrimEnd();
                string tenPB = textBoxTenPB.Text.TrimEnd();
                string chucnang = textBoxChucNangPB.Text.TrimEnd();
                string ngayTL = dateTimePickerNgayTL.Value.ToShortDateString();
                string sdt = textBoxSDTPB.Text.TrimEnd();
                string phong = textBoxDCPhong.Text.TrimEnd();
                string ghichu = textBoxGhiChu.Text.TrimEnd();
                string maTP = comboBoxMaTruongPhong.Text.TrimEnd();
                bool check = data.Check(maPB, "SELECT MaPB FROM dbo.PhongBan");
                bool check1 = data.Check(maTP, "SELECT MaNV FROM dbo.HoSoNV");
                if (check == true && check1 == true)
                {
                    string update = "UPDATE dbo.PhongBan SET MaPB = N'" + maPB + "' ,TenPB= N'" + tenPB + "' ,ChucNang=N'" + chucnang + "' ,NgayThanhLap= N'" + ngayTL + "' ,SDT_Fax= '" + sdt + "' ,DiaChiPB = '"+ phong +"',GhiChu = '" + ghichu + "',MaTruongPhong= N'" + maTP + "' WHERE MaPB ='" + maPB + "'";
                    data.ThucThiKetNoi(update);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string query = "SELECT * FROM dbo.PhongBan WHERE MaPB='" + maPB + "'";
                    data.loadDataGridView(dataGridView, query);
                }
                else
                {
                    MessageBox.Show("Thông tin không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                clean();
            }
            catch
            {
                MessageBox.Show("Cập nhật lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void comboBoxMaTruongPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string maTP = comboBoxMaTruongPhong.SelectedItem.ToString();
            data.loadComboBox(comboBoxMaTruongPhong, "SELECT MaTruongPhong FROM dbo.PhongBan WHERE MaTruongPhong = '"+ maTP +"'");

        }
    }
}
