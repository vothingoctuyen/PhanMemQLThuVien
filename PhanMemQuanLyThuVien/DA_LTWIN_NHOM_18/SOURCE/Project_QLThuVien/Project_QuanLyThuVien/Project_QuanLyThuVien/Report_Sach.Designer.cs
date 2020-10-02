namespace Project_QuanLyThuVien
{
    partial class Report_Sach
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
            this.report_thongkesach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MyReport1 = new Project_QuanLyThuVien.CrytalReport.MyReport();
            this.SuspendLayout();
            // 
            // report_thongkesach
            // 
            this.report_thongkesach.ActiveViewIndex = 0;
            this.report_thongkesach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report_thongkesach.Cursor = System.Windows.Forms.Cursors.Default;
            this.report_thongkesach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_thongkesach.Location = new System.Drawing.Point(1, 2);
            this.report_thongkesach.Name = "report_thongkesach";
            this.report_thongkesach.ReportSource = this.MyReport1;
            this.report_thongkesach.Size = new System.Drawing.Size(1192, 724);
            this.report_thongkesach.TabIndex = 1;
            this.report_thongkesach.Load += new System.EventHandler(this.report_thongkesach_Load);
            // 
            // Report_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 726);
            this.Controls.Add(this.report_thongkesach);
            this.Name = "Report_Sach";
            this.Text = "Report_Sach";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer report_thongkesach;
        private CrytalReport.MyReport MyReport1;

    }
}