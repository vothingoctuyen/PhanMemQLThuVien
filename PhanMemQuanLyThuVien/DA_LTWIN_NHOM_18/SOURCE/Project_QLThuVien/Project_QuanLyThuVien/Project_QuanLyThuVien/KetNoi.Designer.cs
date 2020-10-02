namespace Project_QuanLyThuVien
{
    partial class frm_KetNoi
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
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_catalog = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btn_ketnoi = new System.Windows.Forms.Button();
            this.txt_catalog = new System.Windows.Forms.TextBox();
            this.txtx_ID = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(12, 9);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(193, 19);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "Vui lòng nhập thông tin sau:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(12, 52);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(85, 19);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "Data Source";
            // 
            // lbl_catalog
            // 
            this.lbl_catalog.AutoSize = true;
            this.lbl_catalog.Location = new System.Drawing.Point(12, 102);
            this.lbl_catalog.Name = "lbl_catalog";
            this.lbl_catalog.Size = new System.Drawing.Size(92, 19);
            this.lbl_catalog.TabIndex = 2;
            this.lbl_catalog.Text = "Initial Catalog";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 157);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(58, 19);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "User ID";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 210);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(69, 19);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(142, 45);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(220, 26);
            this.txt_data.TabIndex = 5;
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ketnoi.Location = new System.Drawing.Point(74, 256);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(83, 34);
            this.btn_ketnoi.TabIndex = 6;
            this.btn_ketnoi.Text = "&Kết nối";
            this.btn_ketnoi.UseVisualStyleBackColor = true;
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // txt_catalog
            // 
            this.txt_catalog.Location = new System.Drawing.Point(142, 99);
            this.txt_catalog.Name = "txt_catalog";
            this.txt_catalog.Size = new System.Drawing.Size(220, 26);
            this.txt_catalog.TabIndex = 7;
            // 
            // txtx_ID
            // 
            this.txtx_ID.Location = new System.Drawing.Point(142, 154);
            this.txtx_ID.Name = "txtx_ID";
            this.txtx_ID.Size = new System.Drawing.Size(220, 26);
            this.txtx_ID.TabIndex = 8;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(142, 207);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(220, 26);
            this.txt_pass.TabIndex = 9;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(240, 256);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(83, 34);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "&Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_KetNoi
            // 
            this.AcceptButton = this.btn_ketnoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 307);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txtx_ID);
            this.Controls.Add(this.txt_catalog);
            this.Controls.Add(this.btn_ketnoi);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_catalog);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_tieude);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_KetNoi";
            this.Text = "Kết Nối";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_KetNoi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_catalog;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_ketnoi;
        private System.Windows.Forms.TextBox txt_catalog;
        private System.Windows.Forms.TextBox txtx_ID;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_thoat;
    }
}