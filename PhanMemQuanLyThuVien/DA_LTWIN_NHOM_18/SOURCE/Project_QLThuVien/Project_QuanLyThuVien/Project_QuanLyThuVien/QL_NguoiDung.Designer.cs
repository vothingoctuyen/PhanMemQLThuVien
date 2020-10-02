namespace Project_QuanLyThuVien
{
    partial class QL_NguoiDung
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
            this.dgv_nguoidung = new System.Windows.Forms.DataGridView();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nguoidung
            // 
            this.dgv_nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER,
            this.PASSWORD,
            this.QUYEN});
            this.dgv_nguoidung.Location = new System.Drawing.Point(14, 14);
            this.dgv_nguoidung.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_nguoidung.Name = "dgv_nguoidung";
            this.dgv_nguoidung.Size = new System.Drawing.Size(508, 189);
            this.dgv_nguoidung.TabIndex = 0;
            // 
            // USER
            // 
            this.USER.DataPropertyName = "USER";
            this.USER.HeaderText = "User";
            this.USER.Name = "USER";
            this.USER.Width = 120;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "Password";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Width = 120;
            // 
            // QUYEN
            // 
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(430, 220);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 39);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // QL_NguoiDung
            // 
            this.AcceptButton = this.btn_xoa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 277);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.dgv_nguoidung);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QL_NguoiDung";
            this.Text = "QL_NguoiDung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_NguoiDung_FormClosing);
            this.Load += new System.EventHandler(this.QL_NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nguoidung;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
    }
}