using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Models.HoaDonNhap
{
    class ClsM_HoaDonNhap
    {
        DataTable dt;
        
        
        public DataTable GetDanhSachSanPham()
        {
            
          
            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
               

                SqlCommand cmd = new SqlCommand("SAMPHAM_SELECT_SANPHAM_HOADONNHAP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable GetDanhSachHoaDon()
        {
            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
                

                SqlCommand cmd = new SqlCommand("HOADONNHAP_SELECT_ALL", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
               

                SqlCommand cmd = new SqlCommand("HOADONNHAP_SELECT_BY_ID", conn);
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
                

                SqlCommand cmd = new SqlCommand("HOADONNHAP_CT_SELECT_BY_ID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hoaDonNhapId", idHoaDon);
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
        public String InsertHoaDonNhap(string maHoaDon, string soLo, string idNCC, string idNguoiNhap, DateTime ngayNhap, string tongTien ,string VAT, string tongTienSauThue, string HinhThucThanhToan)
        {
            string idHoaDonNhap = "";

            SqlConnection conn = ClsDB_Utils.GetDBConnection();

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("HOADON_NHAP_INSERT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHoaDon", maHoaDon);
                cmd.Parameters.AddWithValue("@soLo", soLo);
                cmd.Parameters.AddWithValue("@idNhaCungCap", idNCC);
                cmd.Parameters.AddWithValue("@idNguoiNhap", idNguoiNhap);
                cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@VAT", VAT);
                cmd.Parameters.AddWithValue("@tongTienSauThue", tongTienSauThue);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucThanhToan);


                cmd.Parameters.Add("@idHoaDonNhap", SqlDbType.VarChar, 50);
                cmd.Parameters["@idHoaDonNhap"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                idHoaDonNhap = Convert.ToString(cmd.Parameters["@idHoaDonNhap"].Value);
              
            }catch(Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                
            }

            conn.Close();
            return idHoaDonNhap;
        }
        public bool UpdateHoaDonNhap(string idHoaDon, string soLo, string idNCC, string idNguoiNhap, string tongTien, string VAT, string tongTienSauThue, string HinhThucThanhToan)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
               
                SqlCommand cmd = new SqlCommand("HOADONNHAP_UPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonNhap", idHoaDon);
                cmd.Parameters.AddWithValue("@soLo", soLo);
                cmd.Parameters.AddWithValue("@idNhaCungCap", idNCC);
                cmd.Parameters.AddWithValue("@idNguoiNhap", idNguoiNhap);

                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@VAT", VAT);
                cmd.Parameters.AddWithValue("@tongTienSauThue", tongTienSauThue);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucThanhToan);

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
        public bool InsertHoaDonNhap_CT(string idHoaDonNhap, string idSanPham,string soLuong ,string giaNhap, string thanhTien, DateTime ngayNhap)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();

            conn.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("HOADONNHAP_CT_INSERT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonNhap", idHoaDonNhap);
                cmd.Parameters.AddWithValue("@idSanPham", idSanPham);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@giaSanPham", giaNhap);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);

                cmd.Parameters.AddWithValue("@ngayLap", ngayNhap);



                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return false;
            }
            conn.Close();



        }
        public bool UpdateHoaDonNhap_CT(string idHoaDon, string idHoaDonNhapCT, string idSanPham, string soLuong, string giaNhap, string thanhTien, DateTime ngayNhap)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
              
                SqlCommand cmd = new SqlCommand("HOADONNHAP_CT_UPDATE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonNhap", idHoaDon);
                cmd.Parameters.AddWithValue("@idHoaDonNhapCT", idHoaDonNhapCT);
                cmd.Parameters.AddWithValue("@idSanPham", idSanPham);
                cmd.Parameters.AddWithValue("@soLuong", soLuong != "" ? soLuong : 0.ToString());
                cmd.Parameters.AddWithValue("@giaNhap", giaNhap);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                cmd.Parameters.AddWithValue("@ngayNhap ", ngayNhap);


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
        public void DeleteHoaDonNhapCT (string idHoaDonCT)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("HOADONNHAPCT_DELETE ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idHoaDonCT", idHoaDonCT);



                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
                return;
            }
            conn.Close();
        }
    }
}
