using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;
using System.Data;

namespace QuanLyKho.Models.ClsM_DanhMuc
{
    class ClsM_DanhMuc
    {
        DataTable dt;
        public DataTable GetDataDanhMuc(string tableName)
        {
            dt = new DataTable();
            string str = "SELECT * FROM "+tableName;
            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();

            try
            {

               

                SqlCommand cmd = new SqlCommand(str, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable GetDataDanhMuc(string tableName, string condition)
        {
            dt = new DataTable();
            string str = "SELECT * FROM " + tableName+" "+ condition;

            SqlConnection conn = ClsDB_Utils.GetDBConnection();
            conn.Open();
            try
            {


                SqlCommand cmd = new SqlCommand(str, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
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
