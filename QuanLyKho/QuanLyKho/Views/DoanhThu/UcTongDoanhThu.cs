using QuanLyKho.Controllers.DoanhThu;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKho.Views.DoanhThu
{
    public partial class UcTongDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dtdoanhthu;
        public UcTongDoanhThu()
        {
            InitializeComponent();
        }

        private void UcTongDoanhThu_Load(object sender, EventArgs e)
        {
            dtdoanhthu = new DataTable();
        }
        private void DoanhThuLap(string tungay,string denngay)
        {
           
            dtdoanhthu.Clear();
            if (tungay != "" && denngay != "")
            {
               dtdoanhthu = ClsC_DoanhThu.Instance.GetThongTin(Convert.ToDateTime(tungay), Convert.ToDateTime(denngay));

                gcTongDoanhThu.DataSource = dtdoanhthu;
            }
           
            txtTongTienNhap.EditValue = gvTongDoanhThu.Columns["TTNHAP"].SummaryItem.SummaryValue.ToString();
            txtTongDoanhThu.EditValue = gvTongDoanhThu.Columns["TTXUAT"].SummaryItem.SummaryValue.ToString();
            txtTongCongNo.EditValue = gvTongDoanhThu.Columns["TONGCONGNO"].SummaryItem.SummaryValue.ToString();

        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            chkThangNay.CheckState = CheckState.Unchecked;
            chkToanBo.CheckState = CheckState.Unchecked;
            dtdoanhthu.Clear();
            txtTongTienNhap.EditValue = "";
            txtTongDoanhThu.EditValue = "";
            if (deTuNgay.Text!=""&& deDenNgay.Text != "")
            {
                DoanhThuLap(deTuNgay.EditValue.ToString(), deDenNgay.EditValue.ToString());
                gupCTong.Text = "Tổng thu chi (Từ: " + Convert.ToDateTime(deTuNgay.EditValue.ToString()).ToString("dd/MM/yyyy")+" đến: "+ Convert.ToDateTime(deDenNgay.EditValue.ToString()).ToString("dd/MM/yyyy") + ")";
            }
            
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public static DateTime FirstDayOfMonth( DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }
        public static DateTime LastDayOfMonth( DateTime dt)
        {
            return FirstDayOfMonth(dt).AddMonths(1).AddDays(-1);
        }
        private void ckeck_changed(int st)
        {
            if(st==1)
            {
                if (chkToanBo.CheckState == CheckState.Checked)//Nếu check toàn bộ
                {
                    deTuNgay.ResetText();
                    deDenNgay.ResetText();
                    chkThangNay.CheckState = CheckState.Unchecked;
                    DoanhThuLap("1900-01-01", "2100-01-01");
                    gupCTong.Text = "Tổng thu chi (Toàn bộ)";
                }
                else if (chkToanBo.CheckState == CheckState.Unchecked)
                {
                    

                }
                else if (chkThangNay.CheckState == CheckState.Checked)
                {
                   

                }
            } else if(st==2)
            {
                if (chkThangNay.CheckState == CheckState.Checked)//Nếu check toàn bộ
                {
                    
                    chkToanBo.CheckState = CheckState.Unchecked;
                    DoanhThuLap(Convert.ToDateTime(DateTime.Now).ToString("01/MM/yyyy"), LastDayOfMonth(Convert.ToDateTime(DateTime.Now)).ToString("dd/MM/yyyy"));
                    gupCTong.Text = "Tổng thu chi (Tháng "+ Convert.ToDateTime(DateTime.Now).ToString("MM/yyyy") + ")";
                }
                else if (chkThangNay.CheckState == CheckState.Unchecked)
                {
                    

                }
                else if (chkToanBo.CheckState == CheckState.Checked)
                {
                    

                }
            }
            
            
        }
        private void chkToanBo_CheckedChanged(object sender, EventArgs e)
        {
            ckeck_changed(1);
        }

        private void chkThangNay_CheckedChanged(object sender, EventArgs e)
        {
            ckeck_changed(2);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
