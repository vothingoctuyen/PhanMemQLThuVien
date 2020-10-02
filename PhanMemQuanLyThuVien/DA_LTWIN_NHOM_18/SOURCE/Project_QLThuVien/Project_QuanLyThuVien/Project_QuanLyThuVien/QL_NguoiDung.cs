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
    public partial class QL_NguoiDung : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        public QL_NguoiDung()
        {
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void QL_NguoiDung_Load(object sender, EventArgs e)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string strsql = "select * from [USER]";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_nguoidung.DataSource = table;
            dgv_nguoidung.Columns["STT"].DisplayIndex = 0;
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State.ToString() != "Open")
                    connsql.Open();
                int index = dgv_nguoidung.CurrentCell.RowIndex;
                string str_xoa = dgv_nguoidung.Rows[index].Cells[0].Value.ToString().Trim();
                str_xoa = "DELETE [QL_Sach].[dbo].[USER] WHERE [USER] ='" + str_xoa + "'";
                //MessageBox.Show(str_xoa);
                cmd = new SqlCommand(str_xoa, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (connsql.State.ToString() == "Open")
                    connsql.Close();
                QL_NguoiDung_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void QL_NguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ứng dụng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
