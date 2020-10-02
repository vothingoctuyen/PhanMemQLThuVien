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
    public partial class frm_QL_MuonSach : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        public frm_QL_MuonSach()
        {
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ứng dụng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
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
        public void Load_Muon()
        {
            //DataSet ds = new DataSet();
            string strsql = "select *from [Quản Lý Mượn]";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_muon.DataSource = table;
            dgv_muon.Columns["STT"].DisplayIndex = 0;   
        }
        
        private void frm_QLMTS_Load(object sender, EventArgs e)
        {
            Load_Muon();
            Load_Sach();
            Load_MSSV();
            
        }
        private bool KiemTraMSSV()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "select count(*) from [QL_Sach].[dbo].[Quản Lý Mượn] where [QL_Sach].[dbo].[Quản Lý Mượn].[MSSV]='"+cbo_mssv.Text+"'";
            cmd = new SqlCommand(s, connsql);
            int i = (int)cmd.ExecuteScalar();
            if (i > 0)
                //nếu đã từng mượn, trả về true;
                return true;
            //nếu chưa từng mượn trả về false
            return false;

        }
        private void btn_muonmoi_Click(object sender, EventArgs e)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            if (KiemTraMSSV()) // nếu đã từng mượn
            {
                MessageBox.Show("Sinh viên này đã từng mượn, phải nhấn nút mượn thêm mới đúng!");
                return;
            }
            try
            {
                string s = "insert into [QL_Sach].[dbo].[Quản Lý Mượn] values ('"+cbo_masach.SelectedItem.ToString()+"','"+cbo_mssv.SelectedItem.ToString()+"',"+txt_sl.Text+",'"+msk_ngaymuon.Text+"','"+msk_ngaygiahan.Text+"');";
                cmd = new SqlCommand(s, connsql);
                cmd.ExecuteNonQuery();
                if (!KTNM())
                {
                    return;
                }
                MessageBox.Show("Mượn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có thông tin sinh viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            Load_Muon();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_masach_TextChanged(object sender, EventArgs e)
        {

        }
        public bool KTNM()
        {
            if (msk_ngaymuon.MaskFull)
            {
                try
                {
                    DateTime dateofbirth = DateTime.ParseExact(msk_ngaymuon.Text, "dd/mm/yyyy", null);
                    int tuoi = DateTime.Now.Year - dateofbirth.Year;
                    
                }
                catch
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    msk_ngaymuon.ResetText();
                    msk_ngaymuon.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nhập ngày sinh dd/mm/yyyy");
                msk_ngaymuon.ResetText();
                msk_ngaymuon.Focus();
                return false;
            }
            return true;
        }

        private void btn_muonmoi_Click_1(object sender, EventArgs e)
        {
            btn_muonmoi_Click(sender, e);
        }

        private void btn_muonthem_Click(object sender, EventArgs e)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            if (!KiemTraMSSV()) // nếu  mượn
            {
                MessageBox.Show("Sinh viên này chưa từng mượn, phải nhấn nút mượn mới!");
                return;
            }
            try
            {
                string s = "insert into [QL_Sach].[dbo].[Quản Lý Mượn] values ('" + cbo_masach.SelectedItem.ToString() + "','" + cbo_mssv.SelectedItem.ToString() + "'," + txt_sl.Text + ",'" + msk_ngaymuon.Text + "','" + msk_ngaygiahan.Text + "');";
                cmd = new SqlCommand(s, connsql);
                cmd.ExecuteNonQuery();
                if (!KTNM())
                {
                    return;
                }
                MessageBox.Show("Mượn thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Mượn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            Load_Muon();
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_masach_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_muonmoi.Enabled = false;
                btn_muonthem.Enabled = false;
                cbo_masach.Focus();
            }
            else
                this.errorProvider1.Clear();
                btn_muonmoi.Enabled = true;
                btn_muonthem.Enabled = true;
        }

        private void cbo_mssv_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                MessageBox.Show("Bạn phải nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_muonmoi.Enabled = false;
                btn_muonthem.Enabled = false;
                cbo_mssv.Focus();
            }
            else
                this.errorProvider1.Clear();
                btn_muonmoi.Enabled = true;
                btn_muonthem.Enabled = true;
        }
    }
}
