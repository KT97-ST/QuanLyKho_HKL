using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.KhachHang
{
    public class ClsM_KhachHang
    {
        private static ClsM_KhachHang instance;

        public static ClsM_KhachHang Instance
        {
            get => instance != null ? instance : instance = new ClsM_KhachHang();
            set => instance = value;
        }
        private ClsM_KhachHang() { }


        public DataTable GetKhachHang()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_KhachHang");
            return data;
        }

        // insert khách hàng
        public int InsertKhachHang(string maKH, string tenKH, string sdtKH, string diaChiKH, string taiKhoanATM, string maSoThueKH)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("INSERT_KhachHang @KHACHHANG_MA , @KHACHHANG_TEN , @KHACHHANG_SDT , @KHACHHANG_DIACHI , @KHACHHANG_TK_ATM , @KHACHHANG_MASOTHUE", new object[] { maKH, tenKH, sdtKH, diaChiKH, taiKhoanATM, maSoThueKH });
        }

        // Cập nhật khách hàng
        public int UpdateKhachHang(int idKH, string maKH, string tenKH, string sdtKH, string diaChiKH, string taiKhoanATM, string maSoThueKH)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("UPDATE_KHACHHANG @KHACHHANG_ID , @KHACHHANG_MA , @KHACHHANG_TEN , @KHACHHANG_SDT , @KHACHHANG_DIACHI , @KHACHHANG_TK_ATM , @KHACHHANG_MASOTHUE", new object[] { idKH, maKH, tenKH, sdtKH, diaChiKH, taiKhoanATM, maSoThueKH });
        }


        /// <summary>
        /// Kiểm tra khách hàng có hóa đơn xuất nào không ?
        /// </summary>
        /// <param name="idKhachHang"></param>
        /// <returns></returns>
        public DataTable CheckKHInHDX(int idKhachHang)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("KTKhachHangCoHoaDonXuatHayKhong @KHACHHANG_ID", new object[] { idKhachHang});
        }

        /// <summary>
        /// lấy thông tin khách hàng có hóa đơn xuất
        /// </summary>
        /// <returns></returns>
        public DataTable KhachHangCoHoaDonXuat()
        {
            return DataProvider_Controller.Instance.ExecuteQuery("GET_KhachHangTrongHdx");
        }

        // Xóa loại nhân viên
        public int DeleteKhachHang(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("DELETE_KhachHang @KHACHHANG_ID", new object[] { id });
        }

        /// <summary>
        /// Kiểm tra mã khách hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public object CheckIssetKhacHang(string maKH)
        {
            return DataProvider_Controller.Instance.ExecuteScalar("ChechIsset_KhachHang @KHACHHANG_MA", new object[] { maKH });
        }
    }
}
