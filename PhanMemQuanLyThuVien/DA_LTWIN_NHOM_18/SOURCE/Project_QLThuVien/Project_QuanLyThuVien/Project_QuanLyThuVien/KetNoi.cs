using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_QuanLyThuVien
{
    public partial class frm_KetNoi : Form
    {
        SqlConnection connsql;
        //SqlCommand cmd;
        public frm_KetNoi()
        {
            InitializeComponent();
            string sql = (" Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password = sa2012");
            connsql = new SqlConnection(sql);
        }

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            connsql.Open();
            if (connsql.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công ", "Thông báo ");
            }
            
            frm_DangNhap dangnhap = new frm_DangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void frm_KetNoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát Form không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
