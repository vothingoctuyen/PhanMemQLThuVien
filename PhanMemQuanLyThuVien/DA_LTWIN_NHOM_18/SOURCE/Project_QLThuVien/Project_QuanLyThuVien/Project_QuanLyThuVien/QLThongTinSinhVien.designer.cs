namespace Project_QuanLyThuVien
{
    partial class frm_QLThongTinSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLThongTinSinhVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gr_thongtin = new System.Windows.Forms.GroupBox();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.cbo_mssv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.msk_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.gr_gt = new System.Windows.Forms.GroupBox();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.cbo_khoa = new System.Windows.Forms.ComboBox();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gr_timkiem = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new DevComponents.DotNetBar.ButtonX();
            this.cbo_timkiemsv = new System.Windows.Forms.ComboBox();
            this.gr_ds = new System.Windows.Forms.GroupBox();
            this.dgv_thongtinsinhvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_thongtin.SuspendLayout();
            this.gr_gt.SuspendLayout();
            this.gr_timkiem.SuspendLayout();
            this.gr_ds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(61, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gr_thongtin
            // 
            this.gr_thongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gr_thongtin.Controls.Add(this.lbl_malop);
            this.gr_thongtin.Controls.Add(this.txt_malop);
            this.gr_thongtin.Controls.Add(this.cbo_mssv);
            this.gr_thongtin.Controls.Add(this.msk_ngaysinh);
            this.gr_thongtin.Controls.Add(this.btn_thoat);
            this.gr_thongtin.Controls.Add(this.btn_sua);
            this.gr_thongtin.Controls.Add(this.btn_xoa);
            this.gr_thongtin.Controls.Add(this.btn_them);
            this.gr_thongtin.Controls.Add(this.gr_gt);
            this.gr_thongtin.Controls.Add(this.cbo_khoa);
            this.gr_thongtin.Controls.Add(this.cbo_lop);
            this.gr_thongtin.Controls.Add(this.txt_ten);
            this.gr_thongtin.Controls.Add(this.label7);
            this.gr_thongtin.Controls.Add(this.label5);
            this.gr_thongtin.Controls.Add(this.label4);
            this.gr_thongtin.Controls.Add(this.label3);
            this.gr_thongtin.Controls.Add(this.label2);
            this.gr_thongtin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_thongtin.Location = new System.Drawing.Point(12, 47);
            this.gr_thongtin.Name = "gr_thongtin";
            this.gr_thongtin.Size = new System.Drawing.Size(753, 208);
            this.gr_thongtin.TabIndex = 1;
            this.gr_thongtin.TabStop = false;
            this.gr_thongtin.Text = "Thông tin";
            // 
            // lbl_malop
            // 
            this.lbl_malop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_malop.Location = new System.Drawing.Point(15, 164);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(66, 30);
            this.lbl_malop.TabIndex = 36;
            this.lbl_malop.Text = "Mã lớp";
            // 
            // txt_malop
            // 
            this.txt_malop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(92, 161);
            this.txt_malop.Multiline = true;
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(196, 31);
            this.txt_malop.TabIndex = 37;
            // 
            // cbo_mssv
            // 
            this.cbo_mssv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_mssv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_mssv.DisplayMember = "Text";
            this.cbo_mssv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_mssv.FormattingEnabled = true;
            this.cbo_mssv.ItemHeight = 23;
            this.cbo_mssv.Location = new System.Drawing.Point(92, 25);
            this.cbo_mssv.Name = "cbo_mssv";
            this.cbo_mssv.Size = new System.Drawing.Size(196, 29);
            this.cbo_mssv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_mssv.TabIndex = 0;
            // 
            // msk_ngaysinh
            // 
            this.msk_ngaysinh.Location = new System.Drawing.Point(407, 65);
            this.msk_ngaysinh.Mask = "00/00/0000";
            this.msk_ngaysinh.Name = "msk_ngaysinh";
            this.msk_ngaysinh.Size = new System.Drawing.Size(196, 29);
            this.msk_ngaysinh.TabIndex = 35;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_thoat.Location = new System.Drawing.Point(624, 161);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 41);
            this.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thoat.TabIndex = 31;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextColor = System.Drawing.Color.Red;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_sua.Location = new System.Drawing.Point(624, 113);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 41);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = " Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Red;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_xoa.Location = new System.Drawing.Point(624, 65);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 41);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = " Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Red;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_them.Location = new System.Drawing.Point(624, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(104, 41);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 28;
            this.btn_them.Text = " Thêm ";
            this.btn_them.TextColor = System.Drawing.Color.Red;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gr_gt
            // 
            this.gr_gt.Controls.Add(this.rbtn_nu);
            this.gr_gt.Controls.Add(this.rbtn_nam);
            this.gr_gt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_gt.Location = new System.Drawing.Point(353, 113);
            this.gr_gt.Name = "gr_gt";
            this.gr_gt.Size = new System.Drawing.Size(250, 62);
            this.gr_gt.TabIndex = 11;
            this.gr_gt.TabStop = false;
            this.gr_gt.Text = "Giới tính ";
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nu.Location = new System.Drawing.Point(157, 31);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(51, 25);
            this.rbtn_nu.TabIndex = 1;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.Checked = true;
            this.rbtn_nam.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_nam.Location = new System.Drawing.Point(54, 29);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(63, 25);
            this.rbtn_nam.TabIndex = 0;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // cbo_khoa
            // 
            this.cbo_khoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_khoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_khoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_khoa.FormattingEnabled = true;
            this.cbo_khoa.Location = new System.Drawing.Point(92, 65);
            this.cbo_khoa.Name = "cbo_khoa";
            this.cbo_khoa.Size = new System.Drawing.Size(196, 29);
            this.cbo_khoa.TabIndex = 10;
            this.cbo_khoa.SelectedIndexChanged += new System.EventHandler(this.cbo_khoa_SelectedIndexChanged);
            // 
            // cbo_lop
            // 
            this.cbo_lop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Location = new System.Drawing.Point(92, 113);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(196, 29);
            this.cbo_lop.TabIndex = 9;
            this.cbo_lop.SelectedIndexChanged += new System.EventHandler(this.cbo_lop_SelectedIndexChanged);
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(407, 25);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(196, 31);
            this.txt_ten.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(15, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(302, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(296, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // gr_timkiem
            // 
            this.gr_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gr_timkiem.Controls.Add(this.btn_timkiem);
            this.gr_timkiem.Controls.Add(this.cbo_timkiemsv);
            this.gr_timkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_timkiem.Location = new System.Drawing.Point(12, 261);
            this.gr_timkiem.Name = "gr_timkiem";
            this.gr_timkiem.Size = new System.Drawing.Size(753, 73);
            this.gr_timkiem.TabIndex = 2;
            this.gr_timkiem.TabStop = false;
            this.gr_timkiem.Text = "Tìm kiếm ";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_timkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_timkiem.Location = new System.Drawing.Point(489, 23);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(136, 34);
            this.btn_timkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_timkiem.TabIndex = 38;
            this.btn_timkiem.Text = "Tìm kiếm ";
            this.btn_timkiem.TextColor = System.Drawing.Color.Red;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // cbo_timkiemsv
            // 
            this.cbo_timkiemsv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_timkiemsv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_timkiemsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbo_timkiemsv.FormattingEnabled = true;
            this.cbo_timkiemsv.Location = new System.Drawing.Point(102, 28);
            this.cbo_timkiemsv.Name = "cbo_timkiemsv";
            this.cbo_timkiemsv.Size = new System.Drawing.Size(364, 29);
            this.cbo_timkiemsv.TabIndex = 37;
            // 
            // gr_ds
            // 
            this.gr_ds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gr_ds.Controls.Add(this.dgv_thongtinsinhvien);
            this.gr_ds.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_ds.Location = new System.Drawing.Point(12, 340);
            this.gr_ds.Name = "gr_ds";
            this.gr_ds.Size = new System.Drawing.Size(753, 315);
            this.gr_ds.TabIndex = 3;
            this.gr_ds.TabStop = false;
            this.gr_ds.Text = "Danh sách";
            // 
            // dgv_thongtinsinhvien
            // 
            this.dgv_thongtinsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTenSinhVien,
            this.MaLop,
            this.Tenlop,
            this.Khoa,
            this.NgaySinh,
            this.GioiTinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thongtinsinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_thongtinsinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_thongtinsinhvien.Location = new System.Drawing.Point(27, 31);
            this.dgv_thongtinsinhvien.Name = "dgv_thongtinsinhvien";
            this.dgv_thongtinsinhvien.Size = new System.Drawing.Size(701, 258);
            this.dgv_thongtinsinhvien.TabIndex = 0;
            this.dgv_thongtinsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtinsinhvien_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã Số SV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTenSinhVien
            // 
            this.HoTenSinhVien.DataPropertyName = "HoTenSinhVien";
            this.HoTenSinhVien.HeaderText = "Họ Tên Sinh Viên";
            this.HoTenSinhVien.Name = "HoTenSinhVien";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "Tên Lớp";
            this.Tenlop.Name = "Tenlop";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // frm_QLThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(777, 667);
            this.Controls.Add(this.gr_ds);
            this.Controls.Add(this.gr_timkiem);
            this.Controls.Add(this.gr_thongtin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLThongTinSinhVien";
            this.Text = "Quản lý Thông Tin Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLThongTinSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLThongTinSinhVien_Load);
            this.gr_thongtin.ResumeLayout(false);
            this.gr_thongtin.PerformLayout();
            this.gr_gt.ResumeLayout(false);
            this.gr_gt.PerformLayout();
            this.gr_timkiem.ResumeLayout(false);
            this.gr_ds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinsinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr_thongtin;
        private System.Windows.Forms.GroupBox gr_gt;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.RadioButton rbtn_nam;
        private System.Windows.Forms.ComboBox cbo_khoa;
        private System.Windows.Forms.ComboBox cbo_lop;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gr_timkiem;
        private System.Windows.Forms.GroupBox gr_ds;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_thongtinsinhvien;
        private System.Windows.Forms.MaskedTextBox msk_ngaysinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_mssv;
        private System.Windows.Forms.ComboBox cbo_timkiemsv;
        private DevComponents.DotNetBar.ButtonX btn_timkiem;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label lbl_malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}