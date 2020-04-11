namespace QuanLyNhanSu
{
    partial class FormBangLuong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetBacLuong = new QuanLyNhanSu.DataSetBacLuong();
            this.TinhLuongNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TinhLuongNhanVienTableAdapter = new QuanLyNhanSu.DataSetBacLuongTableAdapters.TinhLuongNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBacLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhLuongNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBangLuong";
            reportDataSource1.Value = this.TinhLuongNhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhanSu.UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 10);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 379);
            this.reportViewer1.TabIndex = 11;
            // 
            // DataSetBacLuong
            // 
            this.DataSetBacLuong.DataSetName = "DataSetBacLuong";
            this.DataSetBacLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TinhLuongNhanVienBindingSource
            // 
            this.TinhLuongNhanVienBindingSource.DataMember = "TinhLuongNhanVien";
            this.TinhLuongNhanVienBindingSource.DataSource = this.DataSetBacLuong;
            // 
            // TinhLuongNhanVienTableAdapter
            // 
            this.TinhLuongNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(720, 440);
            this.Name = "FormBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bang Luong";
            this.Load += new System.EventHandler(this.FormBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBacLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhLuongNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TinhLuongNhanVienBindingSource;
        private DataSetBacLuong DataSetBacLuong;
        private DataSetBacLuongTableAdapters.TinhLuongNhanVienTableAdapter TinhLuongNhanVienTableAdapter;
    }
}