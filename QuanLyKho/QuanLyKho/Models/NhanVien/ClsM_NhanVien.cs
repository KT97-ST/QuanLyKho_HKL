using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Controllers;
using QuanLyKho.Controllers.DungChung;

namespace QuanLyKho.Models.NhanVien
{
    public class ClsM_NhanVien
    {
        private static ClsM_NhanVien instance;

        public static ClsM_NhanVien Instance
        {
            get => instance != null ? instance : instance = new ClsM_NhanVien();
            set => instance = value;
        }
        private ClsM_NhanVien() { }


        public DataTable GetNhanVien()
        {
            DataTable data = DataProvider_Controller.Instance.ExecuteQuery("GET_NhanVien");
            return data;
        }

        // insert nhân viên
        public int InsertNhanVien(string ma, string ten, string sdt, string diaChi, string userName, string passWord)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Insert_NhanVien @NHANVIEN_MA , @NHANVIEN_TEN , @NHANVIEN_SDT , @NHANVIEN_DIACHI , @NHANVIEN_USER , @NHANVIEN_PASSWORD", new object[] { ma, ten, sdt, diaChi, userName, passWord });
        }

        // Cập nhật nhân viên
        public int UpdateNhanVien(int id, string ma, string ten, string sdt, string diaChi, string userName, string passWord)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Update_NhanVien @NHANVIEN_ID , @NHANVIEN_MA , @NHANVIEN_TEN , @NHANVIEN_SDT , @NHANVIEN_DIACHI , @NHANVIEN_USER , @NHANVIEN_PASSWORD", new object[] {id, ma, ten, sdt, diaChi, userName, passWord });
        }

        // Xóa loại nhân viên
        public int DeleteNhanVien(int id)
        {
            return DataProvider_Controller.Instance.ExecuteNonQuery("Delete_NhanVien @NHANVIEN_ID", new object[] { id });
        }
    }
}
