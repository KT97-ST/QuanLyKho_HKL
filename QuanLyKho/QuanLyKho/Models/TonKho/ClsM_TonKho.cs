using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Models.TonKho
{
    class ClsM_TonKho
    {
        DataTable dt;
        public DataTable GetTonKho()
        {


            dt = new DataTable();
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {
               

                SqlCommand cmd = new SqlCommand("TONKHO_SELECT", conn);
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
        public string GetTonKhoByIdSP(string idsanpham)
        {


            string soLuong = "";
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();

            try
            {
               
                SqlCommand cmd = new SqlCommand("TONKHO_SELECT_BY_ID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idSanPham", idsanpham);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Parameters.Add("@soLuong", SqlDbType.NVarChar, 50);
                cmd.Parameters["@soLuong"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                soLuong = Convert.ToString(cmd.Parameters["@soLuong"].Value);

                return soLuong;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());
            }
            conn.Close();
            return soLuong;
        }
    }
}
