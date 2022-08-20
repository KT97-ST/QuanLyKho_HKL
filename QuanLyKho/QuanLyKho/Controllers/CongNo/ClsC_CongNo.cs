using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.CongNo;

namespace QuanLyKho.Controllers.CongNo
{
    public class ClsC_CongNo
    {
        private static ClsC_CongNo instance;

        public static ClsC_CongNo Instance
        {
            get => instance != null ? instance : instance = new ClsC_CongNo();
            set => instance = value;
        }
        private ClsC_CongNo() { }

        // load công nợ
        public DataTable GetCongNo()
        {
            return ClsM_CongNo.Instance.GetCongNo();
        }

        /// <summary>
        ///  Lấy danh sách hóa đơn xuất theo id khách hàng
        /// </summary>
        /// <param name="idKH"></param>
        /// <returns></returns>
        public DataTable GetCongNoByIdKH(string idKH)
        {
            return ClsM_CongNo.Instance.GetCongNoByIdKH(idKH);
        }

        /// <summary>
        ///Lấy danh sách hóa đơn xuất theo id khách hàng
        /// </summary>
        /// <param name="idKH"></param>
        /// <returns></returns>
        public DataTable GetHoaDonXuatByIdKH(string idKH)
        {
            return ClsM_CongNo.Instance.GetHoaDonXuatByIdKH(idKH);
        }

        /// <summary>
        /// lấy thông tin chi tiết hóa đơn xuất theo id hóa đơn
        /// </summary>
        /// <param name="idHD"></param>
        /// <returns></returns>
        public DataTable GetHoDonXuatByIdHD(string idHD)
        {
            return ClsM_CongNo.Instance.GetHoDonXuatByIdHD(idHD);
        }

        /// <summary>
        /// thanh toán công nợ theo hóa đơn xuất
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <param name="soTienThanhToan"></param>
        /// <returns></returns>
        public int ThanhToanCongNo_HDX(string idHoaDon, string soTienThanhToan)
        {
            return ClsM_CongNo.Instance.ThanhToanCongNo_HDX(idHoaDon, soTienThanhToan);
        }

        /// <summary>
        /// lấy thông tin chi tiết hóa đơn xuất theo id hóa đơn
        /// </summary>
        /// <param name="IdHD"></param>
        /// <returns></returns>
        public DataTable GetHoaDonXuat_CTByIdHD(int IdHD)
        {
            return ClsM_CongNo.Instance.GetHoaDonXuat_CTByIdHD(IdHD);
        }
    }
}
