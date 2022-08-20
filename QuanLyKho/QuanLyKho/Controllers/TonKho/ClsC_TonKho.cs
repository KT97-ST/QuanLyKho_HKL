using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Models.TonKho;
using System.Data;

namespace QuanLyKho.Controllers.TonKho
{
    class ClsC_TonKho
    {
        ClsM_TonKho clsM_TonKho = new ClsM_TonKho();
        private static ClsC_TonKho instance;

        public static ClsC_TonKho Instance
        {
            get => instance != null ? instance : instance = new ClsC_TonKho();
            set => instance = value;
        }
        private ClsC_TonKho() { }

        public DataTable GetTonKho()
        {
            return clsM_TonKho.GetTonKho();
        }
        public string GetTonKhoByIdSP(string idsanpham)
        {
            return clsM_TonKho.GetTonKhoByIdSP(idsanpham);
        }
    }
}
