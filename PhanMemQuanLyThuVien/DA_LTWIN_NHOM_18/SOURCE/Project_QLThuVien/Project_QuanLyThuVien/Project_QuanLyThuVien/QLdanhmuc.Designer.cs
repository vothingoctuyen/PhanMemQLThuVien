namespace Project_QuanLyThuVien
{
    partial class frm_QLdanhmuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLdanhmuc));
            this.lbl_thongtinsach = new System.Windows.Forms.Label();
            this.lbl_masach = new System.Windows.Forms.Label();
            this.lbl_tensach = new System.Windows.Forms.Label();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_tg = new System.Windows.Forms.TextBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.lbl_tacgia = new System.Windows.Forms.Label();
            this.dgv_thongtinsach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msk_ngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.btn_luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_thongtinsach
            // 
            this.lbl_thongtinsach.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongtinsach.ForeColor = System.Drawing.Color.Red;
            this.lbl_thongtinsach.Location = new System.Drawing.Point(120, -1);
            this.lbl_thongtinsach.Name = "lbl_thongtinsach";
            this.lbl_thongtinsach.Size = new System.Drawing.Size(502, 53);
            this.lbl_thongtinsach.TabIndex = 0;
            this.lbl_thongtinsach.Text = "Thông Tin Sách";
            this.lbl_thongtinsach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_masach
            // 
            this.lbl_masach.AutoSize = true;
            this.lbl_masach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_masach.Location = new System.Drawing.Point(19, 67);
            this.lbl_masach.Name = "lbl_masach";
            this.lbl_masach.Size = new System.Drawing.Size(76, 21);
            this.lbl_masach.TabIndex = 1;
            this.lbl_masach.Text = "Mã sách";
            // 
            // lbl_tensach
            // 
            this.lbl_tensach.AutoSize = true;
            this.lbl_tensach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_tensach.Location = new System.Drawing.Point(19, 104);
            this.lbl_tensach.Name = "lbl_tensach";
            this.lbl_tensach.Size = new System.Drawing.Size(79, 21);
            this.lbl_tensach.TabIndex = 2;
            this.lbl_tensach.Text = "Tên sách";
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_ngaynhap.Location = new System.Drawing.Point(19, 139);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(96, 21);
            this.lbl_ngaynhap.TabIndex = 3;
            this.lbl_ngaynhap.Text = "Ngày nhập";
            // 
            // txt_masach
            // 
            this.txt_masach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masach.Location = new System.Drawing.Point(120, 64);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(212, 29);
            this.txt_masach.TabIndex = 4;
            this.txt_masach.Leave += new System.EventHandler(this.txt_masach_Leave);
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(120, 101);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(212, 29);
            this.txt_tensach.TabIndex = 5;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangthai.Location = new System.Drawing.Point(591, 142);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(213, 29);
            this.txt_trangthai.TabIndex = 12;
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(591, 104);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(213, 29);
            this.txt_sl.TabIndex = 11;
            // 
            // txt_tg
            // 
            this.txt_tg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tg.Location = new System.Drawing.Point(591, 64);
            this.txt_tg.Name = "txt_tg";
            this.txt_tg.Size = new System.Drawing.Size(213, 29);
            this.txt_tg.TabIndex = 10;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_trangthai.Location = new System.Drawing.Point(464, 145);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(92, 21);
            this.lbl_trangthai.TabIndex = 9;
            this.lbl_trangthai.Text = "Trạng thái";
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_soluong.Location = new System.Drawing.Point(464, 107);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(79, 21);
            this.lbl_soluong.TabIndex = 8;
            this.lbl_soluong.Text = "Số lượng";
            // 
            // lbl_tacgia
            // 
            this.lbl_tacgia.AutoSize = true;
            this.lbl_tacgia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tacgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_tacgia.Location = new System.Drawing.Point(478, 72);
            this.lbl_tacgia.Name = "lbl_tacgia";
            this.lbl_tacgia.Size = new System.Drawing.Size(69, 21);
            this.lbl_tacgia.TabIndex = 7;
            this.lbl_tacgia.Text = "Tác giả";
            // 
            // dgv_thongtinsach
            // 
            this.dgv_thongtinsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongtinsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtinsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Ngaynhap,
            this.Tacgia,
            this.Soluong,
            this.Trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_thongtinsach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_thongtinsach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_thongtinsach.Location = new System.Drawing.Point(12, 186);
            this.dgv_thongtinsach.Name = "dgv_thongtinsach";
            this.dgv_thongtinsach.Size = new System.Drawing.Size(792, 269);
            this.dgv_thongtinsach.TabIndex = 25;
            this.dgv_thongtinsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongtinsach_CellClick);
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "Masach";
            this.Masach.HeaderText = "Mã sách";
            this.Masach.Name = "Masach";
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "Tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.Name = "Tensach";
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "Ngaynhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.Name = "Ngaynhap";
            // 
            // Tacgia
            // 
            this.Tacgia.DataPropertyName = "Tacgia";
            this.Tacgia.HeaderText = "Tác giả";
            this.Tacgia.Name = "Tacgia";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            // 
            // msk_ngaynhap
            // 
            this.msk_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_ngaynhap.Location = new System.Drawing.Point(120, 139);
            this.msk_ngaynhap.Mask = "00/00/0000";
            this.msk_ngaynhap.Name = "msk_ngaynhap";
            this.msk_ngaynhap.Size = new System.Drawing.Size(211, 29);
            this.msk_ngaynhap.TabIndex = 35;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_thoat.Location = new System.Drawing.Point(668, 471);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(92, 41);
            this.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thoat.TabIndex = 32;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextColor = System.Drawing.Color.Red;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_luu.Location = new System.Drawing.Point(507, 471);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(96, 41);
            this.btn_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luu.TabIndex = 30;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextColor = System.Drawing.Color.Red;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_sua.Location = new System.Drawing.Point(338, 471);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 41);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 29;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Red;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_xoa.Location = new System.Drawing.Point(181, 471);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 41);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Red;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_them.Location = new System.Drawing.Point(40, 471);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 41);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm ";
            this.btn_them.TextColor = System.Drawing.Color.Red;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_QLdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(853, 524);
            this.Controls.Add(this.msk_ngaynhap);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_thongtinsach);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_tg);
            this.Controls.Add(this.lbl_trangthai);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.lbl_tacgia);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.lbl_ngaynhap);
            this.Controls.Add(this.lbl_tensach);
            this.Controls.Add(this.lbl_masach);
            this.Controls.Add(this.lbl_thongtinsach);
            this.Name = "frm_QLdanhmuc";
            this.Text = "Quản Lý Danh Mục";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLdanhmuc_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLdanhmuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtinsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_thongtinsach;
        private System.Windows.Forms.Label lbl_masach;
        private System.Windows.Forms.Label lbl_tensach;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_tg;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.Label lbl_tacgia;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_thongtinsach;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private System.Windows.Forms.MaskedTextBox msk_ngaynhap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}