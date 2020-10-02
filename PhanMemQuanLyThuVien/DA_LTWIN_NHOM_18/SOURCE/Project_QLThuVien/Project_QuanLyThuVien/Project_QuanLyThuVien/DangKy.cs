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
    public partial class DangKy : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        public DangKy()
        {
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == string.Empty || txt_pass.Text.Trim() == string.Empty || txt_confirmpass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được bỏ trống!!!");
                return;
            }
            else if(txt_pass.Text.Trim() != txt_confirmpass.Text.Trim())
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }
            //Ghi vào DB
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "";
            if (rad_thuthu.Checked == true)
                s = "thuthu";
            else
                s = "admin";
            try
            {
                s = "insert into [QL_Sach].[dbo].[USER] values  (N'" + txt_user.Text.Trim() + "',N'" + txt_pass.Text.Trim() + "',N'" + s + "');";
                cmd = new SqlCommand(s,connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã đăng ký thành công! \nUSER: "+txt_user.Text.Trim()+"\nPASS:"+txt_pass.Text.Trim()+"\nQuyền: "+((rad_thuthu.Checked == true)?"Thủ thư":"Admin")+"");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!");
            }
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            txt_user.Clear();
            txt_pass.Clear();
            txt_confirmpass.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_dangky.Enabled = false;
                txt_user.Focus();
            }
            else
                this.errorProvider1.Clear();
            btn_dangky.Enabled = true;
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập pass!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_dangky.Enabled = false;
                txt_pass.Focus();
            }
            else
                this.errorProvider1.Clear();
            btn_dangky.Enabled = true;
        }

        private void txt_confirmpass_Leave(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập lại password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_dangky.Enabled = false;
                txt_confirmpass.Focus();
            }
            else
                this.errorProvider1.Clear();
            btn_dangky.Enabled = true;
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ứng dụng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
