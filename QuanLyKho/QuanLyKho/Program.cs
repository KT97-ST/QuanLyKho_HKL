using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading.Tasks;
using QuanLyKho.Models.Connect;
using QuanLyKho.Views.Connection;
using System.Data.SqlClient;
using QuanLyKho.Views.DanhMuc;
using QuanLyKho.Views.DangNhap;
using QuanLyKho.Views.Connection;

namespace QuanLyKho
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.WriteLine("Getting Connection ...");
            //SqlConnection conn = ClsDB_Utils.GetDBConnection();


            //try
            //{
            //    Console.WriteLine("Openning Connection ...");

            //    conn.Open();
            //    Console.WriteLine("Connection successful!");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmMain());
                Application.Run(new DlgDangNhap());

            //}
            //catch
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new frmMain());


            //}

            //Console.Read();

        }
    }
}