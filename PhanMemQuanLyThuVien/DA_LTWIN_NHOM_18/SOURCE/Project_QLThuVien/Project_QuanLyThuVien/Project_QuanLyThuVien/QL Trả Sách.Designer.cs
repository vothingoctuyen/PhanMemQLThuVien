namespace Project_QuanLyThuVien
{
    partial class frm_QL_TraSach
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
            this.gr_tra = new System.Windows.Forms.GroupBox();
            this.cbo_masach = new System.Windows.Forms.ComboBox();
            this.cbo_mssv = new System.Windows.Forms.ComboBox();
            this.btn_tra = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_tra = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MASOSINHVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_MUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHENTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gr_tra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_tra
            // 
            this.gr_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gr_tra.Controls.Add(this.cbo_masach);
            this.gr_tra.Controls.Add(this.cbo_mssv);
            this.gr_tra.Controls.Add(this.btn_tra);
            this.gr_tra.Controls.Add(this.btn_thoat);
            this.gr_tra.Controls.Add(this.label7);
            this.gr_tra.Controls.Add(this.label5);
            this.gr_tra.Location = new System.Drawing.Point(30, 12);
            this.gr_tra.Name = "gr_tra";
            this.gr_tra.Size = new System.Drawing.Size(749, 152);
            this.gr_tra.TabIndex = 1;
            this.gr_tra.TabStop = false;
            this.gr_tra.Text = "Thực hiện trả";
            // 
            // cbo_masach
            // 
            this.cbo_masach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_masach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_masach.FormattingEnabled = true;
            this.cbo_masach.Location = new System.Drawing.Point(184, 82);
            this.cbo_masach.Name = "cbo_masach";
            this.cbo_masach.Size = new System.Drawing.Size(241, 27);
            this.cbo_masach.TabIndex = 16;
            this.cbo_masach.Leave += new System.EventHandler(this.cbo_masach_Leave);
            // 
            // cbo_mssv
            // 
            this.cbo_mssv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_mssv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_mssv.FormattingEnabled = true;
            this.cbo_mssv.Location = new System.Drawing.Point(184, 39);
            this.cbo_mssv.Name = "cbo_mssv";
            this.cbo_mssv.Size = new System.Drawing.Size(241, 27);
            this.cbo_mssv.TabIndex = 16;
            this.cbo_mssv.Leave += new System.EventHandler(this.cbo_mssv_Leave);
            // 
            // btn_tra
            // 
            this.btn_tra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_tra.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tra.ForeColor = System.Drawing.Color.Red;
            this.btn_tra.Location = new System.Drawing.Point(478, 29);
            this.btn_tra.Name = "btn_tra";
            this.btn_tra.Size = new System.Drawing.Size(165, 46);
            this.btn_tra.TabIndex = 15;
            this.btn_tra.Text = "Trả sách";
            this.btn_tra.UseVisualStyleBackColor = false;
            this.btn_tra.Click += new System.EventHandler(this.btn_tra_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_thoat.Location = new System.Drawing.Point(478, 82);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(165, 46);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(28, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Số Sinh Viên ";
            // 
            // dgv_tra
            // 
            this.dgv_tra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_tra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASOSINHVIEN,
            this.MS,
            this.SOLUONGTRA,
            this.NGAY_MUON,
            this.NGAYTRA,
            this.NGAYHENTRA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_tra.Location = new System.Drawing.Point(30, 170);
            this.dgv_tra.Name = "dgv_tra";
            this.dgv_tra.Size = new System.Drawing.Size(749, 383);
            this.dgv_tra.TabIndex = 33;
            // 
            // MASOSINHVIEN
            // 
            this.MASOSINHVIEN.DataPropertyName = "MASOSINHVIEN";
            this.MASOSINHVIEN.HeaderText = "MSSV";
            this.MASOSINHVIEN.Name = "MASOSINHVIEN";
            // 
            // MS
            // 
            this.MS.DataPropertyName = "MS";
            this.MS.HeaderText = "Mã sách";
            this.MS.Name = "MS";
            // 
            // SOLUONGTRA
            // 
            this.SOLUONGTRA.DataPropertyName = "SOLUONGTRA";
            this.SOLUONGTRA.HeaderText = "Số lượng trả";
            this.SOLUONGTRA.Name = "SOLUONGTRA";
            // 
            // NGAY_MUON
            // 
            this.NGAY_MUON.DataPropertyName = "NGAY_MUON";
            this.NGAY_MUON.HeaderText = "Ngày mượn";
            this.NGAY_MUON.Name = "NGAY_MUON";
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.DataPropertyName = "NGAYTRA";
            this.NGAYTRA.HeaderText = "Ngày trả";
            this.NGAYTRA.Name = "NGAYTRA";
            // 
            // NGAYHENTRA
            // 
            this.NGAYHENTRA.DataPropertyName = "NGAYHENTRA";
            this.NGAYHENTRA.HeaderText = "Ngày hẹn trả";
            this.NGAYHENTRA.Name = "NGAYHENTRA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_QL_TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(819, 576);
            this.Controls.Add(this.dgv_tra);
            this.Controls.Add(this.gr_tra);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QL_TraSach";
            this.Text = "QL_TraSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QL_TraSach_FormClosing);
            this.Load += new System.EventHandler(this.frm_QL_TraSach_Load);
            this.gr_tra.ResumeLayout(false);
            this.gr_tra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_tra;
        private System.Windows.Forms.Button btn_tra;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASOSINHVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_MUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHENTRA;
        private System.Windows.Forms.ComboBox cbo_masach;
        private System.Windows.Forms.ComboBox cbo_mssv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}