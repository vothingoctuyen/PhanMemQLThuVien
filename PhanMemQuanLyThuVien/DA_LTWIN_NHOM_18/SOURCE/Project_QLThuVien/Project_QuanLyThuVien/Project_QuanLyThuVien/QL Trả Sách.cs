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
    public partial class frm_QL_TraSach : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;

        public frm_QL_TraSach()
        {
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void QL_Trả_Sách_Load(object sender, EventArgs e)
        {
            //Load_Tra();
        }
        public void Load_Sach()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string str = "SELECT [Masach] FROM [QL_Sach].[dbo].[Sách]";
            cmd = new SqlCommand(str, connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo_masach.Items.Add(dr[0].ToString());
            }
            connsql.Close();
            cbo_masach.Text = "Chọn một mã sách";
        }
        public void Load_MSSV()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "SELECT [MSSV] FROM [QL_Sach].[dbo].[Thông tin sinh viên]";
            cmd = new SqlCommand(s, connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo_mssv.Items.Add(dr[0].ToString());
            }
            connsql.Close();
            cbo_mssv.Text = "Chọn một MSSV";
        }
        private void QL_Trả_Sách_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r;
            //r = MessageBox.Show("Bạn có muốn thoát Form không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.No)
            //    e.Cancel = true;
        }
        public void Load_Tra()
        {
            //DataSet ds = new DataSet();
            string strsql = "select *from [Quản Lý Trả]";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_tra.DataSource = table;
            dgv_tra.Columns["STT"].DisplayIndex = 0;
        }

        private void frm_QL_TraSach_Load(object sender, EventArgs e)
        {
            Load_Tra();
            Load_Sach();
            Load_MSSV();
        }

        private void frm_QL_TraSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ứng dụng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KiemTraMuon()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "SELECT count(*) FROM [QL_Sach].[dbo].[Quản Lý Mượn] WHERE MaSach = '" + cbo_masach.Text.Trim() + "' and MSSV = '" + cbo_mssv.Text.Trim() + "';";
            cmd = new SqlCommand(s, connsql);
            int i = (int)cmd.ExecuteScalar();
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            if (i > 0)
                return true;
            return false;
        }
        private void btn_tra_Click(object sender, EventArgs e)
        {
            if (!KiemTraMuon()) // trả về false nếu chưa mượn, mà không mượn thì sao trả
            {
                MessageBox.Show("Sinh viên này chưa mượn sách!!!");
                return;
            }
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "SELECT * FROM [QL_Sach].[dbo].[Quản Lý Mượn] WHERE MaSach = '"+cbo_masach.Text.Trim()+"' and MSSV = '"+cbo_mssv.Text.Trim()+"';";
            cmd = new SqlCommand(s, connsql);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            string tra = "";
            while(dr.Read())
            {
                s = "insert into [QL_Sach].[dbo].[Quản Lý Trả] values ('" + dr[0].ToString().Trim() + "','" + dr[1].ToString().Trim() + "'," + dr[2].ToString().Trim() + ",'"+DateTime.Now.ToString("MM/dd/yyyy")+"','" + Convert.ToDateTime(dr[3].ToString()).ToShortDateString() + "','" + Convert.ToDateTime(dr[3].ToString()).ToShortDateString() + "');";
                tra = "DELETE from [QL_Sach].[dbo].[Quản Lý Mượn] where [MaSach] = '" + dr[0].ToString().Trim() + "' and [MSSV] = '" + dr[1].ToString().Trim() + "';";
            }
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            Tra(s);
            Xoa_Muon(tra);
            Load_Tra();
        }
        private void Xoa_Muon(string s)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            cmd = new SqlCommand(s, connsql);
            cmd.ExecuteNonQuery();
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }
        private void Tra(string s)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            cmd = new SqlCommand(s, connsql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }
        private void XoaMuon()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "DELETE [QL_Sach].[dbo].[Quản Lý Mượn] WHERE MaSach = '" + cbo_masach.Text.Trim() + "' and MSSV = '" + cbo_mssv.Text.Trim() + "';";
            cmd = new SqlCommand(s, connsql);
            if (connsql.State.ToString() == "Open")
                connsql.Close();

        }

        private void cbo_mssv_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_tra.Enabled = false;
                cbo_mssv.Focus();
            }
            else
                this.errorProvider1.Clear();
                btn_tra.Enabled = true;
           
        }

        private void cbo_masach_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_tra.Enabled = false;
                cbo_masach.Focus();
            }
            else
                this.errorProvider1.Clear();
                 btn_tra.Enabled = true;
           
        }
    }
}
