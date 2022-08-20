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
using QuanLyKho.Controllers.KhachHang;

namespace QuanLyKho.Views.CongNo
{
    public partial class DlgThanhToanCongNo : DevExpress.XtraEditors.XtraForm
    {
        DataRow _DrKhachHang;

        public DlgThanhToanCongNo(DataRow drkhachhang)
        {
            InitializeComponent();

            _DrKhachHang = drkhachhang;
        }

        // load thông tin khách hàng
        private void LoadKhachHang()
        {
            try
            {
                LoadDsHoaDonById(_DrKhachHang["KHACHHANG_ID"].ToString());

                cbMaKhachHang.Properties.DataSource = ClsC_KhachHang.Instance.KhachHangCoHoaDonXuat();
                cbMaKhachHang.Properties.DisplayMember = "KHACHHANG_MA";
                cbMaKhachHang.Properties.ValueMember = "KHACHHANG_ID";
                cbMaKhachHang.EditValue = Convert.ToInt64(_DrKhachHang["KHACHHANG_ID"].ToString());

                txtTenKH.EditValue = _DrKhachHang["KHACHHANG_TEN"].ToString();
                txtSDT.EditValue = _DrKhachHang["KHACHHANG_SDT"].ToString();
                txtTaiKhoanATM.EditValue = _DrKhachHang["KHACHHANG_TK_ATM"].ToString();
                txtMaSoThue.EditValue = _DrKhachHang["KHACHHANG_MASOTHUE"].ToString();
                txtTongNo.EditValue = _DrKhachHang["SOTIENNO"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        // lấy thông tin công nợ theo id
        private void LoadCongNoByIdKH(string idKH)
        {
            DataTable dt= ClsC_CongNo.Instance.GetCongNoByIdKH(idKH);
            if(dt.Rows.Count == 1)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    txtTenKH.EditValue = dr["KHACHHANG_TEN"].ToString();
                    txtSDT.EditValue = dr["KHACHHANG_SDT"].ToString();
                    txtTaiKhoanATM.EditValue = dr["KHACHHANG_TK_ATM"].ToString();
                    txtMaSoThue.EditValue = dr["KHACHHANG_MASOTHUE"].ToString();
                    txtTongNo.EditValue = dr["SOTIENNO"];
                }
            }
        }

        /// <summary>
        /// thấy danh sách hoa đơn của khách hàng theo id
        /// </summary>
        /// <param name="idKh">id khách hàng</param>
        private void LoadDsHoaDonById(string idKh)
        {
            DataTable dataTable = ClsC_CongNo.Instance.GetHoaDonXuatByIdKH(idKh);
            gcDsHoaDon.DataSource = dataTable;
        }

        private void DlgThanhToanCongNo_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            CleartextBox();
        }

        private void cbMaKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            CleartextBox();
            LoadCongNoByIdKH(cbMaKhachHang.EditValue.ToString());

            LoadDsHoaDonById(cbMaKhachHang.EditValue.ToString());
        }


        private int _HoaDonXuat_ID =0;
        private Decimal _SoTienDaThanhToan = 0;
        private Decimal _SoTienConNo =0;
        private void gvDsHoaDon_DoubleClick(object sender, EventArgs e)
        {
            txtTienThanhToan.ReadOnly = false;
            btnThanhToanCongNo.Enabled = true;
            btnHuy.Enabled = true;
            chkThanhToanHet.Enabled = true;
            btnXemCTHoaDon.Enabled = true;


            // lấy thông tin chi tiết hóa đơn xuất
            try
            {
                DataRow dr = gvDsHoaDon.GetFocusedDataRow();
                _HoaDonXuat_ID = Convert.ToInt32(dr["HOADONXUAT_ID"].ToString());
                
               DataTable dtHDX = ClsC_CongNo.Instance.GetHoDonXuatByIdHD(_HoaDonXuat_ID.ToString());
               
                if (dtHDX.Rows.Count == 1)
                {
                    foreach (DataRow drHDX in dtHDX.Rows)
                    {
                        txtTongTien.EditValue = drHDX["HOADONXUAT_TONGTIEN"];
                        txtThue.EditValue = drHDX["HOADONXUAT_VAT"].ToString();
                        txtTongTienSauThue.EditValue = drHDX["HOADONXUAT_TONGTIEN_SAUTHUE"];

                        txtSoTienDaThanhToan.EditValue = drHDX["HOADONXUAT_SOTIEN_DATHANHTOAN"];
                        _SoTienDaThanhToan = decimal.Parse(txtSoTienDaThanhToan.EditValue.ToString());

                        txtNgayLap.EditValue = drHDX["HOADONXUAT_NGAYLAP"].ToString();
                        txtHinhThucThanhToan.EditValue = drHDX["HTHUC_THANHTOAN"].ToString();
                        txtTienConNo.EditValue = drHDX["CONNO"];

                        _SoTienConNo = decimal.Parse(txtTienConNo.EditValue.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThanhToanCongNo_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có chắc chắn thanh toán ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(chkThanhToanHet.Checked == false)
                {
                    if (txtTienThanhToan.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập số tiền cần thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // tiền thanh toán nhập vào
                Decimal tienNhapThanhToan;
                // nếu checked thanh toán hết thì số tiền thanh toán nhập vào là số tiền còn nợ
                if(chkThanhToanHet.Checked == true)
                {
                    tienNhapThanhToan  = decimal.Parse(txtTienConNo.EditValue.ToString());
                }
                else
                {
                    tienNhapThanhToan = decimal.Parse(txtTienThanhToan.EditValue.ToString());
                }

                if (tienNhapThanhToan > _SoTienConNo)
                {
                    MessageBox.Show("Số tiền thanh toán không thể lớn hơn số tiền còn nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Decimal soTienThanhToanCN = tienNhapThanhToan + _SoTienDaThanhToan;

                if (ClsC_CongNo.Instance.ThanhToanCongNo_HDX(_HoaDonXuat_ID.ToString(), soTienThanhToanCN.ToString()) > 0)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string idKhachHang = cbMaKhachHang.EditValue.ToString();
                    // load lại danh sách hóa đơn sau khi thanh toan;
                    LoadDsHoaDonById(idKhachHang);

                    CleartextBox();
                    this.Refresh();
                }
            }
           
        }

        private void CleartextBox()
        {
            txtTongTien.EditValue = "";
            txtHinhThucThanhToan.EditValue = "";
          //  txtTongNo.EditValue = "";
            txtThue.EditValue = "";
            txtTongTienSauThue.EditValue = "";
            txtSoTienDaThanhToan.EditValue = "";
            txtNgayLap.EditValue = null;
            txtTienConNo.EditValue = "";
            txtTienThanhToan.EditValue = "";
            txtTienThanhToan.ReadOnly = true;
            btnThanhToanCongNo.Enabled = false;
            btnHuy.Enabled = false;
            chkThanhToanHet.Checked = false;
            chkThanhToanHet.Enabled = false;
            btnXemCTHoaDon.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CleartextBox();
        }

        private void chkThanhToanHet_CheckedChanged(object sender, EventArgs e)
        {
            if(chkThanhToanHet.Checked == true)
            {
                txtTienThanhToan.Enabled = false;
            }
            else
            {
                txtTienThanhToan.Enabled = true;
            }
        }

        // xem chi tiết hóa đơn
        private void btnXemCTHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gvDsHoaDon.GetFocusedDataRow();
                int id = Convert.ToInt32(dr["HOADONXUAT_ID"].ToString());

                DlgChiTietHoaDon dlgChiTietHoaDon = new DlgChiTietHoaDon(id);
                dlgChiTietHoaDon.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}