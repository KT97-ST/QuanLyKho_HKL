using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.ClsM_DanhMuc;
using System.Data;

namespace QuanLyKho.Controllers.ClsC_DanhMuc
{
    class ClsC_CapNhatGia
    {
        ClsM_CapNhatGia clsM_CapNhatGia = new ClsM_CapNhatGia();
        private static ClsC_CapNhatGia instance;

        public static ClsC_CapNhatGia Instance
        {
            get => instance != null ? instance : instance = new ClsC_CapNhatGia();
            set => instance = value;
        }
        private ClsC_CapNhatGia() { }
        public DataTable GetThongTinGia()
        {

            return clsM_CapNhatGia.GetThongTinGia();
        }
        public void InsertGiaMoi(string idsanpham, string idloaigia, string giatien, DateTime thoigianBD)
        {
             clsM_CapNhatGia.InsertGiaMoi(idsanpham, idloaigia, giatien, thoigianBD);
        }
    }
}
