using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Models.HoaDonXuat
{
    class ClsM_HoaDonXuat
    {
        DataTable dt;
        public DataTable GetDanhSachSanPham(DateTime ngayLap,int xuatdaily)
        {


            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
               

                SqlCommand cmd = new SqlCommand("SAMPHAM_SELECT_SANPHAM_HOADONXUAT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ngayLapHD", ngayLap);
                cmd.Parameters.AddWithValue("@xuatDaiLy", xuatdaily);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return dt;
            }
            conn.Close();
            return dt;
        }
        public DataTable GetDanhSachHoaDon(int xuatdaily)
        {
            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
                

                SqlCommand cmd = new SqlCommand("HOADONXUAT_SELECT_ALL", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@xuatDaiLy", xuatdaily);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
            }
            conn.Close();
            return dt;
        }
        public DataTable GetHoaDonById(string idHoaDon)
        {
            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
                

                SqlCommand cmd = new SqlCommand("HOADONXUAT_SELECT_BY_ID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
            }
            conn.Close();
            return dt;
        }
        public DataTable GetHoaDonChiTietById(string idHoaDon)
        {
            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
                

                SqlCommand cmd = new SqlCommand("HOADONXUAT_CT_SELECT_BY_ID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoaDonXuatId", idHoaDon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
            }
            conn.Close();
            return dt;
        }
        public String InsertHoaDonXuat(string maHoaDon, string soLo, string idKH, string idNguoiNhap, DateTime ngayNhap, string tongTien, string VAT, string tongTienSauThue, string soTienDaThanhToan, string HinhThucThanhToan,int xuatdaily)
        {
            string idHoaDonXuat = "";
            SqlConnection conn = ClsDB_Utils.GetDBConnection();

            conn.Open();
            try
            {
               
                //ngay = String.Format(ngayNhap.ToString(),"0:MM-dd-yyyy HH:mm:ss");

                SqlCommand cmd = new SqlCommand("HOADON_XUAT_INSERT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                cmd.Parameters.AddWithValue("@soLo", soLo);
                cmd.Parameters.AddWithValue("@idKhachHang", idKH);
                cmd.Parameters.AddWithValue("@idNguoiNhap", idNguoiNhap);
                cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@VAT", VAT);
                cmd.Parameters.AddWithValue("@tongTienSauThue", tongTienSauThue);
                cmd.Parameters.AddWithValue("@soTienDaThanhToan", soTienDaThanhToan);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", Convert.ToString(HinhThucThanhToan));
                cmd.Parameters.AddWithValue("@xuatDaiLy", Convert.ToInt16(xuatdaily));//1 là đại lý, 0 hoặc null là bán lẻ



                cmd.Parameters.Add("@idHoaDonXuat", SqlDbType.VarChar, 50);
                cmd.Parameters["@idHoaDonXuat"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                idHoaDonXuat = Convert.ToString(cmd.Parameters["@idHoaDonXuat"].Value);

                return idHoaDonXuat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
            }
            conn.Close();
            return idHoaDonXuat;
        }
        public bool UpdateHoaDonXuat(string idHoaDon, string soLo, string idKH, string idNguoiNhap, string tongTien, string VAT, string tongTienSauThue,string soTienDaThanhToan, string HinhThucThanhToan)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
               
                SqlCommand cmd = new SqlCommand("HOADONXUAT_UPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonXuat", idHoaDon);
                cmd.Parameters.AddWithValue("@soLo", soLo);
                cmd.Parameters.AddWithValue("@idKhachHang", idKH);
                cmd.Parameters.AddWithValue("@idNguoiNhap", idNguoiNhap);

                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@VAT", VAT);
                cmd.Parameters.AddWithValue("@tongTienSauThue", tongTienSauThue);
                cmd.Parameters.AddWithValue("@soTienDaThanhToan", soTienDaThanhToan);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucThanhToan);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return false;
            }
            
           

        }
        public bool InsertHoaDonXuat_CT(string idHoaDonXuat, string idSanPham, string soLuong, string giaBan, string thanhTien, DateTime ngayLap)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();

            conn.Open();
            try
            {
            
            SqlCommand cmd = new SqlCommand("HOADONXUAT_CT_INSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idHoaDonXuat", idHoaDonXuat);
            cmd.Parameters.AddWithValue("@idSanPham", idSanPham);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            cmd.Parameters.AddWithValue("@giaSanPham", giaBan);
            cmd.Parameters.AddWithValue("@thanhTien", thanhTien.ToString());
            cmd.Parameters.AddWithValue("@ngayLap", ngayLap);



            cmd.ExecuteNonQuery();
                conn.Close();

                return true;
              }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return false;
            }
         
        }
        public bool UpdateHoaDonXuat_CT(string idHoaDon, string idHoaDonXuatCT, string idSanPham, string soLuong, string thanhTien)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {

               
                SqlCommand cmd = new SqlCommand("HOADONXUAT_CT_UPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonXuat", idHoaDon);
                cmd.Parameters.AddWithValue("@idHoaDonXuatCT", idHoaDonXuatCT);
                cmd.Parameters.AddWithValue("@idSanPham", idSanPham);
                cmd.Parameters.AddWithValue("@soLuong", soLuong != "" ? soLuong : 0.ToString());
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);


                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
             catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return false;
            }
           
        }
    }
}
