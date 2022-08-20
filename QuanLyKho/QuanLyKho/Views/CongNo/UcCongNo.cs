using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKho.Controllers.CongNo;
using QuanLyKho.Views.BaoCao.CongNo;

namespace QuanLyKho.Views.CongNo
{
    public partial class UcCongNo : DevExpress.XtraEditors.XtraUserControl
    {
        public UcCongNo()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ReadOnlyGrid(true);
        }

        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridCongNo.OptionsBehavior.ReadOnly = val;
        }


        // thoát
        private void Exit_CongNo(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UcCongNo_Load(object sender, EventArgs e)
        {
            gridControl_CongNo.DataSource = ClsC_CongNo.Instance.GetCongNo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            gridControl_CongNo.DataSource = ClsC_CongNo.Instance.GetCongNo();
        }

        // thanh toán
        private void btnThanhToanCN_Click(object sender, EventArgs e)
        {
            DataRow dr = gridCongNo.GetFocusedDataRow();
            if (dr != null)
            {
                DlgThanhToanCongNo dlgThanhToan = new DlgThanhToanCongNo(dr);
                dlgThanhToan.ShowDialog();
                gridControl_CongNo.DataSource = ClsC_CongNo.Instance.GetCongNo();
            }
        }

        //private void btnXemBaoCao_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmBaoCao_CongNo frmBaoCao = new frmBaoCao_CongNo(gridControl_CongNo.DataSource as DataTable);
        //        frmBaoCao.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Có lỗi xảy ra \n" + ex.ToString());
        //    }
            
        //}
    }
}
