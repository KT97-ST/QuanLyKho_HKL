using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKho.Views.BaoCao
{
    public partial class rptCongNo : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCongNo()
        {
            InitializeComponent();
        }

        public void BinData()
        {
            celllSTT.DataBindings.Add("Text", DataSource, "STT");
            cellMaKH.DataBindings.Add("Text", DataSource, "KHACHHANG_MA");
            cellTenKH.DataBindings.Add("Text", DataSource, "KHACHHANG_TEN");
            cellSDT.DataBindings.Add("Text", DataSource, "KHACHHANG_SDT");
            cellDiaChi.DataBindings.Add("Text", DataSource, "KHACHHANG_DIACHI");
            cellSoTaiKhoan.DataBindings.Add("Text", DataSource, "KHACHHANG_TK_ATM");
            cellMaSoThue.DataBindings.Add("Text", DataSource, "KHACHHANG_MASOTHUE");
            cellSoTienNo.DataBindings.Add("Text", DataSource, "SOTIENNO");
        }
    }
}
