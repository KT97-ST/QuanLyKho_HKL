using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKho.Controllers.CongNo;

namespace QuanLyKho.Views.CongNo
{
    public partial class DlgChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        int _IdHoaDon = 0;
        public DlgChiTietHoaDon(int idHoaDon)
        {
            InitializeComponent();
            _IdHoaDon = idHoaDon;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DlgChiTietHoaDon_Load(object sender, EventArgs e)
        {
            gridC_HoaDonChiTiet.DataSource = ClsC_CongNo.Instance.GetHoaDonXuat_CTByIdHD(_IdHoaDon);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}