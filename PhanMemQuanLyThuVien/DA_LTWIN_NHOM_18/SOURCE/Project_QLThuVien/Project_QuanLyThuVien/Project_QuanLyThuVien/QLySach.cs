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
    public partial class frm_QLSach : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        public frm_QLSach()
        {
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void frm_QLSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát Form không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        public void Load_ThongTinSach()
        {
            //DataSet ds = new DataSet();
            string strsql = "Select * from Sách";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_timkiemsach.DataSource = table;
            dgv_timkiemsach.Columns["STT"].DisplayIndex = 0;

        }

        private void frm_QLSach_Load(object sender, EventArgs e)
        {
            Load_ThongTinSach();
            Load_TenSach();
            
        }
        public void Load_TenSach()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string str = "SELECT [Tensach] FROM [QL_Sach].[dbo].[Sách]";
            cmd = new SqlCommand(str, connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo_timkiem.Items.Add(dr[0].ToString());
            }
            connsql.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //string valueToSearch = cbo_timkiem.Text.ToString();
            //DataTable tb = new DataTable();
            //dgv_timkiemsach.DataSource = tb;
            SearchData();
            //Load_TenSach();

        }
        public void SearchData()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string str = "SELECT * FROM [QL_Sach].[dbo].[Sách] WHERE Tensach like N'%"+cbo_timkiem.SelectedItem.ToString()+"%'";
            cmd = new SqlCommand(str, connsql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable  table = new DataTable();
            da.Fill(table);

            dgv_timkiemsach.DataSource = table;
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }
    }
}
