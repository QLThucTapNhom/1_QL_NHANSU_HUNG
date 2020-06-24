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
            database.loadComboBox(cbbMaNV, "SELECT MaNV FROM dbo.HoSoNV");
            database.loadDataGridView(dgvTTCN, "SELECT * FROM dbo.TTNhanVienCoBan");
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            txtTenNV.Text = "";
            txtHoNV.Text = "";
            txtDanToc.Text = "";
            txtQuocTich.Text = "";
            txtNguyenQuan.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtNgoaiNgu.Text = "";
            txtChucVu.Text = "";
            txtPhongBan.Text = "";
            txtGhiChu.Text = "";
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            cbbMaNV.Text = "";
            dgvTTCN.DataSource = "";
            Reset();
           


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

            string MaNV = cbbMaNV.SelectedItem.ToString();
            //Reset();
            //dgvTTCN.DataSource = "";
            //database.loadDataGridView(dgvTTCN, "SELECT * FROM dbo.TTNhanVienCoBan WHERE MaNV='" + MaNV + "'");
            
            database.loadTextBox(txtChucVu, "SELECT ChucVu  FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
            database.loadTextBox(txtPhongBan, "SELECT MaPB  FROM dbo.HoSoNV WHERE MaNV='" + MaNV + "'");
        }

        private void buttonHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = cbbMaNV.Text.Trim();
                string TenNV = txtTenNV.Text.Trim();
                string HoNV = txtHoNV.Text.Trim();
                string GTinh = cbbGTinh.Text.TrimEnd();
                string NSinh = dtpNS.Value.ToShortDateString();
                string QuocTich=txtQuocTich.Text.Trim();
                string NguyenQuan = txtNguyenQuan.Text.Trim();
                string DiaChi = txtDiaChi.Text.Trim();
                string SDT_Email = txtEmail.Text.Trim();
                string NgoaiNgu = txtNgoaiNgu.Text.Trim();
                string HocVan = txtHocVan.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();

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
                        dgvTTCN.DataSource = "";
                        string query = "SELECT * FROM dbo.TTNhanVienCoBan";
                        database.loadDataGridView(dgvTTCN, query);
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
                string MaNV = cbbMaNV.Text.Trim();
                string GTinh = cbbGTinh.Text.Trim();
                string NSinh = dtpNS.Value.ToShortDateString();
                string QuocTich = txtQuocTich.Text.Trim();
                string NguyenQuan = txtNguyenQuan.Text.Trim();
                string DiaChi = txtDiaChi.Text.Trim();
                string SDT_Email = txtEmail.Text.Trim();
                string NgoaiNgu = txtNgoaiNgu.Text.Trim();
                string HocVan = txtHocVan.Text.Trim();
                string GhiChu = txtGhiChu.Text.Trim();
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
                        dgvTTCN.DataSource = "";
                        string query = "SELECT * FROM dbo.TTNhanVienCoBan";
                        database.loadDataGridView(dgvTTCN, query);
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
                string MaNV = cbbMaNV.Text.Trim();
                bool check = database.Check(MaNV, "SELECT MaNV FROM dbo.TTNhanVienCoBan");

                if (check == true)
                {
                    //( MaNV ,TenNV ,HoDemNV ,GioiTinh ,NgaySinh ,QuocTich ,NguyenQuan ,DiaChi ,SDT_Email ,NgoaiNgu , HocVan , GhiChu )
                    string del = "DELETE FROM dbo.TTNhanVienCoBan WHERE MaNV='"+MaNV+"'";
                    database.ThucThiKetNoi(del);
                    MessageBox.Show("Hoàn Tất!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //load lại dataGridView1
                    dgvTTCN.DataSource = "";
                    string query = "SELECT * FROM dbo.TTNhanVienCoBan";
                    database.loadDataGridView(dgvTTCN, query);
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
            database.loadDataGridView(dgvTTCN, "select * from dbo.TTNhanVienCoBan");
        }

        private void dgvTTCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTTCN.CurrentRow.Index;
            cbbMaNV.Text = dgvTTCN.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvTTCN.Rows[i].Cells[1].Value.ToString();
            txtHoNV.Text = dgvTTCN.Rows[i].Cells[2].Value.ToString();
            cbbGTinh.Text = dgvTTCN.Rows[i].Cells[3].Value.ToString();
            dtpNS.Text = dgvTTCN.Rows[i].Cells[4].Value.ToString();
            txtQuocTich.Text = dgvTTCN.Rows[i].Cells[5].Value.ToString();
            txtNguyenQuan.Text = dgvTTCN.Rows[i].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvTTCN.Rows[i].Cells[7].Value.ToString();
            txtEmail.Text = dgvTTCN.Rows[i].Cells[8].Value.ToString();
            txtNgoaiNgu.Text = dgvTTCN.Rows[i].Cells[9].Value.ToString();
            txtHocVan.Text = dgvTTCN.Rows[i].Cells[10].Value.ToString();
            txtGhiChu.Text = dgvTTCN.Rows[i].Cells[11].Value.ToString();
        }
    }
}
