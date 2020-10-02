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
    public partial class frm_QLThongTinSinhVien : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        public frm_QLThongTinSinhVien()
        {
           
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void frm_QLThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ứng dụng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_timkiemsinhvien_Leave(object sender, EventArgs e)
        {
            //txt_timkiemsinhvien.Text = "Seach";
            //txt_timkiemsinhvien.ForeColor = Color.Gray;
        }

        private void txt_timkiemsinhvien_Enter(object sender, EventArgs e)
        {
            //txt_timkiemsinhvien.Text = "";
            //txt_timkiemsinhvien.ForeColor = Color.Black;
        }
        private void Load_Khoa()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "SELECT DISTINCT [Khoa] FROM [QL_Sach].[dbo].[Thông tin sinh viên]";
            cmd = new SqlCommand(s,connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo_khoa.Items.Add(dr[0].ToString());
            }
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            cbo_khoa.Text = "Chọn một Khoa";
        }
        public void Load_ThongTinSinhVien()
        {
            //DataSet ds = new DataSet();
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string strsql = "select * from [Thông tin sinh viên]";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_thongtinsinhvien.DataSource = table;
            dgv_thongtinsinhvien.Columns["STT"].DisplayIndex = 0;
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }
        
        private void frm_QLThongTinSinhVien_Load(object sender, EventArgs e)
        {
            Load_ThongTinSinhVien();
            Load_SinhVien();
            Load_Khoa();
        }
       
        public void Load_SinhVien()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string str = "SELECT [MSSV] FROM [QL_Sach].[dbo].[Thông tin sinh viên]";
            cmd = new SqlCommand(str, connsql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo_mssv.Items.Add(dr[0].ToString());
                cbo_timkiemsv.Items.Add(dr[0].ToString());
            }
            connsql.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "SELECT DISTINCT [Tenlop], [MaLop] FROM [QL_Sach].[dbo].[Thông tin sinh viên] Where [QL_Sach].[dbo].[Thông tin sinh viên].[Khoa] LIKE N'" + cbo_khoa.SelectedItem.ToString() + "%';";
            SqlDataAdapter da = new SqlDataAdapter(s, connsql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo_lop.DataSource = dt;
            cbo_lop.DisplayMember = "TenLop";
            cbo_lop.ValueMember = "MaLop";
            txt_malop.Text = cbo_lop.SelectedValue.ToString();
            cbo_lop.SelectedIndex = 0;
            if (connsql.State.ToString() == "Open")
                connsql.Close();
        }

        public bool KTTrungKhoaChinh(string key)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string s = "SELECT count(*) FROM [QL_Sach].[dbo].[Thông tin sinh viên] WHERE MSSV ='" + key + "'";
            cmd = new SqlCommand(s, connsql);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
                return true;
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            try
            {
                if (KTTrungKhoaChinh(cbo_mssv.Text) == false)
                {
                    string insertString = "INSERT INTO [QL_Sach].[dbo].[Thông tin sinh viên] VALUES('" + cbo_mssv.Text.Trim() + "', N'" + txt_ten.Text.Trim() + "','" + txt_malop.Text.Trim() + "',N'" + cbo_lop.Text.Trim() + "',N'" + cbo_khoa.Text.Trim() + "','" + msk_ngaysinh.Text + "',";
                    if (rbtn_nam.Checked == true)
                        insertString += "N'Nam');";
                    else
                        insertString += "N'Nữ');";
                    //MessageBox.Show(insertString);
                    cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Mã số bị trùng, bạn phải nhập lại");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            Load_ThongTinSinhVien();
        }
        private void cbo_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_malop.Text = cbo_lop.SelectedValue.ToString();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State.ToString() != "Open")
                    connsql.Open();
                int index = dgv_thongtinsinhvien.CurrentCell.RowIndex;
                string str_xoa = dgv_thongtinsinhvien.Rows[index].Cells[0].Value.ToString().Trim();
                str_xoa = "DELETE [QL_Sach].[dbo].[Thông tin sinh viên] WHERE MSSV ='" + str_xoa + "'";
                //MessageBox.Show(str_xoa);
                cmd = new SqlCommand(str_xoa, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Load_ThongTinSinhVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string insertString = "";
            if (rbtn_nam.Checked == true)
                insertString = "UPDATE [QL_Sach].[dbo].[Thông tin sinh viên] SET [MSSV] = '" + cbo_mssv.Text.Trim() + "',[HoTenSinhVien] = N'" + txt_ten.Text.Trim() + "', [MaLop] = '" + txt_malop.Text.Trim() + "', [Tenlop] = N'" + cbo_lop.Text.Trim() + "', [Khoa] = N'" + cbo_khoa.Text.Trim() + "', [NgaySinh] = '" + msk_ngaysinh.Text + "', [GioiTinh] = N'Nam' WHERE MSSV = '" + cbo_mssv.Text.Trim() + "';";
            else
                insertString = "UPDATE [QL_Sach].[dbo].[Thông tin sinh viên] SET [MSSV] = '" + cbo_mssv.Text.Trim() + "',[HoTenSinhVien] = N'" + txt_ten.Text.Trim() + "', [MaLop] = '" + txt_malop.Text.Trim() + "', [Tenlop] = N'" + cbo_lop.Text.Trim() + "', [Khoa] = N'" + cbo_khoa.Text.Trim() + "', [NgaySinh] = '" + msk_ngaysinh.Text + "', [GioiTinh] = N'Nữ' WHERE MSSV = '" + cbo_mssv.Text.Trim() + "';";
                MessageBox.Show(insertString);
                cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Load_ThongTinSinhVien();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //}
        }

        private void dgv_thongtinsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbo_mssv.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_malop.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbo_lop.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbo_khoa.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            msk_ngaysinh.Text = dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dgv_thongtinsinhvien.Rows[e.RowIndex].Cells[6].Value.ToString().Trim() == "Nam")
                rbtn_nam.Checked = true;
            else
                rbtn_nu.Checked = true;

        }

        private void txt_malop_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_malop_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string strsql = "select * from [QL_Sach].[dbo].[Thông tin sinh viên] Where [MSSV] = '" + cbo_timkiemsv.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(strsql, connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            table.Columns.Add("Trạng thái");
            try
            {

                table.Rows[0]["Trạng thái"] = Load_trangthai();
            }
            catch { }
            dgv_thongtinsinhvien.DataSource = table; 
        }
        public int Load_trangthai()
        {
            if (connsql.State.ToString() != "Open")
                connsql.Open();
            string strsql = "select sum([SoLuongMuon]) from [QL_Sach].[dbo].[Quản Lý Mượn] where [MSSV] = '"+cbo_timkiemsv.Text.Trim()+"';";
            cmd = new SqlCommand(strsql,connsql);
            int i = (int)(cmd.ExecuteScalar());
            if (connsql.State.ToString() == "Open")
                connsql.Close();
            return i;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
