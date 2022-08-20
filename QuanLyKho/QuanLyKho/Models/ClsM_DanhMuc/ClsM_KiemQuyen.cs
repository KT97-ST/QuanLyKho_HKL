using QuanLyKho.Models.Connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Models.ClsM_DanhMuc
{
    class ClsM_KiemQuyen
    {
        public void KiemQuyentheoID(int idNV,string chucnang_ma ,out bool qThem,out bool qSua, out bool qXoa)
        {
            qThem = false;
            qSua = false;
            qXoa = false;

            SqlConnection conn = ClsDB_Utils.GetDBConnection();

            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("QUYEN_SELECT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idNV", idNV);
                cmd.Parameters.AddWithValue("@chunang_ma", chucnang_ma);
           

                cmd.Parameters.Add("@qthem", SqlDbType.Bit);
                cmd.Parameters["@qthem"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("@qsua", SqlDbType.Bit);
                cmd.Parameters["@qsua"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add("@qxoa", SqlDbType.Bit);
                cmd.Parameters["@qxoa"].Direction = ParameterDirection.Output;




                cmd.ExecuteNonQuery();
                qThem = Convert.ToBoolean(cmd.Parameters["@qthem"].Value);
                qSua = Convert.ToBoolean(cmd.Parameters["@qsua"].Value);
                qXoa = Convert.ToBoolean(cmd.Parameters["@qxoa"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống phát sinh lỗi" + ex.ToString());

            }

            conn.Close();


        }
    }
}
