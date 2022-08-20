using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyKho.Controllers.DungChung
{
    class ClsCheckSave
    {
        private static ClsCheckSave instance;

        public static ClsCheckSave Instance
        {
            get => instance != null ? instance : instance = new ClsCheckSave();
            set => instance = value;
        }
        private ClsCheckSave() { }



        /// <summary>
        /// Kiểm tra có thay các dòng trong datatable hay không không
        /// </summary>
        /// <param name="dataCheck"></param>
        /// <returns></returns>
        public bool CheckModified(DataTable dataCheck)
        {
            int ret = 0;
            if(dataCheck != null)
            {
                foreach (DataRow dr in dataCheck.Rows)
                {
                    if (dr.RowState == DataRowState.Unchanged) continue;
                    ret++;
                }
            }
            if (ret > 0) return true;

            return false;
        }
    }
}
