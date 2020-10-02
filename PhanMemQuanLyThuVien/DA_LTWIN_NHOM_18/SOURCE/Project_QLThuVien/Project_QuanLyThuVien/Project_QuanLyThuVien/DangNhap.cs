using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyThuVien
{
    public partial class frm_DangNhap : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        
        public frm_DangNhap()
        {
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        
        private bool kiemtrapass()
        {
            if (txt_pass.Text.Trim() == string.Empty || txt_user.Text.Trim() == string.Empty)
                return false;
            string s = "SELECT count(*) FROM [QL_Sach].[dbo].[USER] WHERE [USER] like '" + txt_user.Text.Trim() + "%'and [PASSWORD] like '" + txt_pass.Text.Trim() + "%'";
            if (rad_thuthu.Checked == true)
                s += "and [QUYEN] like 'thuthu%';";
            else
                 s += "and [QUYEN] like 'admin%'";
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            cmd = new SqlCommand(s, connsql);
            int i = (int)cmd.ExecuteScalar();           
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            if (i > 0)
                return true;
            return false;

        }  

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            lbl_dangnhap.Parent = picture_anh;
            lbl_dangnhap.BackColor = Color.Transparent;
            lb_user.Parent = picture_anh;
            lb_user.BackColor = Color.Transparent;
            lb_pass.Parent = picture_anh;
            lb_pass.BackColor = Color.Transparent;
            rad_thuthu.Parent = picture_anh;
            rad_thuthu.BackColor = Color.Transparent;
            rad_admin.Parent = picture_anh;
            rad_admin.BackColor = Color.Transparent;
            pB_bong.Parent = picture_anh;
            pB_bong.BackColor = Color.Transparent;
            pb_bong_2.Parent = picture_anh;
            pb_bong_2.BackColor = Color.Transparent;
        }
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (!kiemtrapass())
            {
                MessageBox.Show("User hoặc password không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                return;
            }
            if (rad_thuthu.Checked == true)
            {
                Main_QLThuVien main = new Main_QLThuVien("thuthu");
                main.Show();
            }
            else
            {
                Main_QLThuVien main = new Main_QLThuVien("admin");
                main.Show();
            }
            this.Hide();
         }

        private void frm_DangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_login.Enabled = false;
                txt_user.Focus();
            }
            else
                this.errorProvider1.Clear();
            btn_login.Enabled = true;
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_login.Enabled = false;
                
            }
            else
                this.errorProvider1.Clear();
                btn_login.Enabled = true;
        }
    }
}
