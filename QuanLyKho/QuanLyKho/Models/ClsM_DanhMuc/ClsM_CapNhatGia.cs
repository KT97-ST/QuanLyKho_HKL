using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Models.ClsM_DanhMuc
{
    class ClsM_CapNhatGia
    {


        DataTable dt;
        public DataTable GetThongTinGia()
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();


            dt = new DataTable();
            try
            {
               
                SqlCommand cmd = new SqlCommand("GIASANPHAM_SELECT", conn);
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
        public void InsertGiaMoi(string idsanpham,string idloaigia, string giatien, DateTime thoigianBD)
        {
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();


            try
            {
                

                SqlCommand cmd = new SqlCommand("GIASANPHAM_INSERT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@idSanPham", idsanpham);
                cmd.Parameters.AddWithValue("@idLoaiGia", idloaigia);
                cmd.Parameters.AddWithValue("@giaTien", giatien);
                cmd.Parameters.AddWithValue("@time_BD", thoigianBD);



                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
             
            }
            conn.Close();
        }
     }
    }

