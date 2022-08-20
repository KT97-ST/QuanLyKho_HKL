using QuanLyKho.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Models.NhaCungCap
{
    public class ClsM_NhaCungCap
    {
        private static ClsM_NhaCungCap instance;

        public static ClsM_NhaCungCap Instance
        {
            get => instance != null ? instance : instance = new ClsM_NhaCungCap();
            set => instance = value;
        }
        private ClsM_NhaCungCap() { }

        // load nhà cung cap
        public DataTable LoadNhaCungCap()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_NhaCungCap");

            return data;
        }

        // insert nhà cung cấp
        public int InsertNhaCungCap(string ma, string ten, string sdt, string diaChi, string taiKhoanATM, string maSoThue)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_NhaCungCap @NHACUNGCAP_MA , @NHACUNGCAP_TEN , @NHACUNGCAP_SDT , @NHACUNGCAP_DIACHI , @NHACUNGCAP_TK_ATM , @NHACUNGCAP_MASOTHUE", new object[] { ma, ten, sdt, diaChi, taiKhoanATM, maSoThue });
        }

        // Cập nhật nhà cung cấp
        public int UpdateNhaCungCap(int id, string ma, string ten, string sdt, string diaChi, string taiKhoanATM, string maSoThue)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_NhaCungCap @NHACUNGCAP_ID , @NHACUNGCAP_MA , @NHACUNGCAP_TEN , @NHACUNGCAP_SDT , @NHACUNGCAP_DIACHI , @NHACUNGCAP_TK_ATM , @NHACUNGCAP_MASOTHUE", new object[] { id, ma, ten, sdt, diaChi, taiKhoanATM, maSoThue });
        }

        // Xóa loại sản phẩm
        public int DeleteNhaCungCap(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delele_NhaCungCap @NHACUNGCAP_ID", new object[] { id });
        }

        public DataTable CheckIsset_NhaCungCapInHoaDonNhap(int idNhaCungCap)
        {
            return DataProvider_Controller.Instance.ExecuteQuery("ChechIsset_NhaCungCapInPhieuNhap @NHACUNGCAP_ID", new object[] { idNhaCungCap });
        }
    }
}
