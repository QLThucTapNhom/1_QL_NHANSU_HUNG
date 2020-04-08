namespace QuanLyNhanSu
{
    partial class FormBacLuong
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
            this.comboBoxHSPhuCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHSLuong = new System.Windows.Forms.TextBox();
            this.textBoxLuongCB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBacLuong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxHSPhuCap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxHSLuong);
            this.groupBox1.Controls.Add(this.textBoxLuongCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBacLuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bậc Lương";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // comboBoxHSPhuCap
            // 
            this.comboBoxHSPhuCap.FormattingEnabled = true;
            this.comboBoxHSPhuCap.Location = new System.Drawing.Point(273, 119);
            this.comboBoxHSPhuCap.Name = "comboBoxHSPhuCap";
            this.comboBoxHSPhuCap.Size = new System.Drawing.Size(249, 23);
            this.comboBoxHSPhuCap.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hệ số phụ cấp";
            // 
            // textBoxHSLuong
            // 
            this.textBoxHSLuong.Location = new System.Drawing.Point(273, 86);
            this.textBoxHSLuong.Multiline = true;
            this.textBoxHSLuong.Name = "textBoxHSLuong";
            this.textBoxHSLuong.Size = new System.Drawing.Size(249, 23);
            this.textBoxHSLuong.TabIndex = 15;
            // 
            // textBoxLuongCB
            // 
            this.textBoxLuongCB.Location = new System.Drawing.Point(273, 53);
            this.textBoxLuongCB.Multiline = true;
            this.textBoxLuongCB.Name = "textBoxLuongCB";
            this.textBoxLuongCB.Size = new System.Drawing.Size(249, 23);
            this.textBoxLuongCB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hệ số lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lương cơ bản";
            // 
            // comboBoxBacLuong
            // 
            this.comboBoxBacLuong.FormattingEnabled = true;
            this.comboBoxBacLuong.Location = new System.Drawing.Point(273, 19);
            this.comboBoxBacLuong.Name = "comboBoxBacLuong";
            this.comboBoxBacLuong.Size = new System.Drawing.Size(249, 23);
            this.comboBoxBacLuong.TabIndex = 4;
            this.comboBoxBacLuong.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBacLuong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bậc Lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 123);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNew.Image = global::QuanLyNhanSu.Properties.Resources.button5_Image;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(114, 19);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(70, 35);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Mới";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonExit.Image = global::QuanLyNhanSu.Properties.Resources.close1;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(540, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(70, 35);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.Image = global::QuanLyNhanSu.Properties.Resources.remove_user;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(435, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 35);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdate.Image = global::QuanLyNhanSu.Properties.Resources.edit_user;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(329, 19);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(70, 35);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.Image = global::QuanLyNhanSu.Properties.Resources.add_user;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(216, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 35);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormBacLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(777, 440);
            this.Name = "FormBacLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bac Luong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxHSPhuCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHSLuong;
        private System.Windows.Forms.TextBox textBoxLuongCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBacLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}