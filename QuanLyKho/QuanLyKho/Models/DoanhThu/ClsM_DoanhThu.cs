using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Models.DoanhThu
{
    class ClsM_DoanhThu
    {
        DataTable dt;
        public DataTable GetThongTin(DateTime tungay,DateTime denngay)
        {

            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            dt = new DataTable();
            try
            {
               

                SqlCommand cmd = new SqlCommand("SANPHAM_THONGKE_NHAP_XUAT_THEOTHOIGIAN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
         
                cmd.Parameters.AddWithValue("@tuNgay", tungay);
                cmd.Parameters.AddWithValue("@denNgay", denngay);
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
    }
}
