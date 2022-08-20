using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho.Models.HoaDonXuat;

namespace QuanLyKho.Controllers.HoaDonXuat
{
    class ClsC_HoaDonXuat
    {
        ClsM_HoaDonXuat cls_HoaDonXuat = new ClsM_HoaDonXuat();
        private static ClsC_HoaDonXuat instance;

        public static ClsC_HoaDonXuat Instance
        {
            get => instance != null ? instance : instance = new ClsC_HoaDonXuat();
            set => instance = value;
        }
        private ClsC_HoaDonXuat() { }
        public DataTable GetDanhSachSanPham( DateTime ngayLapHD,int xuatdaily)
        {
            return cls_HoaDonXuat.GetDanhSachSanPham(ngayLapHD, xuatdaily);
        }
        public DataTable GetDanhSachHoaDon(int xuatdaily)
        {
            return cls_HoaDonXuat.GetDanhSachHoaDon(xuatdaily);
        }
        public DataTable GetHoaDonById(string idHoaDon)
        {
            return cls_HoaDonXuat.GetHoaDonById(idHoaDon);
        }
        public DataTable GetHoaDonChiTietById(string idHoaDon)
        {
            return cls_HoaDonXuat.GetHoaDonChiTietById(idHoaDon);
        }
        public string InsertHoaDonXuat(string maHoaDon, string soLo, string idKH, string idNguoiNhap, DateTime ngayNhap, string tongTien, string VAT, string tongTienSauThue, string soTienDaThanhToan, string hinhThucThanhToan,int xuatdaily)
        {
            return cls_HoaDonXuat.InsertHoaDonXuat(maHoaDon, soLo, idKH, idNguoiNhap, ngayNhap, tongTien, VAT, tongTienSauThue,soTienDaThanhToan, hinhThucThanhToan, xuatdaily);
        }
        public bool UpdateHoaDonXuat(string idHoaDon, string soLo, string idKH, string idNguoiNhap, string tongTien, string VAT, string tongTienSauThue,string soTienDaThanhToan, string HinhThucThanhToan)
        {
          return  cls_HoaDonXuat.UpdateHoaDonXuat(idHoaDon, soLo, idKH, idNguoiNhap, tongTien, VAT, tongTienSauThue, soTienDaThanhToan, HinhThucThanhToan);
        }

        public bool InsertHoaDonXuat_CT(string idHoaDonNhap, string idSanPham, string soLuong, string giaNhap, string thanhTien,DateTime ngayLap)
        {
           return cls_HoaDonXuat.InsertHoaDonXuat_CT(idHoaDonNhap, idSanPham, soLuong, giaNhap, thanhTien,ngayLap);
        }
        public bool UpdateHoaDonXuat_CT(string idHoaDon, string idHoaDonXuatCT, string idSanPham, string soLuong,  string thanhTien)
        {
           return cls_HoaDonXuat.UpdateHoaDonXuat_CT(idHoaDon, idHoaDonXuatCT, idSanPham, soLuong, thanhTien);
        }
    }
}
