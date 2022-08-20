using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.ClsM_DanhMuc;
using System.Data;


namespace QuanLyKho.Controllers.ClsC_DanhMuc
{
    class ClsC_DanhMuc
    {
        ClsM_DanhMuc clsM_DanhMuc = new ClsM_DanhMuc();
        private static ClsC_DanhMuc instance;

        public static ClsC_DanhMuc Instance
        {
            get => instance != null ? instance : instance = new ClsC_DanhMuc();
            set => instance = value;
        }
        private ClsC_DanhMuc() { }

        
        public DataTable GetDataDanhMuc( string tableName)
        {
            
            return clsM_DanhMuc.GetDataDanhMuc(tableName);
        }
        public DataTable GetDataDanhMuc(string tableName,string condition)
        {

            return clsM_DanhMuc.GetDataDanhMuc(tableName, condition);
        }
    }
}
