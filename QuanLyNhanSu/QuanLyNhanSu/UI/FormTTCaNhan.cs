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
        ConnectDatabase database = new ConnectDatabase();
        public FormTTCaNhan()
        {
            InitializeComponent();
        }
        private void FormTTCaNhan_Load(object sender, EventArgs e)
        {
            database.loadComboBox(comboBoxMaNV, "SELECT MaNV FROM dbo.HoSoNV");
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
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
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxMaNV.Text = "";
            dataGridView1.DataSource = "";
            Reset();
           


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string MaNV = comboBoxMaNV.SelectedItem.ToString();
            Reset();
            dataGridView1.DataSource = "";
            database.loadDataGridView(dataGridView1, "SELECT * FROM dbo.TTNhanVienCoBan WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(textBoxTenNV, "SELECT TenNV FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(textBoxHoNV, "SELECT HoDemNV FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(textBoxChucVu, "SELECT ChucVu  FROM dbo.HoSoNV WHERE MaNV='"+MaNV+"'");
            database.loadTextBox(textBoxPhongBan, "SELECT MaPB  FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
        }

        private void buttonHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = comboBoxMaNV.Text.Trim();
                string TenNV = textBoxTenNV.Text.Trim();
                string HoNV = textBoxHoNV.Text.Trim();
                string GTinh = comboBoxGTinh.Text.TrimEnd();
                string NSinh = dateTimePickerNS.Value.ToShortDateString();
                string QuocTich=textBoxQuocTich.Text.Trim();
                string NguyenQuan = textBoxNguyenQuan.Text.Trim();
                string DiaChi = textBoxDiaChi.Text.Trim();
                string SDT_Email = textBoxEmail.Text.Trim();
                string NgoaiNgu = textBoxNgoaiNgu.Text.Trim();
                string HocVan = textBoxHocVan.Text.Trim();
                string GhiChu = textBoxGhiChu.Text.Trim();

                if (MaNV.Length != 0 && TenNV.Length != 0 && HoNV.Length != 0 && GTinh.Length != 0 && QuocTich.Length != 0 
                    && NguyenQuan.Length != 0&&DiaChi.Length != 0&&SDT_Email.Length != 0&&HocVan.Length != 0&&NgoaiNgu.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.TTNhanVienCoBan");
                    if (check == false)
                    {
                        //( MaNV ,TenNV ,HoDemNV ,GioiTinh ,NgaySinh ,QuocTich ,NguyenQuan ,DiaChi ,SDT_Email ,NgoaiNgu , HocVan , GhiChu )
                        string insert = "INSERT INTO dbo.TTNhanVienCoBan ( MaNV ,TenNV ,HoDemNV ,GioiTinh ,NgaySinh ,QuocTich ,NguyenQuan ,DiaChi ,SDT_Email ,NgoaiNgu , HocVan , GhiChu ) "
                              + "VALUES(N'" + MaNV + "', N'" + TenNV + "', N'" + HoNV + "', N'" + GTinh + "','" + NSinh + "', N'" + QuocTich + "',"
                              + "N'" + NguyenQuan + "', N'" + DiaChi + "', N'" + SDT_Email + "', N'" + NgoaiNgu + "', N'" + HocVan + "',N'" + GhiChu + "')";
                        database.ThucThiKetNoi(insert);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //load lại dataGridView1
                        dataGridView1.DataSource = "";
                        string query = "SELECT * FROM dbo.TTNhanVienCoBan WHERE MaNV='" + MaNV + "'";
                        database.loadDataGridView(dataGridView1, query);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin NV " + HoNV + " " + TenNV + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập điền đầy đủ bắt buộc đến trường học vấn!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = comboBoxMaNV.Text.Trim();
                string GTinh = comboBoxGTinh.Text.Trim();
                string NSinh = dateTimePickerNS.Value.ToShortDateString();
                string QuocTich = textBoxQuocTich.Text.Trim();
                string NguyenQuan = textBoxNguyenQuan.Text.Trim();
                string DiaChi = textBoxDiaChi.Text.Trim();
                string SDT_Email = textBoxEmail.Text.Trim();
                string NgoaiNgu = textBoxNgoaiNgu.Text.Trim();
                string HocVan = textBoxHocVan.Text.Trim();
                string GhiChu = textBoxGhiChu.Text.Trim();
                if (MaNV.Length != 0 && GTinh.Length != 0 && QuocTich.Length != 0
                    && NguyenQuan.Length != 0 && DiaChi.Length != 0 && SDT_Email.Length != 0 && HocVan.Length != 0 && NgoaiNgu.Length != 0)
                {
                    bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.TTNhanVienCoBan");

                    if (check == true)
                    {
                        //( MaNV ,TenNV ,HoDemNV ,GioiTinh ,NgaySinh ,QuocTich ,NguyenQuan ,DiaChi ,SDT_Email ,NgoaiNgu , HocVan , GhiChu )
                        string update = "UPDATE dbo.TTNhanVienCoBan SET "
                              + "GioiTinh = N'" + GTinh + "',NgaySinh='" + NSinh + "',QuocTich= N'" + QuocTich + "',"
                              + "NguyenQuan= N'" + NguyenQuan + "',DiaChi= N'" + DiaChi + "',SDT_Email= N'" + SDT_Email + "',NgoaiNgu= N'"
                              + NgoaiNgu + "',HocVan= N'" + HocVan + "',GhiChu = N'" + GhiChu + "' WHERE MaNV='" + MaNV + "'";
                        database.ThucThiKetNoi(update);
                        MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //load lại dataGridView1
                        dataGridView1.DataSource = "";
                        string query = "SELECT * FROM dbo.TTNhanVienCoBan WHERE MaNV='" + MaNV + "'";
                        database.loadDataGridView(dataGridView1, query);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhân viên chưa được thêm!", "Không thể sửa!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ bắt buộc đến trường học vấn!", "Không thể sửa!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


                    
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Xóa
        {
            try
            {
                string MaNV = comboBoxMaNV.Text.Trim();
                bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.TTNhanVienCoBan");

                if (check == true)
                {
                    //( MaNV ,TenNV ,HoDemNV ,GioiTinh ,NgaySinh ,QuocTich ,NguyenQuan ,DiaChi ,SDT_Email ,NgoaiNgu , HocVan , GhiChu )
                    string del = "DELETE FROM dbo.TTNhanVienCoBan WHERE MaNV='"+MaNV+"'";
                    database.ThucThiKetNoi(del);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //load lại dataGridView1
                    dataGridView1.DataSource = "";
                }
                else
                {
                    MessageBox.Show("Thông tin nhân viên chưa được thêm!", "Không thể xóa!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonDSach_Click(object sender, EventArgs e)
        {
            database.loadDataGridView(dataGridView1, "select * from dbo.TTNhanVienCoBan");
        }
    }
}
