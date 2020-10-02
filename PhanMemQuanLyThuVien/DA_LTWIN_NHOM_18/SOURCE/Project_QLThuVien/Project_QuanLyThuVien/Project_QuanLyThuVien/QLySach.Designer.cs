namespace Project_QuanLyThuVien
{
    partial class frm_QLSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLSach));
            this.lbl_timkiemsach = new System.Windows.Forms.Label();
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.dgv_timkiemsach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_timkiem = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiemsach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timkiemsach
            // 
            this.lbl_timkiemsach.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiemsach.ForeColor = System.Drawing.Color.Red;
            this.lbl_timkiemsach.Location = new System.Drawing.Point(53, 5);
            this.lbl_timkiemsach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_timkiemsach.Name = "lbl_timkiemsach";
            this.lbl_timkiemsach.Size = new System.Drawing.Size(726, 69);
            this.lbl_timkiemsach.TabIndex = 0;
            this.lbl_timkiemsach.Text = "Tìm Kiếm Sách";
            this.lbl_timkiemsach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_timkiem.Location = new System.Drawing.Point(769, 86);
            this.lbl_timkiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(0, 21);
            this.lbl_timkiem.TabIndex = 15;
            // 
            // dgv_timkiemsach
            // 
            this.dgv_timkiemsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_timkiemsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timkiemsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Ngaynhap,
            this.Tacgia,
            this.Soluong,
            this.Trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_timkiemsach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_timkiemsach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_timkiemsach.Location = new System.Drawing.Point(49, 139);
            this.dgv_timkiemsach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_timkiemsach.Name = "dgv_timkiemsach";
            this.dgv_timkiemsach.Size = new System.Drawing.Size(761, 303);
            this.dgv_timkiemsach.TabIndex = 33;
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
            // cbo_timkiem
            // 
            this.cbo_timkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_timkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbo_timkiem.FormattingEnabled = true;
            this.cbo_timkiem.Location = new System.Drawing.Point(156, 86);
            this.cbo_timkiem.Name = "cbo_timkiem";
            this.cbo_timkiem.Size = new System.Drawing.Size(364, 27);
            this.cbo_timkiem.TabIndex = 36;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_timkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_timkiem.Location = new System.Drawing.Point(540, 79);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(136, 34);
            this.btn_timkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_timkiem.TabIndex = 37;
            this.btn_timkiem.Text = "Tìm kiếm ";
            this.btn_timkiem.TextColor = System.Drawing.Color.Red;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // frm_QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.cbo_timkiem);
            this.Controls.Add(this.dgv_timkiemsach);
            this.Controls.Add(this.lbl_timkiem);
            this.Controls.Add(this.lbl_timkiemsach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLSach";
            this.Text = "Quản Lý Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLSach_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timkiemsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timkiemsach;
        private System.Windows.Forms.Label lbl_timkiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_timkiemsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.ComboBox cbo_timkiem;
        private DevComponents.DotNetBar.ButtonX btn_timkiem;
    }
}