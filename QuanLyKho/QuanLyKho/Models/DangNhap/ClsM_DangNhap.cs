using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using QuanLyKho.Controllers.DungChung;
using QuanLyKho.Controllers;
using System.Data;

namespace QuanLyKho.Models.DangNhap
{
    public class ClsM_DangNhap
    {
        private static ClsM_DangNhap instance;

        public static ClsM_DangNhap Instance
        {
            get => instance != null ? instance : instance = new ClsM_DangNhap();
            set => instance = value;
        }
        private ClsM_DangNhap() { }

        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public DataTable CheckLogin(string userName, string Password)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_NhanVienByUser @NHANVIEN_USER , @NHANVIEN_PASSWORD", new object[] { userName, Password});
        }

        /// <summary>
        /// kiểm tra tài khoản có tồn tại chưa
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public object CheckIssetUser(string userName, string maNhanVien)
        {
            return DataProvider_Controller.Instance.ExecuteScalar("GET_NhanVien_Isset @NHANVIEN_USER , @NHANVIEN_MA", new object[] { userName, maNhanVien });
        }

        /// <summary>
        /// Test that the server is connected
        /// </summary>
        /// <param name="connectionString">The connection string</param>
        /// <returns>true if the connection is opened</returns>
        public  bool IsServerConnected()
        {
            bool ret = false;
            using (SqlConnection connection = ClsDB_Utils.GetDBConnection())
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
