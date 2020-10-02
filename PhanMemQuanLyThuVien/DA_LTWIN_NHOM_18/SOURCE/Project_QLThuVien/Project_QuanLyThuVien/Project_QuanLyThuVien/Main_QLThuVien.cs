using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyThuVien
{
    public partial class Main_QLThuVien : Form
    {
        
        private string _message;

        public Main_QLThuVien()
        {
            InitializeComponent();
        }
        public Main_QLThuVien(string Message)
        {
            InitializeComponent();
            _message = Message;
        }
        private void Main_QLThuVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát ứng dụng???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }
        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void QL_DanhMục_Click(object sender, EventArgs e)
        {
            frm_QLdanhmuc QLDM = new frm_QLdanhmuc();
            QLDM.Show();
        }

        private void QL_Ssách_Click(object sender, EventArgs e)
        {
            frm_QLSach QLS = new frm_QLSach();
            QLS.Show();
        }

        private void QL_ThôngTinSinhViên_Click(object sender, EventArgs e)
        {
            frm_QLThongTinSinhVien QLTTSV = new frm_QLThongTinSinhVien();
            QLTTSV.Show();
        }
        private void Main_QLThuVien_Load(object sender, EventArgs e)
        {
            if (_message == "thuthu")
            {
                QL_nguoidung.Enabled = false;
            }
        }

        private void QLMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QL_MuonSach QLMS = new frm_QL_MuonSach();
            QLMS.Show();
        }

        private void QLTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_QL_TraSach QLTS = new frm_QL_TraSach();
            QLTS.Show();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Sach sach = new Report_Sach();
            sach.Show();
        }

        private void thốngKêSinhViênMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_SVMuon svmuon = new Report_SVMuon();
            svmuon.Show();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_PhieuMuon pm = new frm_PhieuMuon();
            //pm.Show();
        }

        private void QL_nguoidung_Click(object sender, EventArgs e)
        {
            QL_NguoiDung nd = new QL_NguoiDung();
            nd.ShowDialog();
        }
    }
}
 