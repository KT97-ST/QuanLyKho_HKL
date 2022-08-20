using QuanLyKho.Models.DonViTinh;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Controllers.C_DonViTinh
{
    public class ClsC_DonViTinh
    {
        private static ClsC_DonViTinh instance;

        public static ClsC_DonViTinh Instance
        {
            get => instance != null ? instance : instance = new ClsC_DonViTinh();
            set => instance = value;
        }
        private ClsC_DonViTinh() { }


        // lấy dữ liệu
        public DataTable LoadDVT()
        {
            return DonViTinh_Model.Instance.LoadDVT();
        }

        // thêm mới đơn vị tính
        public int Insert_DonViTinh(string ma, string ten)
        {
            return DonViTinh_Model.Instance.InsertDonViTinh(ma, ten);
        }

        // cập nhật đơn vị tính
        public int Update_DonViTinh(int id, string ma, string ten)
        {
            return DonViTinh_Model.Instance.UpdateDonViTinh(id, ma, ten);
        }

        // xóa đơn vị tính
        public int Delete_DonVitinh(int id)
        {
            return DonViTinh_Model.Instance.DeleteDonViTinh(id);
        }
    }
}
