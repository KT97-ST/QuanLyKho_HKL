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
using System.Text.RegularExpressions;
using QuanLyKho.Controllers.NhanVien;
using QuanLyKho.Controllers.DungChung;
using QuanLyKho.Controllers.DangNhap;

namespace QuanLyKho.Views.DanhMuc.NhanVien
{
    public partial class DlgNhanVien : DevExpress.XtraEditors.XtraForm
    {
        /// mode 1 là thêm mới, 2 là cập nhật
        /// </summary>
        private int _Mode = 0;
        private DataRow _DataRow;
        private int _ID_NhanVien;

        public DlgNhanVien(int mode)
        {
            InitializeComponent();
            _Mode = mode;
        }

        public DlgNhanVien(int mode, DataRow dr)
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
                this.groupThongTinNhanVien.Text = "Thêm mới nhân vien";

            }

            if (_Mode == 2)
            {
                ucThemHoacCapNhat1.setNameBtn("Cập nhật");
                this.groupThongTinNhanVien.Text = "Cập nhật thông tin nhân viên";
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
            if(txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNhanVien = txtMaNV.EditValue.ToString();
            string tenNhanVien = txtTenNV.EditValue.ToString();
            string sdtNhanVien = "";

            if(txtSDT.Text.Trim() != "")
            {
                sdtNhanVien = txtSDT.EditValue.ToString();
                if(sdtNhanVien.Trim().Length > 11)
                {
                    MessageBox.Show("Số điện thoại không được dài quá 11 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsNumber(sdtNhanVien.Trim()) == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string diaChiNhanVien = "";

            if(txtDiaChi.Text.Trim() !="") diaChiNhanVien = txtDiaChi.EditValue.ToString();

            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật Khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhauXacNhan.Text.Trim() == "")
            {
                MessageBox.Show("Mật Khẩu xác nhận không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.EditValue.ToString() != txtMatKhauXacNhan.EditValue.ToString())
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận phải giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string taiKhoanNV = txtTaiKhoan.EditValue.ToString();
            string matKhauNV = Cls_Encode_Decode.Instance.EncodeString(txtMatKhau.EditValue.ToString());
            string matKhauXacNhanNV = Cls_Encode_Decode.Instance.EncodeString(txtMatKhauXacNhan.EditValue.ToString());

            if (_Mode == 1)
            {
                object checkUser = ClsC_DangNhap.Instance.CheckIseetUser(taiKhoanNV, maNhanVien);

                if (checkUser != null)
                {
                    MessageBox.Show("Tài khoản hoặc mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ClsC_NhanVien.Instance.InsertNhanVien(maNhanVien, tenNhanVien, sdtNhanVien, diaChiNhanVien, taiKhoanNV, matKhauNV) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            if (_Mode == 2)
            {
                // kiểm tra có trùng mã hay không
                DataTable dataTable = ClsC_NhanVien.Instance.GetNhanVien();
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        if (dr == null) continue;
                        int idNVtmp = Convert.ToInt32(dr["NHANVIEN_ID"].ToString());
                        if (idNVtmp != _ID_NhanVien && (dr["NHANVIEN_MA"].ToString() == maNhanVien || dr["NHANVIEN_USER"].ToString() == taiKhoanNV))
                        {
                            MessageBox.Show("Tài khoản hoặc mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (ClsC_NhanVien.Instance.UpdateNhanVien(_ID_NhanVien, maNhanVien, tenNhanVien, sdtNhanVien, diaChiNhanVien, taiKhoanNV, matKhauNV) > 0)
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

        private void DlgNhanVien_Load(object sender, EventArgs e)
        {
            Init();

            // Cập nhật
            if(_Mode == 2)
            {
                try
                {
                    _ID_NhanVien = int.Parse(_DataRow["NHANVIEN_ID"].ToString());
                    txtMaNV.EditValue = _DataRow["NHANVIEN_MA"].ToString();
                    txtTenNV.EditValue = _DataRow["NHANVIEN_TEN"].ToString();
                    txtSDT.EditValue = _DataRow["NHANVIEN_SDT"].ToString();
                    txtDiaChi.EditValue = _DataRow["NHANVIEN_DIACHI"].ToString();
                    txtTaiKhoan.EditValue = _DataRow["NHANVIEN_USER"].ToString();
                    txtMatKhau.EditValue = Cls_Encode_Decode.Instance.DecodeString(_DataRow["NHANVIEN_PASSWORD"].ToString());
                    txtMatKhauXacNhan.EditValue = Cls_Encode_Decode.Instance.DecodeString(_DataRow["NHANVIEN_PASSWORD"].ToString());
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void txtMatKhauXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                ucThemHoacCapNhat1.btnAddOrUpdate.PerformClick();
            }
        }

        private void ucThemHoacCapNhat1_Load(object sender, EventArgs e)
        {

        }
    }
}