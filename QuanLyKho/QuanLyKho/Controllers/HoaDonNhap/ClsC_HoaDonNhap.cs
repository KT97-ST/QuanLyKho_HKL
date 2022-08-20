using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho.Models.HoaDonNhap;



namespace QuanLyKho.Controllers.HoaDonNhap
{
    class ClsC_HoaDonNhap
    {
        ClsM_HoaDonNhap cls_HoaDonNhap = new ClsM_HoaDonNhap();
        private static ClsC_HoaDonNhap instance;

        public static ClsC_HoaDonNhap Instance
        {
            get => instance != null ? instance : instance = new ClsC_HoaDonNhap();
            set => instance = value;
        }
        private ClsC_HoaDonNhap() { }

        public DataTable GetDanhSachSanPham()
        {
            return cls_HoaDonNhap.GetDanhSachSanPham();
        }
        public DataTable GetDanhSachHoaDon()
        {
            return cls_HoaDonNhap.GetDanhSachHoaDon();
        }
        public DataTable GetHoaDonById(string idHoaDon)
        {
            return cls_HoaDonNhap.GetHoaDonById(idHoaDon);
        }
        public DataTable GetHoaDonChiTietById(string idHoaDon)
        {
            return cls_HoaDonNhap.GetHoaDonChiTietById(idHoaDon);
        }
        public string InsertHoaDonNhap(string maHoaDon, string soLo, string idNCC,string idNguoiNhap,DateTime ngayNhap, string tongTien , string VAT, string tongTienSauThue, string hinhThucThanhToan)
        {
            return cls_HoaDonNhap.InsertHoaDonNhap(maHoaDon, soLo, idNCC, idNguoiNhap, ngayNhap, tongTien, VAT, tongTienSauThue, hinhThucThanhToan);
        }
        public bool UpdateHoaDonNhap(string idHoaDon, string soLo, string idNCC, string idNguoiNhap, string tongTien, string VAT, string tongTienSauThue, string HinhThucThanhToan)
        {
            return cls_HoaDonNhap.UpdateHoaDonNhap(idHoaDon, soLo, idNCC, idNguoiNhap, tongTien, VAT, tongTienSauThue, HinhThucThanhToan);
        }

        public bool InsertHoaDonNhap_CT(string idHoaDonNhap, string idSanPham, string soLuong,string giaNhap, string thanhTien, DateTime ngayNhap)
        {
          return cls_HoaDonNhap.InsertHoaDonNhap_CT(idHoaDonNhap, idSanPham, soLuong, giaNhap, thanhTien, ngayNhap);
        }
        public bool UpdateHoaDonNhap_CT(string idHoaDon, string idHoaDonNhapCT, string idSanPham, string soLuong, string giaNhap, string thanhTien, DateTime ngayNhap)
        {
          return  cls_HoaDonNhap.UpdateHoaDonNhap_CT(idHoaDon, idHoaDonNhapCT, idSanPham, soLuong, giaNhap, thanhTien, ngayNhap);
        }
        public void DeleteHoaDonNhapCT(string idHoaDonCT)
        {
            cls_HoaDonNhap.DeleteHoaDonNhapCT(idHoaDonCT);
        }
    }
}
