using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using QuanLyKho.Models.Connect;
using System.Windows.Forms;

namespace QuanLyKho.Controllers
{
    class DataProvider_Controller
    {
        /// <summary>
        /// Design Patern Singleton s
        /// Tham khảo:https://www.howkteam.vn/course/lap-trinh-phan-mem-quan-ly-quan-cafe-voi-c-winform/gioi-thieu-design-patern-singleton-phan-mem-quan-ly-quan-cafe-voi-c-winform-1241
        /// </summary>
        private static DataProvider_Controller instance; // Ctrl + R + E

        public static DataProvider_Controller Instance
        {
            get { if (instance == null) instance = new DataProvider_Controller(); return DataProvider_Controller.instance; }
            private set { DataProvider_Controller.instance = value; }
        }
        private DataProvider_Controller() { }

        // trả về dữ liệu truy vấn dc, dùng để trả về danh sách phần tử trong 1 bảng
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = ClsDB_Utils.GetDBConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return data;
        }

        // trả về số dòng thực thi thành công, dùng để thêm và cập nhật
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = ClsDB_Utils.GetDBConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }

        // TRả về o đầu tiên của bảng kết quả
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            try
            {
                using (SqlConnection connection = ClsDB_Utils.GetDBConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
    }
}
