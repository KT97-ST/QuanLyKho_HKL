using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.ClsM_DanhMuc;

namespace QuanLyKho.Controllers.ClsC_DanhMuc
{
    class ClsC_KiemQuyen
    {
        ClsM_KiemQuyen clsM_KiemQuyen = new ClsM_KiemQuyen();
        private static ClsC_KiemQuyen instance;

        public static ClsC_KiemQuyen Instance
        {
            get => instance != null ? instance : instance = new ClsC_KiemQuyen();
            set => instance = value;
        }
        private ClsC_KiemQuyen() { }
        public void KiemQuyentheoID(int idNV, string chucnang_ma, out bool qThem, out bool qSua, out bool qXoa)
        {
            //qThem = false;
            //qSua = false;
            //qXoa = false;
            clsM_KiemQuyen.KiemQuyentheoID(idNV, chucnang_ma,out qThem, out qSua, out qXoa);
        }
    }
}
