using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.LoaiGia;

namespace QuanLyKho.Controllers.LoaiGia
{
    public class ClsC_LoaiGia
    {
        private static ClsC_LoaiGia instance;

        public static ClsC_LoaiGia Instance
        {
            get => instance != null ? instance : instance = new ClsC_LoaiGia();
            set => instance = value;
        }
        private ClsC_LoaiGia() { }

        // lấy dữ liệu - giá tiền - loại giá
        public DataTable LoadGiaTien_LoaiGia()
        {
            return ClsM_LoaiGia.Instance.LoadGiaTien_LoaiGia();
        }

        // thêm mới giá tiền - loại giá
        public int InsertGiaTien_LoaiGia(string ma, string ten)
        {
            return ClsM_LoaiGia.Instance.InsertGiaTien_LoaiGia(ma, ten);
        }

        // cập nhật giá tiền - loại giá
        public int UpdateGiaTien_LoaiGia(int id, string ma, string ten)
        {
            return ClsM_LoaiGia.Instance.UpdateGiaTien_LoaiGia(id, ma, ten);
        }

        // xóa giá tiền - loại giá
        public int DeleteGiaTien_LoaiGia(int id)
        {
            return ClsM_LoaiGia.Instance.DeleteGiaTien_LoaiGia(id);
        }

    }
}
