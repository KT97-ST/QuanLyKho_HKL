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
using QuanLyKho.Controllers.NhaCungCap;

namespace QuanLyKho.Views.DanhMuc.NhaCungCap
{
    public partial class DlgNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// mode 1 là thêm mới, 2 là cập nhật
        /// </summary>
        private int _Mode = 0;
        private DataRow _DataRow;
        private int _ID_NhaCungCap;


        private void DlgNhaCungCap_Load(object sender, EventArgs e)
        {
            Init();

            if(_Mode == 2)
            {
                // hiển thị cập nhật
                _ID_NhaCungCap = Convert.ToInt32(_DataRow["NHACUNGCAP_ID"].ToString());
                txtMaNhaCungCap.EditValue = _DataRow["NHACUNGCAP_MA"].ToString();
                txtTenNhaCungCap.EditValue = _DataRow["NHACUNGCAP_TEN"].ToString();
                txtSDT.EditValue = _DataRow["NHACUNGCAP_SDT"].ToString();
                txtDiaChiNhaCungCap.EditValue = _DataRow["NHACUNGCAP_DIACHI"].ToString();
            }
        }

        public DlgNhaCungCap(int mode)
        {
            InitializeComponent();
            _Mode = mode;
        }

        public DlgNhaCungCap(int mode, DataRow dr)
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
                this.groupThongTinDVT.Text = "Thêm nhà cung cấp";

            }

            if (_Mode == 2)
            {
                ucThemHoacCapNhat1.setNameBtn("Cập nhật");
                this.groupThongTinDVT.Text = "Cập nhật nhà cung cấp";
            }
        }
        #region Hàm Thêm, Cập Nhật, Thoát
        private void AddNewOrUpdate(object sender, EventArgs e)
        {
            string ma = txtMaNhaCungCap.EditValue.ToString();
            string ten = txtTenNhaCungCap.EditValue.ToString();
            string sdt ="";
            if(txtSDT.EditValue != null)
            {
                sdt = txtSDT.EditValue.ToString().Trim();
            }
           
               
            if(sdt.ToString().Length > 11)
            {
                MessageBox.Show("Số điện thoại không được dài hơn 11 chữ số","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string diaChi = txtDiaChiNhaCungCap.EditValue.ToString();

            if (_Mode == 1)
            {
                //if(ClsC_NhaCungCap.Instance.InsertNhaCungCap(ma,ten,sdt,diaChi) > 0)
                //{
                //    this.DialogResult = DialogResult.OK;
                //    this.Close();
                //}
            }
            if (_Mode == 2)
            {
                //if(ClsC_NhaCungCap.Instance.UpdateNhaCungCap(_ID_NhaCungCap, ma, ten, sdt, diaChi) > 0)
                //{
                //    this.DialogResult = DialogResult.OK;
                //    this.Close();
                //}
            }
        }
        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}