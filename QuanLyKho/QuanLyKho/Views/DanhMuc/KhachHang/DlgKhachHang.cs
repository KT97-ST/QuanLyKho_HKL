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
using QuanLyKho.Controllers.KhachHang;
using System.Text.RegularExpressions;

namespace QuanLyKho.Views.DanhMuc.KhachHang
{
    public partial class DlgKhachHang : DevExpress.XtraEditors.XtraForm
    {
        /// mode 1 là thêm mới, 2 là cập nhật
        /// </summary>
        private int _Mode = 0;
        private DataRow _DataRow;
        private int _ID_KhachHang;

        public DlgKhachHang(int mode)
        {
            InitializeComponent();
            _Mode = mode;
        }

        public DlgKhachHang(int mode, DataRow dr)
        {
            InitializeComponent();
            _DataRow = dr;
            _Mode = mode;
        }

        // Hàm khởi tạo
        private void Init()
        {

            this.ucThemHoacCapNhat1.BtnAddOrUpdateClick += new System.EventHandler(AddNewOrUpdate);
            this.ucThemHoacCapNhat1.BtnCancelClick += new System.EventHandler(Thoat);
            // new
            if (_Mode == 1)
            {
                ucThemHoacCapNhat1.setNameBtn("Thêm");
                this.groupThongTinKH.Text = "Thêm mới khách hàng";

            }

            if (_Mode == 2)
            {
                ucThemHoacCapNhat1.setNameBtn("Cập nhật");
                this.groupThongTinKH.Text = "Cập nhật thông tin khách hàng";
            }
        }

        // có phải là số hay không
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }


        #region hàm thêm, cập nhật, thoát

        // thêm, cập nhật
        private void AddNewOrUpdate(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = txtMaKH.EditValue.ToString();
            string tenKH = txtTenKH.EditValue.ToString();

            string sdtKH = "";
            if (txtSDTKH.Text.Trim() != "")
            {
                sdtKH = txtSDTKH.EditValue.ToString();
                if(sdtKH.Length > 11)
                {
                    MessageBox.Show("Số điện thoại không được dài quá 11 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(IsNumber(sdtKH.Trim()) == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string diaChiKH = "";
            if (txtDiaChiKH.Text != "") diaChiKH = txtDiaChiKH.EditValue.ToString();

            string taiKhoanATM = "";
            if (txtTaiKhoanATM.Text.Trim() != "")
            {
                taiKhoanATM = txtTaiKhoanATM.EditValue.ToString();
                if (IsNumber(taiKhoanATM.Trim()) == false)
                {
                    MessageBox.Show("Số tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string maSoThueKH = "";
            if (txtMaSoThue.Text.Trim() != "") maSoThueKH = txtMaSoThue.EditValue.ToString();
            

            if (_Mode == 1)
            {
                if(ClsC_KhachHang.Instance.CheckIssetKhacHang(maKH) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ClsC_KhachHang.Instance.InsertKhachHng(maKH, tenKH, sdtKH.Trim(), diaChiKH, taiKhoanATM.Trim(), maSoThueKH) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            if (_Mode == 2)
            {

                // kiểm tra có trùng mã hay không
                DataTable dataTable = ClsC_KhachHang.Instance.GetKhachHang();
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        if (dr == null) continue;
                        int idKHtmp = Convert.ToInt32(dr["KHACHHANG_ID"].ToString());
                        if (idKHtmp != _ID_KhachHang && dr["KHACHHANG_MA"].ToString() == maKH)
                        {
                            MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (ClsC_KhachHang.Instance.UpdateKhachHang(_ID_KhachHang, maKH, tenKH, sdtKH.Trim(), diaChiKH, taiKhoanATM.Trim(), maSoThueKH) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void DlgKhachHang_Load(object sender, EventArgs e)
        {
            Init();

            // Cập nhật
            if (_Mode == 2)
            {
                try
                {
                    _ID_KhachHang = int.Parse(_DataRow["KHACHHANG_ID"].ToString());
                    txtMaKH.EditValue = _DataRow["KHACHHANG_MA"].ToString();
                    txtTenKH.EditValue = _DataRow["KHACHHANG_TEN"].ToString();
                    txtSDTKH.EditValue = _DataRow["KHACHHANG_SDT"].ToString();
                    txtDiaChiKH.EditValue = _DataRow["KHACHHANG_DIACHI"].ToString();
                    txtTaiKhoanATM.EditValue = _DataRow["KHACHHANG_TK_ATM"].ToString();
                    txtMaSoThue.EditValue = _DataRow["KHACHHANG_MASOTHUE"].ToString();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void txtMaSoThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                ucThemHoacCapNhat1.btnAddOrUpdate.PerformClick();
            }
        }
    }
}