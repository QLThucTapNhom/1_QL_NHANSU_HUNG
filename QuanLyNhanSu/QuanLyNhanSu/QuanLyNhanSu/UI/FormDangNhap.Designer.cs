namespace QuanLyNhanSu
{
    partial class FormDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonHoanTat = new System.Windows.Forms.Button();
            this.buttonNhapLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxPassword.Location = new System.Drawing.Point(111, 87);
            this.textBoxPassword.MaxLength = 8;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(192, 25);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxUsername.Location = new System.Drawing.Point(111, 46);
            this.textBoxUsername.MaxLength = 8;
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(192, 25);
            this.textBoxUsername.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThoat);
            this.groupBox2.Controls.Add(this.buttonHoanTat);
            this.groupBox2.Controls.Add(this.buttonNhapLai);
            this.groupBox2.Location = new System.Drawing.Point(30, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThoat.Image = global::QuanLyNhanSu.Properties.Resources.close1;
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(227, 19);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(81, 33);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // buttonHoanTat
            // 
            this.buttonHoanTat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonHoanTat.Image = global::QuanLyNhanSu.Properties.Resources.add_user;
            this.buttonHoanTat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoanTat.Location = new System.Drawing.Point(111, 19);
            this.buttonHoanTat.Name = "buttonHoanTat";
            this.buttonHoanTat.Size = new System.Drawing.Size(91, 33);
            this.buttonHoanTat.TabIndex = 1;
            this.buttonHoanTat.Text = "Đăng Nhập";
            this.buttonHoanTat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHoanTat.UseVisualStyleBackColor = true;
            // 
            // buttonNhapLai
            // 
            this.buttonNhapLai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNhapLai.Image = global::QuanLyNhanSu.Properties.Resources.edit_user;
            this.buttonNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhapLai.Location = new System.Drawing.Point(6, 19);
            this.buttonNhapLai.Name = "buttonNhapLai";
            this.buttonNhapLai.Size = new System.Drawing.Size(85, 33);
            this.buttonNhapLai.TabIndex = 0;
            this.buttonNhapLai.Text = "Nhập Lại";
            this.buttonNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNhapLai.UseVisualStyleBackColor = true;
            this.buttonNhapLai.Click += new System.EventHandler(this.buttonNhapLai_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(400, 362);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN IN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonHoanTat;
        private System.Windows.Forms.Button buttonNhapLai;
    }
}