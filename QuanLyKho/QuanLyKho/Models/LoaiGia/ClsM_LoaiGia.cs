using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.LoaiGia
{
    public class ClsM_LoaiGia
    {
        private static ClsM_LoaiGia instance;

        public static ClsM_LoaiGia Instance
        {
            get => instance != null ? instance : instance = new ClsM_LoaiGia();
            set => instance = value;
        }
        private ClsM_LoaiGia() { }

        // load giá tiền - loại giá
        public DataTable LoadGiaTien_LoaiGia()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_GiaTien_LoaiGia");

            return data;
        }

        // insert Giá tiền - loại giá
        public int InsertGiaTien_LoaiGia(string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_GiaTien_LoaiGia @LOAIGIA_MA , @LOAIGIA_TEN", new object[] { ma, ten });
        }

        // Cập nhật giá tiền - loại giá
        public int UpdateGiaTien_LoaiGia(int id, string ma, string ten)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_GiaTien_LoaiGia @LOAIGIA_ID , @LOAIGIA_MA , @LOAIGIA_TEN", new object[] { id, ma, ten });
        }

        // Xóa Giá tiền - loại giá
        public int DeleteGiaTien_LoaiGia(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delele_GiaTien_LoaiGia @LOAIGIA_ID", new object[] { id });
        }
    }
}
