using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.KhachHang;

namespace QuanLyKho.Controllers.KhachHang
{
    public class ClsC_KhachHang
    {
        private static ClsC_KhachHang instance;

        public static ClsC_KhachHang Instance
        {
            get => instance != null ? instance : instance = new ClsC_KhachHang();
            set => instance = value;
        }
        private ClsC_KhachHang() { }

        // lấy dữ liệu khách hàng
        public DataTable GetKhachHang()
        {
            return ClsM_KhachHang.Instance.GetKhachHang();
        }

        // thêm mới khách hàng
        public int InsertKhachHng(string maKH, string tenKH, string sdtKH, string diaChiKH, string taiKhoanATM, string maSoThueKH)
        {
            return ClsM_KhachHang.Instance.InsertKhachHang(maKH, tenKH, sdtKH, diaChiKH, taiKhoanATM, maSoThueKH);
        }

        // cập nhật khách hàng
        public int UpdateKhachHang(int idKH, string maKH, string tenKH, string sdtKH, string diaChiKH, string taiKhoanATM, string maSoThueKH)
        {
            return ClsM_KhachHang.Instance.UpdateKhachHang(idKH, maKH, tenKH, sdtKH, diaChiKH, taiKhoanATM, maSoThueKH);
        }


        /// <summary>
        /// Kiểm tra khách hàng có hóa đơn xuất nào không
        /// </summary>
        /// <param name="idKH"></param>
        /// <returns></returns>
        public int CheckKHInHDX(int idKH)
        {
            int ret = 0;
            DataTable dt = ClsM_KhachHang.Instance.CheckKHInHDX(idKH);
            if (dt.Rows.Count > 0) ret = dt.Rows.Count;
            return ret;
        }

        /// <summary>
        /// lấy thông tin khách hàng có hóa đơn xuất
        /// </summary>
        /// <returns></returns>
        public DataTable KhachHangCoHoaDonXuat()
        {
            return ClsM_KhachHang.Instance.KhachHangCoHoaDonXuat();
        }

        // xóa khách hàng
        public int DeleteKhachHang(int idKH)
        {
            return ClsM_KhachHang.Instance.DeleteKhachHang(idKH);
        }

        /// <summary>
        /// Kiểm tra mã khách hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public object CheckIssetKhacHang(string maKH)
        {
            return ClsM_KhachHang.Instance.CheckIssetKhacHang(maKH);
        }

    }
}
