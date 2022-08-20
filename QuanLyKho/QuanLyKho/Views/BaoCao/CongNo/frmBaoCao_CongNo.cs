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

namespace QuanLyKho.Views.BaoCao.CongNo
{
    public partial class frmBaoCao_CongNo : DevExpress.XtraEditors.XtraForm
    {
        DataTable _dtCongNo = null;
        public frmBaoCao_CongNo(DataTable dtCongNo)
        {
            InitializeComponent();
            _dtCongNo = dtCongNo;
        }

        private void frmBaoCao_CongNo_Load(object sender, EventArgs e)
        {
           

            rptCongNo rptCongNo = new rptCongNo();
            rptCongNo.DataSource = _dtCongNo;
            rptCongNo.BinData();
            documentViewer1.PrintingSystem = rptCongNo.PrintingSystem;
            rptCongNo.CreateDocument();
        }
    }
}