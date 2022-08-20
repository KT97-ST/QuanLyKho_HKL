using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.DoanhThu;
using System.Data;


namespace QuanLyKho.Controllers.DoanhThu
{
    class ClsC_DoanhThu
    {
        ClsM_DoanhThu clsM_DoanhThu = new ClsM_DoanhThu();
        private static ClsC_DoanhThu instance;

        public static ClsC_DoanhThu Instance
        {
            get => instance != null ? instance : instance = new ClsC_DoanhThu();
            set => instance = value;
        }
        private ClsC_DoanhThu() { }
        public DataTable GetThongTin(DateTime tungay, DateTime denngay)
        {
            return clsM_DoanhThu.GetThongTin(tungay, denngay);
        }

    }
}
