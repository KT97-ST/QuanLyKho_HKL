using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.CongNo
{
    public class ClsM_CongNo
    {
        private static ClsM_CongNo instance;

        public static ClsM_CongNo Instance
        {
            get => instance != null ? instance : instance = new ClsM_CongNo();
            set => instance = value;
        }
        private ClsM_CongNo() { }

        // load công nợ
        public DataTable GetCongNo()
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_CongNoKhachHang");
        }

        // load công nợ theo id khách hàng
        public DataTable GetCongNoByIdKH(string idKH)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_CongNoKhachHangByID @KHACHHANG_ID", new object[] { idKH });
        }


        // Lấy danh sách hóa đơn xuất theo id khách hàng 
        public DataTable GetHoaDonXuatByIdKH(string idKH)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_HoaDonXuatByIdKhachHang @KHACHHANG_ID", new object[] { idKH });
        }


        // lấy thông tin chi tiết hóa đơn xuất theo id hóa đơn
        public DataTable GetHoDonXuatByIdHD(string idHD) 
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_HoaDonXuatByIdHD @HOADONXUAT_ID", new object[] { idHD });
        }

        /// <summary>
        /// thanh toán công nợ
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <param name="soTienThanhToan"></param>
        /// <returns></returns>
        public int ThanhToanCongNo_HDX(string idHoaDon, string soTienThanhToan)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("UPDATE_CongNo_HoaDonXuat @HOADONXUAT_ID , @HOADONXUAT_SOTIEN_DATHANHTOAN", new object[] { idHoaDon, soTienThanhToan});
        }

        /// <summary>
        /// lấy thông tin chi tiết hóa đơn xuất theo id hóa đơn
        /// </summary>
        /// <returns></returns>
        public DataTable GetHoaDonXuat_CTByIdHD(int IdHD)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_HoaDonXuatChiTiet @HOADONXUAT_ID ", new object[] { IdHD});

        }
    }
}
