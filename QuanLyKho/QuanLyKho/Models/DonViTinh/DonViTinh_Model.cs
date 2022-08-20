using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.DonViTinh
{
    public class DonViTinh_Model
    {
        private static DonViTinh_Model instance;

        public static DonViTinh_Model Instance
        {
            get => instance != null ? instance : instance = new DonViTinh_Model();
            set => instance = value;
        }
        private DonViTinh_Model() { }

        // load don vi tih  s
        public DataTable LoadDVT()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_DonViTinh");

            return data;
        }

        // insert don vi tinh 
        public int InsertDonViTinh(string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_DonViTinh @DONVITINH_MA , @DONVITINH_TEN", new object[] { ma, ten });
        }

        // Cập nhật đon vị tính
        public int UpdateDonViTinh(int id, string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_DonViTinh @DONVITINH_ID , @DONVITINH_MA , @DONVITINH_TEN", new object[] { id, ma, ten });
        }

        // Xóa đơn vị tính
        public int DeleteDonViTinh(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delele_DonViTinh @DONVITINH_ID", new object[] { id });
        }

        /// <summary>
        /// Kiểm tra đơn vi tính tồn tại trong sp hay chưa
        /// </summary>
        /// <param name="idDonViTinh"></param>
        /// <returns></returns>
        public DataTable ChechIssetDVTISanPham(int idDonViTinh)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("ChechIsset_DVTInSanPham @DONVITINH_ID", new object[] { idDonViTinh });
        }
    }
}
