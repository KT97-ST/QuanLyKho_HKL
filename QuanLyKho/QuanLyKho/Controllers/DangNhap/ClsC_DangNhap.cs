using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.DangNhap;

namespace QuanLyKho.Controllers.DangNhap
{
    public class ClsC_DangNhap
    {
        private static ClsC_DangNhap instance;

        public static ClsC_DangNhap Instance
        {
            get => instance != null ? instance : instance = new ClsC_DangNhap();
            set => instance = value;
        }
        private ClsC_DangNhap() { }


        /// <summary>
        /// kiểm tra đăng nhập
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public DataTable CheckLogin(string userName, string Password)
        {
            return ClsM_DangNhap.Instance.CheckLogin(userName, Password);
        }

        /// <summary>
        /// kiểm tra tải khoản có tồn tại hay chưa
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public object CheckIseetUser(string userName, string maNhanVien)
        {
            return ClsM_DangNhap.Instance.CheckIssetUser(userName, maNhanVien);
        }

        // kiểm tra kết nối
        public bool IsServerConnected()
        {
            return ClsM_DangNhap.Instance.IsServerConnected();
        }

    }
}
