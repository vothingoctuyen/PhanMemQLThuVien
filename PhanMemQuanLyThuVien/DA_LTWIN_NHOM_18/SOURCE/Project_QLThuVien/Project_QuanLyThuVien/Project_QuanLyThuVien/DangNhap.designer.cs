namespace Project_QuanLyThuVien
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.picture_anh = new System.Windows.Forms.PictureBox();
            this.lbl_dangnhap = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.rad_thuthu = new System.Windows.Forms.RadioButton();
            this.rad_admin = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pB_bong = new System.Windows.Forms.PictureBox();
            this.pb_bong_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_bong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bong_2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_anh
            // 
            this.picture_anh.Image = ((System.Drawing.Image)(resources.GetObject("picture_anh.Image")));
            this.picture_anh.Location = new System.Drawing.Point(12, -6);
            this.picture_anh.Name = "picture_anh";
            this.picture_anh.Size = new System.Drawing.Size(527, 268);
            this.picture_anh.TabIndex = 5;
            this.picture_anh.TabStop = false;
            // 
            // lbl_dangnhap
            // 
            this.lbl_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dangnhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dangnhap.ForeColor = System.Drawing.Color.Red;
            this.lbl_dangnhap.Location = new System.Drawing.Point(105, 1);
            this.lbl_dangnhap.Name = "lbl_dangnhap";
            this.lbl_dangnhap.Size = new System.Drawing.Size(318, 48);
            this.lbl_dangnhap.TabIndex = 6;
            this.lbl_dangnhap.Text = "Đăng nhập vào hệ thống";
            this.lbl_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_user
            // 
            this.lb_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_user.Location = new System.Drawing.Point(110, 66);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(82, 40);
            this.lb_user.TabIndex = 7;
            this.lb_user.Text = "USER:  ";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_pass
            // 
            this.lb_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_pass.Location = new System.Drawing.Point(72, 111);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(120, 47);
            this.lb_pass.TabIndex = 8;
            this.lb_pass.Text = "PASSWORD: ";
            this.lb_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Red;
            this.btn_login.Location = new System.Drawing.Point(140, 210);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 40);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_dangky.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.ForeColor = System.Drawing.Color.Red;
            this.btn_dangky.Location = new System.Drawing.Point(342, 210);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(104, 40);
            this.btn_dangky.TabIndex = 10;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(198, 77);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(239, 29);
            this.txt_user.TabIndex = 11;
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(198, 121);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(239, 29);
            this.txt_pass.TabIndex = 12;
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // rad_thuthu
            // 
            this.rad_thuthu.Checked = true;
            this.rad_thuthu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_thuthu.ForeColor = System.Drawing.Color.Red;
            this.rad_thuthu.Location = new System.Drawing.Point(176, 171);
            this.rad_thuthu.Name = "rad_thuthu";
            this.rad_thuthu.Size = new System.Drawing.Size(107, 33);
            this.rad_thuthu.TabIndex = 13;
            this.rad_thuthu.TabStop = true;
            this.rad_thuthu.Text = "Thủ thư";
            this.rad_thuthu.UseVisualStyleBackColor = true;
            // 
            // rad_admin
            // 
            this.rad_admin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_admin.ForeColor = System.Drawing.Color.Red;
            this.rad_admin.Location = new System.Drawing.Point(289, 171);
            this.rad_admin.Name = "rad_admin";
            this.rad_admin.Size = new System.Drawing.Size(110, 33);
            this.rad_admin.TabIndex = 13;
            this.rad_admin.TabStop = true;
            this.rad_admin.Text = "Admin";
            this.rad_admin.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pB_bong
            // 
            this.pB_bong.Image = ((System.Drawing.Image)(resources.GetObject("pB_bong.Image")));
            this.pB_bong.Location = new System.Drawing.Point(1, 1);
            this.pB_bong.Name = "pB_bong";
            this.pB_bong.Size = new System.Drawing.Size(81, 261);
            this.pB_bong.TabIndex = 14;
            this.pB_bong.TabStop = false;
            // 
            // pb_bong_2
            // 
            this.pb_bong_2.Image = ((System.Drawing.Image)(resources.GetObject("pb_bong_2.Image")));
            this.pb_bong_2.Location = new System.Drawing.Point(443, 1);
            this.pb_bong_2.Name = "pb_bong_2";
            this.pb_bong_2.Size = new System.Drawing.Size(87, 261);
            this.pb_bong_2.TabIndex = 15;
            this.pb_bong_2.TabStop = false;
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.pb_bong_2);
            this.Controls.Add(this.pB_bong);
            this.Controls.Add(this.rad_admin);
            this.Controls.Add(this.rad_thuthu);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lbl_dangnhap);
            this.Controls.Add(this.picture_anh);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng nhập - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing_1);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_bong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bong_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void form_DangNhap_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox picture_anh;
        private System.Windows.Forms.Label lbl_dangnhap;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.RadioButton rad_thuthu;
        private System.Windows.Forms.RadioButton rad_admin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pB_bong;
        private System.Windows.Forms.PictureBox pb_bong_2;
    }
}