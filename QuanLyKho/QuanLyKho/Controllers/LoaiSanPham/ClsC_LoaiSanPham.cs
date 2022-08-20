using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.LoaiSanPham;


namespace QuanLyKho.Controllers.LoaiSanPham
{
    public class ClsC_LoaiSanPham
    {
        private static ClsC_LoaiSanPham instance;

        public static ClsC_LoaiSanPham Instance
        {
            get => instance != null ? instance : instance = new ClsC_LoaiSanPham();
            set => instance = value;
        }
        private ClsC_LoaiSanPham() { }


        // lấy dữ liệu
        public DataTable LoadLoaiSanPham()
        {
            return ClsM_LoaiSanPham.Instance.LoadLoaiSanPham();
        }

        // thêm mới loại sản phẩm
        public int InsertLoaiSanPham(string ma, string ten)
        {
            return ClsM_LoaiSanPham.Instance.InsertLoaiSanPham(ma, ten);
        }

        // cập nhật loại sản phẩm
        public int UpdateLoaiSanPham(int id, string ma, string ten)
        {
            return ClsM_LoaiSanPham.Instance.UpdateLoaiSanPham(id, ma, ten);
        }

        /// <summary>
        /// kiểm tra loại sản phầm có trong bảng sản phẩm hay chưa
        /// </summary>
        /// <param name="idLoaiSP"></param>
        /// <returns></returns>
        public int CheckLoaiSPInSanPham(int idLoaiSP)
        {
            int ret = 0;
            DataTable dt = ClsM_LoaiSanPham.Instance.CheckLoaiSPInSanPham(idLoaiSP);
            if (dt.Rows.Count > 0) ret = dt.Rows.Count;
            return ret;
        }

            // xóa loại sản phẩm
            public int DeleteLoaiSanPham(int id)
        {
            return ClsM_LoaiSanPham.Instance.DeleteLoaiSanPham(id);
        }
    }
}
