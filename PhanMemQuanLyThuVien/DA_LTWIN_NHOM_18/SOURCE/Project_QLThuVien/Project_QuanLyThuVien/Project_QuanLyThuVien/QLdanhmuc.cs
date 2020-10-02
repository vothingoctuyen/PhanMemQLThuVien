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
    public partial class frm_QLdanhmuc : Form
    {
        SqlConnection connsql;
        SqlCommand cmd;
        string hanhdong = "";
        public frm_QLdanhmuc()
        { 
            InitializeComponent();
            string sql = ("Data Source = LINHNGOC\\SQLEXPRESS; Initial Catalog = QL_Sach; User ID = sa; Password= sa2012");
            connsql = new SqlConnection(sql);
        }

        private void frm_QLdanhmuc_FormClosing(object sender, FormClosingEventArgs e)
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
            SqlDataAdapter da = new SqlDataAdapter(strsql,connsql);
            DataTable table = new DataTable();
            da.Fill(table);
            table.Columns.Add("STT");
            for (int i = 0; i < table.Rows.Count; i++)
                table.Rows[i]["STT"] = i + 1;
            dgv_thongtinsach.DataSource = table;
            dgv_thongtinsach.Columns["STT"].DisplayIndex = 0;
            btn_luu.Enabled = false;

        }
        private void frm_QLdanhmuc_Load(object sender, EventArgs e)
        {
            Load_ThongTinSach();
            Hien_An(false);
           
        }
        private void Hien_An(bool i)
        {
            txt_masach.Enabled = txt_sl.Enabled = txt_tensach.Enabled = txt_tg.Enabled = txt_trangthai.Enabled =msk_ngaynhap.Enabled = i;
            btn_luu.Enabled = i;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled = (!i);
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            Hien_An(true);
            hanhdong = "them";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State.ToString() != "Open")
                    connsql.Open();
                int index = dgv_thongtinsach.CurrentCell.RowIndex;
                string str_xoa = dgv_thongtinsach.Rows[index].Cells[0].Value.ToString().Trim();
                str_xoa = "DELETE Sách WHERE Masach='" + str_xoa + "'";
                cmd = new SqlCommand(str_xoa, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            Load_ThongTinSach();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            if (Ham_Tim_Ma())
                if (hanhdong == "them")
                    MessageBox.Show("Đã tồn tại! không thêm được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                else
                    Sua();
            else
                if (hanhdong == "them")
                    Them();
                else
                    MessageBox.Show("Có rồi lấy gì sửa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            Hien_An(false);            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Them()
        {
            try
            {

                string insertString = "INSERT INTO [QL_Sach].[dbo].[Sách] VALUES ('" + txt_masach.Text + "', N'" + txt_tensach.Text + "','"+msk_ngaynhap.Text+"',N'" + txt_tg.Text + "','" + txt_sl.Text + "',N'" + txt_trangthai.Text + "')";
                cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txt_masach.Clear();
                txt_tensach.Clear();
                txt_sl.Clear();
                txt_tg.Clear();
                msk_ngaynhap.Focus();
                txt_masach.Focus();
                btn_them.Enabled = false;
                btn_luu.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            Load_ThongTinSach();
        }
        private void Sua()
        {
            try
            {
                //DateTime NGAYNHAP = date_ngaynhapsach.Value;
                //string ngayNhap = NGAYNHAP.ToShortDateString();
                string sua = "update [QL_Sach].[dbo].[Sách] set Tensach = N'"+txt_tensach.Text+"', Ngaynhap = '"+msk_ngaynhap.Text+"', Tacgia = N'"+txt_tg.Text+"', Soluong = "+txt_sl.Text+", Trangthai = N'"+txt_trangthai.Text+"' where Masach = '"+txt_masach.Text+"';";
                cmd = new SqlCommand(sua, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txt_masach.Clear();
                txt_tensach.Clear();
                txt_sl.Clear();
                txt_tg.Clear();
                msk_ngaynhap.Focus();
                txt_masach.Focus();
                btn_them.Enabled = false;
                btn_luu.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            Load_ThongTinSach();
        }
        private bool Ham_Tim_Ma()
        {
            if (connsql.State != ConnectionState.Open)
                connsql.Open();
            string str = "SELECT Masach FROM [QL_Sach].[dbo].[Sách] WHERE Masach = '"+txt_masach.Text.Trim()+"';";
            cmd = new SqlCommand(str,connsql);
            str = ((string)cmd.ExecuteScalar());
            if ((str+" ") != " ")
                return true;
            else
                return false;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            hanhdong = "sua";
            Hien_An(true);
            txt_masach.Enabled = false;
            ////Load dữ liệu lên
            //txt_masach.Text = dgv_thongtinsach.Rows[dgv_thongtinsach.SelectedRows].Cells[1].ToString();
        }

        private void dgv_thongtinsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masach.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tensach.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            msk_ngaynhap.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_tg.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sl.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_trangthai.Text = dgv_thongtinsach.Rows[e.RowIndex].Cells[5].Value.ToString();
            Hien_An(false);
        }

        private void txt_masach_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "");
                //MessageBox.Show("Bạn phải nhập mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                btn_them.Enabled = false;
                txt_masach.Focus();
            }
            else
                this.errorProvider1.Clear();
                  btn_them.Enabled = true;
        }
       
       
    }
             
}
