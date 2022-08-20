using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.NhaCungCap;

namespace QuanLyKho.Controllers.NhaCungCap
{
    public class ClsC_NhaCungCap
    {
        private static ClsC_NhaCungCap instance;

        public static ClsC_NhaCungCap Instance
        {
            get => instance != null ? instance : instance = new ClsC_NhaCungCap();
            set => instance = value;
        }
        private ClsC_NhaCungCap() { }


        // lấy dữ liệu nhà cung cấp
        public DataTable LoadNhaCungCap()
        {
            return ClsM_NhaCungCap.Instance.LoadNhaCungCap();
        }

        // thêm mới nhà cung cấp
        public int InsertNhaCungCap(string ma, string ten, string sdt, string diaChi ,string taiKhoanATM, string maSoThue)
        {
            return ClsM_NhaCungCap.Instance.InsertNhaCungCap(ma, ten, sdt, diaChi, taiKhoanATM, maSoThue);
        }

        // cập nhật nhà cung cap
        public int UpdateNhaCungCap(int id, string ma, string ten, string sdt, string diaChi, string taiKhoanATM, string maSoThue)
        {
            return ClsM_NhaCungCap.Instance.UpdateNhaCungCap(id, ma, ten, sdt, diaChi, taiKhoanATM, maSoThue);
        }

        // xóa nhà cung cap
        public int DeleteNhaCungCap(int id)
        {
            return ClsM_NhaCungCap.Instance.DeleteNhaCungCap(id);
        }

        /// <summary>
        /// Kiểm tra nha cung cap đã có trong hóa đơn nhập hay chưa
        /// </summary>
        /// <param name="idNhaCungCap"></param>
        /// <returns></returns>
        public int CheckIsset_NhaCungCapInHoaDonNhap(int idNhaCungCap)
        {
            int ret = 0;
            DataTable dt = ClsM_NhaCungCap.Instance.CheckIsset_NhaCungCapInHoaDonNhap(idNhaCungCap);
            if (dt.Rows.Count > 0) ret = dt.Rows.Count;
            return ret;
        }
    }
}
