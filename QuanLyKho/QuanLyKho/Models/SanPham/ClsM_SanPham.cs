using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.SanPham
{
    public class ClsM_SanPham
    {
        private static ClsM_SanPham instance;

        public static ClsM_SanPham Instance
        {
            get => instance != null ? instance : instance = new ClsM_SanPham();
            set => instance = value;
        }
        private ClsM_SanPham() { }

        // get sản phẩm
        public DataTable GetSanPham()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_SanPham");
            return data;
        }

        // thêm mới sản phẩm
        public int InsertSanPham(string maSanPham, string tenSanPham, string loaiSanPhamId, string donViTinhId)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_SanPham @SANPHAM_MA , @SANPHAM_TEN , @LOAISANPHAM_ID , @DONVITINH_ID", new object[] { maSanPham, tenSanPham, loaiSanPhamId, donViTinhId });
        }

        // cập nhật sản phẩm
        public int UpdateSanPham(int idSanPham, string maSanPham, string tenSanPham, string loaiSanPhamId, string donViTinhId)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_SanPham @SANPHAM_ID , @SANPHAM_MA , @SANPHAM_TEN , @LOAISANPHAM_ID , @DONVITINH_ID", new object[] { idSanPham, maSanPham, tenSanPham, loaiSanPhamId, donViTinhId });
        }

        /// <summary>
        /// kiểm tra sản phẩm có trong hóa đơn nhập
        /// </summary>
        /// <returns></returns>
        public DataTable CheckSanPhamInHDN(int sanPhamID)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("KTSanPhamTrongHoaDonNhap @SANPHAM_ID", new object[] { sanPhamID });
        }

        // xóa sản phẩm
        public int DeleteSanPham(int idSanPham)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delete_SanPham @SANPHAM_ID", new object[] { idSanPham });
        }


        /// <summary>
        /// kiểm tra mã sản phẩm đã tồn tại hay chưa
        /// </summary>
        /// <param name="sanPhamId"></param>
        /// <returns></returns>
        public object CheckIssetSanPham(string maSP)
        {
            return DataProvider_Controller.Instance.ExecuteScalar("CheckIsset_SanPham @SANPHAM_MA", new object[] { maSP });
        }
    }
}
