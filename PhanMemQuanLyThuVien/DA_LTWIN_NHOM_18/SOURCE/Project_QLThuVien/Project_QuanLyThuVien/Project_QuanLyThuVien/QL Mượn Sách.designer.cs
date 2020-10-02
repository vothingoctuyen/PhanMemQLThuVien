namespace Project_QuanLyThuVien
{
    partial class frm_QL_MuonSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gr_muon = new System.Windows.Forms.GroupBox();
            this.cbo_mssv = new System.Windows.Forms.ComboBox();
            this.cbo_masach = new System.Windows.Forms.ComboBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.msk_ngaygiahan = new System.Windows.Forms.MaskedTextBox();
            this.msk_ngaymuon = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_muonthem = new System.Windows.Forms.Button();
            this.btn_muonmoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_muon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gr_muon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_muon
            // 
            this.gr_muon.AutoSize = true;
            this.gr_muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gr_muon.Controls.Add(this.cbo_mssv);
            this.gr_muon.Controls.Add(this.cbo_masach);
            this.gr_muon.Controls.Add(this.txt_sl);
            this.gr_muon.Controls.Add(this.msk_ngaygiahan);
            this.gr_muon.Controls.Add(this.msk_ngaymuon);
            this.gr_muon.Controls.Add(this.label11);
            this.gr_muon.Controls.Add(this.btn_thoat);
            this.gr_muon.Controls.Add(this.btn_muonthem);
            this.gr_muon.Controls.Add(this.btn_muonmoi);
            this.gr_muon.Controls.Add(this.label4);
            this.gr_muon.Controls.Add(this.label3);
            this.gr_muon.Controls.Add(this.label2);
            this.gr_muon.Controls.Add(this.label1);
            this.gr_muon.ForeColor = System.Drawing.Color.Black;
            this.gr_muon.Location = new System.Drawing.Point(41, 12);
            this.gr_muon.Name = "gr_muon";
            this.gr_muon.Size = new System.Drawing.Size(685, 320);
            this.gr_muon.TabIndex = 2;
            this.gr_muon.TabStop = false;
            this.gr_muon.Text = "Thực hiện cho mượn";
            // 
            // cbo_mssv
            // 
            this.cbo_mssv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_mssv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_mssv.FormattingEnabled = true;
            this.cbo_mssv.Location = new System.Drawing.Point(198, 80);
            this.cbo_mssv.Name = "cbo_mssv";
            this.cbo_mssv.Size = new System.Drawing.Size(296, 27);
            this.cbo_mssv.TabIndex = 36;
            this.cbo_mssv.Leave += new System.EventHandler(this.cbo_mssv_Leave);
            // 
            // cbo_masach
            // 
            this.cbo_masach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_masach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_masach.BackColor = System.Drawing.Color.White;
            this.cbo_masach.FormattingEnabled = true;
            this.cbo_masach.Location = new System.Drawing.Point(198, 40);
            this.cbo_masach.Name = "cbo_masach";
            this.cbo_masach.Size = new System.Drawing.Size(296, 27);
            this.cbo_masach.TabIndex = 36;
            this.cbo_masach.Leave += new System.EventHandler(this.cbo_masach_Leave);
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(198, 234);
            this.txt_sl.Multiline = true;
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(296, 32);
            this.txt_sl.TabIndex = 35;
            // 
            // msk_ngaygiahan
            // 
            this.msk_ngaygiahan.Location = new System.Drawing.Point(198, 189);
            this.msk_ngaygiahan.Mask = "00/00/0000";
            this.msk_ngaygiahan.Name = "msk_ngaygiahan";
            this.msk_ngaygiahan.Size = new System.Drawing.Size(296, 26);
            this.msk_ngaygiahan.TabIndex = 34;
            // 
            // msk_ngaymuon
            // 
            this.msk_ngaymuon.Location = new System.Drawing.Point(198, 135);
            this.msk_ngaymuon.Mask = "00/00/0000";
            this.msk_ngaymuon.Name = "msk_ngaymuon";
            this.msk_ngaymuon.Size = new System.Drawing.Size(296, 26);
            this.msk_ngaymuon.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(34, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Mã Sách";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_thoat.Location = new System.Drawing.Point(540, 178);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 46);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_muonthem
            // 
            this.btn_muonthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_muonthem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muonthem.ForeColor = System.Drawing.Color.Red;
            this.btn_muonthem.Location = new System.Drawing.Point(540, 103);
            this.btn_muonthem.Name = "btn_muonthem";
            this.btn_muonthem.Size = new System.Drawing.Size(111, 46);
            this.btn_muonthem.TabIndex = 9;
            this.btn_muonthem.Text = "Mượn thêm";
            this.btn_muonthem.UseVisualStyleBackColor = false;
            this.btn_muonthem.Click += new System.EventHandler(this.btn_muonthem_Click);
            // 
            // btn_muonmoi
            // 
            this.btn_muonmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_muonmoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muonmoi.ForeColor = System.Drawing.Color.Red;
            this.btn_muonmoi.Location = new System.Drawing.Point(540, 31);
            this.btn_muonmoi.Name = "btn_muonmoi";
            this.btn_muonmoi.Size = new System.Drawing.Size(111, 46);
            this.btn_muonmoi.TabIndex = 8;
            this.btn_muonmoi.Text = "Mượn mới";
            this.btn_muonmoi.UseVisualStyleBackColor = false;
            this.btn_muonmoi.Click += new System.EventHandler(this.btn_muonmoi_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(27, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(27, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày gia hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên ";
            // 
            // dgv_muon
            // 
            this.dgv_muon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_muon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgv_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.MSSV,
            this.SoLuongMuon,
            this.NgayMuon,
            this.NgayGiaHan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_muon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_muon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_muon.Location = new System.Drawing.Point(41, 351);
            this.dgv_muon.Name = "dgv_muon";
            this.dgv_muon.Size = new System.Drawing.Size(685, 258);
            this.dgv_muon.TabIndex = 34;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // SoLuongMuon
            // 
            this.SoLuongMuon.DataPropertyName = "SoLuongMuon";
            this.SoLuongMuon.HeaderText = "Số lượng mượn";
            this.SoLuongMuon.Name = "SoLuongMuon";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // NgayGiaHan
            // 
            this.NgayGiaHan.DataPropertyName = "NgayGiaHan";
            this.NgayGiaHan.HeaderText = "Ngày Gia Hạn";
            this.NgayGiaHan.Name = "NgayGiaHan";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_QL_MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(808, 684);
            this.Controls.Add(this.dgv_muon);
            this.Controls.Add(this.gr_muon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QL_MuonSach";
            this.Text = "Quản Lý Mượn Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLMTS_Load);
            this.gr_muon.ResumeLayout(false);
            this.gr_muon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_muon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_muonthem;
        private System.Windows.Forms.Button btn_muonmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_ngaymuon;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.MaskedTextBox msk_ngaygiahan;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiaHan;
        private System.Windows.Forms.ComboBox cbo_mssv;
        private System.Windows.Forms.ComboBox cbo_masach;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}

