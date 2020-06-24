namespace QuanLyNhanSu
{
    partial class FormPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaTruongPhong = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDCPhong = new System.Windows.Forms.TextBox();
            this.txtSDTPB = new System.Windows.Forms.TextBox();
            this.txtChucNangPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTL = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaPB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDSach = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbMaTruongPhong);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtDCPhong);
            this.groupBox1.Controls.Add(this.txtSDTPB);
            this.groupBox1.Controls.Add(this.txtChucNangPB);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgayTL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbMaPB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("UVN Ai Cap Nang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng Ban";
            // 
            // cbbMaTruongPhong
            // 
            this.cbbMaTruongPhong.FormattingEnabled = true;
            this.cbbMaTruongPhong.Location = new System.Drawing.Point(423, 85);
            this.cbbMaTruongPhong.Name = "cbbMaTruongPhong";
            this.cbbMaTruongPhong.Size = new System.Drawing.Size(206, 23);
            this.cbbMaTruongPhong.TabIndex = 33;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(423, 115);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(206, 23);
            this.txtGhiChu.TabIndex = 32;
            // 
            // txtDCPhong
            // 
            this.txtDCPhong.Location = new System.Drawing.Point(423, 55);
            this.txtDCPhong.Multiline = true;
            this.txtDCPhong.Name = "txtDCPhong";
            this.txtDCPhong.Size = new System.Drawing.Size(206, 23);
            this.txtDCPhong.TabIndex = 30;
            this.txtDCPhong.TextChanged += new System.EventHandler(this.textBoxDCPhong_TextChanged);
            // 
            // txtSDTPB
            // 
            this.txtSDTPB.Location = new System.Drawing.Point(423, 25);
            this.txtSDTPB.Multiline = true;
            this.txtSDTPB.Name = "txtSDTPB";
            this.txtSDTPB.Size = new System.Drawing.Size(206, 23);
            this.txtSDTPB.TabIndex = 29;
            // 
            // txtChucNangPB
            // 
            this.txtChucNangPB.Location = new System.Drawing.Point(80, 85);
            this.txtChucNangPB.Multiline = true;
            this.txtChucNangPB.Name = "txtChucNangPB";
            this.txtChucNangPB.Size = new System.Drawing.Size(206, 23);
            this.txtChucNangPB.TabIndex = 28;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(80, 55);
            this.txtTenPB.Multiline = true;
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(206, 23);
            this.txtTenPB.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Trưởng Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "SĐT/Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Chức Năng";
            // 
            // dtpNgayTL
            // 
            this.dtpNgayTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTL.Location = new System.Drawing.Point(80, 115);
            this.dtpNgayTL.Name = "dtpNgayTL";
            this.dtpNgayTL.Size = new System.Drawing.Size(206, 23);
            this.dtpNgayTL.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ghi Chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên PB";
            // 
            // cbbMaPB
            // 
            this.cbbMaPB.FormattingEnabled = true;
            this.cbbMaPB.Location = new System.Drawing.Point(80, 25);
            this.cbbMaPB.Name = "cbbMaPB";
            this.cbbMaPB.Size = new System.Drawing.Size(206, 23);
            this.cbbMaPB.TabIndex = 4;
            this.cbbMaPB.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaPB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PB";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(25, 177);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(655, 141);
            this.dgvPhongBan.TabIndex = 7;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDSach);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(25, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // buttonDSach
            // 
            this.buttonDSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDSach.Image = global::QuanLyNhanSu.Properties.Resources.button7_Image;
            this.buttonDSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDSach.Location = new System.Drawing.Point(505, 18);
            this.buttonDSach.Name = "buttonDSach";
            this.buttonDSach.Size = new System.Drawing.Size(70, 35);
            this.buttonDSach.TabIndex = 8;
            this.buttonDSach.Text = "DS";
            this.buttonDSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDSach.UseVisualStyleBackColor = true;
            this.buttonDSach.Click += new System.EventHandler(this.buttonDSach_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNew.Image = global::QuanLyNhanSu.Properties.Resources.button5_Image;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(65, 18);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 35);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Mới";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.Image = global::QuanLyNhanSu.Properties.Resources.remove_user;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(395, 18);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 35);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdate.Image = global::QuanLyNhanSu.Properties.Resources.edit_user;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(285, 18);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(70, 35);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Image = global::QuanLyNhanSu.Properties.Resources.add_user;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(175, 18);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 35);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(720, 440);
            this.Name = "FormPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhongBan";
            this.Load += new System.EventHandler(this.FormPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDCPhong;
        private System.Windows.Forms.TextBox txtSDTPB;
        private System.Windows.Forms.TextBox txtChucNangPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.ComboBox cbbMaTruongPhong;
        private System.Windows.Forms.Button buttonDSach;
    }
}