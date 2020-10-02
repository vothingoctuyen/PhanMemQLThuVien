using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuanLyThuVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_QLThuVien());   
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_KetNoi());
            //Application.Run(new frm_QLdanhmuc());
            //Application.Run(new frm_QLMTS());
            //Application.Run(new frm_QLThongTinSinhVien());
            //Application.Run(new frm_QLSach());
            //Application.Run(new frm_PhieuMuon());
            //Application.Run(new Report_Sach());
            //Application.Run(new Report_SVMuon());
        }
    }
}
