using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.NhanVien;

namespace QuanLyKho.Controllers.NhanVien
{
    public class ClsC_NhanVien
    {
        private static ClsC_NhanVien instance;

        public static ClsC_NhanVien Instance
        {
            get => instance != null ? instance : instance = new ClsC_NhanVien();
            set => instance = value;
        }
        private ClsC_NhanVien() { }

        // lấy dữ liệu nhân viên
        public DataTable GetNhanVien()
        {
            return ClsM_NhanVien.Instance.GetNhanVien();
        }

        // thêm mới nhân viên
        public int InsertNhanVien(string maNV, string tenNV, string sdtNV, string diaChiNV, string userName, string passWord)
        {
            return ClsM_NhanVien.Instance.InsertNhanVien(maNV, tenNV, sdtNV, diaChiNV, userName, passWord);
        }

        // cập nhật nhân viên
        public int UpdateNhanVien(int idNV, string maNV, string tenNV, string sdtNV, string diaChiNV, string userName, string passWord)
        {
            return ClsM_NhanVien.Instance.UpdateNhanVien(idNV, maNV, tenNV, sdtNV, diaChiNV, userName, passWord);
        }

        // xóa nhân viên
        public int DeleteNhanVien(int idNV)
        {
            return ClsM_NhanVien.Instance.DeleteNhanVien(idNV);
        }
    }
}
