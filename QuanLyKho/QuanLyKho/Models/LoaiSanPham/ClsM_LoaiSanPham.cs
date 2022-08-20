using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.LoaiSanPham
{
    class ClsM_LoaiSanPham
    {
        private static ClsM_LoaiSanPham instance;

        public static ClsM_LoaiSanPham Instance
        {
            get => instance != null ? instance : instance = new ClsM_LoaiSanPham();
            set => instance = value;
        }
        private ClsM_LoaiSanPham() { }

        // load loại sản phẩm
        public DataTable LoadLoaiSanPham()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_LoaiSanPham");

            return data;
        }

        // insert loại sản pham 
        public int InsertLoaiSanPham(string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_LoaiSanPham @LOAISANPHAM_MA , @LOAISANPHAM_TEN", new object[] { ma, ten });
        }

        // Cập nhật loại sản phẩm
        public int UpdateLoaiSanPham(int id, string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_LoaiSanPham @LOAISANPHAM_ID , @LOAISANPHAM_MA , @LOAISANPHAM_TEN", new object[] { id, ma, ten });
        }

        /// <summary>
        /// kiểm tra loại sản phầm có trong bảng sản phẩm hay chưa
        /// </summary>
        /// <param name="idLoaiSP"></param>
        /// <returns></returns>
        public DataTable CheckLoaiSPInSanPham(int idLoaiSP)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("KTLoaiSPTrongSanPham @LOAISANPHAM_ID", new object[] { idLoaiSP});
        }

        // Xóa loại sản phẩm
        public int DeleteLoaiSanPham(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delele_LoaiSanPham @LOAISANPHAM_ID", new object[] { id });
        }
    }
}
