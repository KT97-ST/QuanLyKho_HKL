using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.HoaDonNhap
{
    class ClsM_CreateSoHD
    {
        public void CreateSoHoaDon()
        {
            string sql = string.Format("SELECT ISNULL(MAX(LEFT(HOADONNHAP_MA,5)AS INT )),0 ");
        }
    }
}
