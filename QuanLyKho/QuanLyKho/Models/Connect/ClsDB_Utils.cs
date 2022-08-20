using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyKho.Views.Connection;
using QuanLyKho.Controllers.DungChung;

namespace QuanLyKho.Models.Connect
{
    class ClsDB_Utils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @""+Properties.Settings.Default.datasource;

            string database = Properties.Settings.Default.database;
            string username = Properties.Settings.Default.username;
            string password = Cls_Encode_Decode.Instance.DecodeString(Properties.Settings.Default.password);

            return ClsDB_SERVER_Util.GetDBConnection(datasource, database, username, password);
        }
    }
}
