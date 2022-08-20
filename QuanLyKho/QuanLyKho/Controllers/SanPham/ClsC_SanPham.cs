using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.SanPham;
using System.Windows.Forms;

namespace QuanLyKho.Controllers.SanPham
{
    public class ClsC_SanPham
    {
        private static ClsC_SanPham instance;

        public static ClsC_SanPham Instance
        {
            get => instance != null ? instance : instance = new ClsC_SanPham();
            set => instance = value;
        }
        private ClsC_SanPham() { }

        // lấy dữ liệu sản phẩm
        public DataTable GetSanPham()
        {
            return ClsM_SanPham.Instance.GetSanPham();
        }

        // thêm mới nhà cung cấp
        public int InsertSanPham(string maSanPham, string tenSanPham, string loaiSanPhamId, string donViTinhId)
        {
            return ClsM_SanPham.Instance.InsertSanPham(maSanPham, tenSanPham, loaiSanPhamId, donViTinhId);
        }

        // cập nhật sản phẩm
        public int UpdateSanPham(int idSanPham, string maSanPham, string tenSanPham, string loaiSanPhamId, string donViTinhId)
        {
            return ClsM_SanPham.Instance.UpdateSanPham(idSanPham, maSanPham, tenSanPham, loaiSanPhamId, donViTinhId);
        }


        /// <summary>
        /// kiểm tra sản phẩm có trong hóa đơn nhập
        /// </summary>
        /// <returns></returns>
        public int CheckSanPhamInHDN(int sanPhamID)
        {
            int ret = 0;

            try
            {
                DataTable dt = ClsM_SanPham.Instance.CheckSanPhamInHDN(sanPhamID);
                if (dt.Rows.Count > 0) ret = dt.Rows.Count;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ret;
        }
        // xóa sản phẩm
        public int DeleteSanPham(int idSanPham)
        {
            return ClsM_SanPham.Instance.DeleteSanPham(idSanPham);
        }

        /// <summary>
        /// kiểm tra mã sản phẩm đã tồn tại hay chưa
        /// </summary>
        /// <param name="sanPhamId"></param>
        /// <returns></returns>
        public object CheckIssetSanPham(string maSP)
        {
            return ClsM_SanPham.Instance.CheckIssetSanPham(maSP);
        }
    }
}
