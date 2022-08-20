using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.DonViTinh;
namespace QuanLyKho.Controllers
{
    public class DonViTinh_Controller
    {
        private static DonViTinh_Controller instance;

        public static DonViTinh_Controller Instance
        {
            get => instance != null ? instance : instance = new DonViTinh_Controller();
            set => instance = value;
        }
        private DonViTinh_Controller() { }


        // lấy dữ liệu
        public DataTable LoadDVT()
        {
            return DonViTinh_Model.Instance.LoadDVT();
        }

        // thêm mới đơn vị tính
        public int Insert_DonViTinh(string ma, string ten)
        {
            return DonViTinh_Model.Instance.InsertDonViTinh(ma,ten);
        }

        // cập nhật đơn vị tính
        public int Update_DonViTinh(int id, string ma, string ten)
        {
            return DonViTinh_Model.Instance.UpdateDonViTinh(id, ma,ten);
        }

        // xóa đơn vị tính
        public int Delete_DonVitinh(int id)
        {
            return DonViTinh_Model.Instance.DeleteDonViTinh(id);
        }

        /// <summary>
        /// kiểm tra don vi tinh da ton tai trong sp hay chua
        /// </summary>
        /// <param name="idDonViTinh"></param>
        /// <returns></returns>
        public int ChechIssetDVTInSanPham(int idDonViTinh)
        {
            int ret = 0;
            DataTable dt = DonViTinh_Model.Instance.ChechIssetDVTISanPham(idDonViTinh);
            if (dt.Rows.Count > 0) ret = dt.Rows.Count;
            return ret;
        }
    }
}
