namespace Project_QuanLyThuVien
{
    partial class Main_QLThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_QLThuVien));
            this.lbl_qlthuvien = new System.Windows.Forms.Label();
            this.menuStrip_qlthuvien = new System.Windows.Forms.MenuStrip();
            this.QL_MuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.QLMS = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTS = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_DanhMục = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_Ssách = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_ThôngTinSinhViên = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSinhViênMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_nguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip_qlthuvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_qlthuvien
            // 
            this.lbl_qlthuvien.AutoSize = true;
            this.lbl_qlthuvien.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qlthuvien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_qlthuvien.Location = new System.Drawing.Point(373, 9);
            this.lbl_qlthuvien.Name = "lbl_qlthuvien";
            this.lbl_qlthuvien.Size = new System.Drawing.Size(408, 55);
            this.lbl_qlthuvien.TabIndex = 0;
            this.lbl_qlthuvien.Text = "Quản Lý Thư Viện";
            // 
            // menuStrip_qlthuvien
            // 
            this.menuStrip_qlthuvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip_qlthuvien.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_qlthuvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QL_MuonSach,
            this.QL_DanhMục,
            this.QL_Ssách,
            this.QL_ThôngTinSinhViên,
            this.toolStripMenuItem1,
            this.QL_nguoidung});
            this.menuStrip_qlthuvien.Location = new System.Drawing.Point(9, 84);
            this.menuStrip_qlthuvien.Name = "menuStrip_qlthuvien";
            this.menuStrip_qlthuvien.Size = new System.Drawing.Size(1113, 30);
            this.menuStrip_qlthuvien.TabIndex = 1;
            this.menuStrip_qlthuvien.Text = "menuStrip1";
            // 
            // QL_MuonSach
            // 
            this.QL_MuonSach.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.QL_MuonSach.AutoToolTip = true;
            this.QL_MuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.QL_MuonSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLMS,
            this.QLTS});
            this.QL_MuonSach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QL_MuonSach.Name = "QL_MuonSach";
            this.QL_MuonSach.Size = new System.Drawing.Size(219, 26);
            this.QL_MuonSach.Text = "Quản lý Mượn-Trả sách";
            // 
            // QLMS
            // 
            this.QLMS.Name = "QLMS";
            this.QLMS.Size = new System.Drawing.Size(241, 26);
            this.QLMS.Text = "Quản lý Mượn sách";
            this.QLMS.Click += new System.EventHandler(this.QLMSToolStripMenuItem_Click);
            // 
            // QLTS
            // 
            this.QLTS.Name = "QLTS";
            this.QLTS.Size = new System.Drawing.Size(241, 26);
            this.QLTS.Text = "Quản lý Trả sách";
            this.QLTS.Click += new System.EventHandler(this.QLTSToolStripMenuItem_Click);
            // 
            // QL_DanhMục
            // 
            this.QL_DanhMục.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.QL_DanhMục.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QL_DanhMục.Name = "QL_DanhMục";
            this.QL_DanhMục.Size = new System.Drawing.Size(184, 26);
            this.QL_DanhMục.Text = "Quản Lý Danh Mục";
            this.QL_DanhMục.Click += new System.EventHandler(this.QL_DanhMục_Click);
            // 
            // QL_Ssách
            // 
            this.QL_Ssách.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.QL_Ssách.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QL_Ssách.Name = "QL_Ssách";
            this.QL_Ssách.Size = new System.Drawing.Size(138, 26);
            this.QL_Ssách.Text = "Quản Lý Sách";
            this.QL_Ssách.Click += new System.EventHandler(this.QL_Ssách_Click);
            // 
            // QL_ThôngTinSinhViên
            // 
            this.QL_ThôngTinSinhViên.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.QL_ThôngTinSinhViên.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QL_ThôngTinSinhViên.Name = "QL_ThôngTinSinhViên";
            this.QL_ThôngTinSinhViên.Size = new System.Drawing.Size(266, 26);
            this.QL_ThôngTinSinhViên.Text = "Quản Lý Thông Tin Sinh Viên";
            this.QL_ThôngTinSinhViên.Click += new System.EventHandler(this.QL_ThôngTinSinhViên_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSáchToolStripMenuItem,
            this.thốngKêSinhViênMượnToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem1.Text = "Thống kê";
            // 
            // thốngKêSáchToolStripMenuItem
            // 
            this.thốngKêSáchToolStripMenuItem.Name = "thốngKêSáchToolStripMenuItem";
            this.thốngKêSáchToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.thốngKêSáchToolStripMenuItem.Text = "Thống kê sách";
            this.thốngKêSáchToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSáchToolStripMenuItem_Click);
            // 
            // thốngKêSinhViênMượnToolStripMenuItem
            // 
            this.thốngKêSinhViênMượnToolStripMenuItem.Name = "thốngKêSinhViênMượnToolStripMenuItem";
            this.thốngKêSinhViênMượnToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.thốngKêSinhViênMượnToolStripMenuItem.Text = "Thống kê sinh viên mượn";
            this.thốngKêSinhViênMượnToolStripMenuItem.Click += new System.EventHandler(this.thốngKêSinhViênMượnToolStripMenuItem_Click);
            // 
            // QL_nguoidung
            // 
            this.QL_nguoidung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QL_nguoidung.Name = "QL_nguoidung";
            this.QL_nguoidung.Size = new System.Drawing.Size(198, 26);
            this.QL_nguoidung.Text = "Quản Lý Người Dùng";
            this.QL_nguoidung.Click += new System.EventHandler(this.QL_nguoidung_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Red;
            this.btn_logout.Location = new System.Drawing.Point(669, 635);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(89, 34);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "&Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(798, 635);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 34);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1009, 503);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, -26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(358, 107);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(778, -26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 107);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Main_QLThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_qlthuvien);
            this.Controls.Add(this.menuStrip_qlthuvien);
            this.Name = "Main_QLThuVien";
            this.Text = "Main_QLThuVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_QLThuVien_FormClosing);
            this.Load += new System.EventHandler(this.Main_QLThuVien_Load);
            this.menuStrip_qlthuvien.ResumeLayout(false);
            this.menuStrip_qlthuvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_qlthuvien;
        private System.Windows.Forms.MenuStrip menuStrip_qlthuvien;
        private System.Windows.Forms.ToolStripMenuItem QL_DanhMục;
        private System.Windows.Forms.ToolStripMenuItem QL_Ssách;
        private System.Windows.Forms.ToolStripMenuItem QL_ThôngTinSinhViên;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ToolStripMenuItem QL_MuonSach;
        private System.Windows.Forms.ToolStripMenuItem QL_nguoidung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem QLMS;
        private System.Windows.Forms.ToolStripMenuItem QLTS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSinhViênMượnToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}