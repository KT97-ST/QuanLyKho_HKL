using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QuanLyKho.Models.Connect
{
    class ClsDB_SERVER_Util
    {
        public string a = "";
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
           
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(connString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return conn;
        }
    }
}
