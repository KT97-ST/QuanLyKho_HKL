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
using QuanLyKho.Controllers.SanPham;
using QuanLyKho.Controllers.LoaiSanPham;
using QuanLyKho.Controllers.C_DonViTinh;
using DevExpress.XtraEditors.Controls;
using QuanLyKho.Controllers.DungChung;


namespace QuanLyKho.Views.DanhMuc.SanPham
{
    public partial class DlgSanPham : DevExpress.XtraEditors.XtraForm
    {
        /// mode 1 là thêm mới, 2 là cập nhật
        /// </summary>
        private int _Mode = 0;
        private DataRow _DataRow;
        private int _ID_SanPham;

        
        
        public DlgSanPham(int mode)
        {
            InitializeComponent();
            _Mode = mode;
        }

        public DlgSanPham(int mode, DataRow dr)
        {
            InitializeComponent();
            _DataRow = dr;
            _Mode = mode;
        }
        // load
        private void DlgSanPham_Load(object sender, EventArgs e)
        {
            Init();
            // load combo
            LoadCombobox();

            // cập nhật
            if (_Mode == 2)
            {
                // hiển thị cập nhật
                _ID_SanPham = Convert.ToInt32(_DataRow["SANPHAM_ID"].ToString());
                txtMaSanPham.EditValue = _DataRow["SANPHAM_MA"].ToString();
                txtTenSanPham.EditValue = _DataRow["SANPHAM_TEN"].ToString();             
            }
        }

        // load combobox lsp and đơn vị tính
        private void LoadCombobox()
        {
            // loại sản phẩm
            cbxLoaiSanPham.Properties.DataSource = ClsC_LoaiSanPham.Instance.LoadLoaiSanPham();
            cbxLoaiSanPham.Properties.DisplayMember = "LOAISANPHAM_TEN";
            cbxLoaiSanPham.Properties.ValueMember = "LOAISANPHAM_ID";

            // đơn vị tính
            cbxDonViTinh.Properties.DataSource = ClsC_DonViTinh.Instance.LoadDVT();
            cbxDonViTinh.Properties.DisplayMember = "DONVITINH_TEN";
            cbxDonViTinh.Properties.ValueMember = "DONVITINH_ID";

            // nếu != null thì là cập nhật
            if(_DataRow != null)
            {
                cbxLoaiSanPham.EditValue = _DataRow["LOAISANPHAM_ID"];

                cbxDonViTinh.EditValue = _DataRow["DONVITINH_ID"];
            }
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
                this.groupThongTinSanPham.Text = "Thêm mới sản phẩm";

            }

            if (_Mode == 2)
            {
                ucThemHoacCapNhat1.setNameBtn("Cập nhật");
                this.groupThongTinSanPham.Text = "Cập nhật thông tin sản phẩm";
            }
        }

        #region hàm thêm, cập nhật, thoát

        // thêm, cập nhật
        private void AddNewOrUpdate(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSanPham.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sản phẩm không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                if (txtTenSanPham.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Sản phẩm không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                if (cbxLoaiSanPham.Text.Trim() == "")   
                {
                    MessageBox.Show("Loại Sản phẩm không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                if (cbxDonViTinh.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn vị tính Sản phẩm không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                string maSanPham = txtMaSanPham.EditValue.ToString();
                string tenSanPham = txtTenSanPham.EditValue.ToString();
                string loaiSanPhamId = cbxLoaiSanPham.EditValue.ToString();
                string donViTinhId = cbxDonViTinh.EditValue.ToString();

                if (_Mode == 1)
                {
                    if (ClsC_SanPham.Instance.CheckIssetSanPham(maSanPham) != null)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (ClsC_SanPham.Instance.InsertSanPham(maSanPham, tenSanPham, loaiSanPhamId, donViTinhId) > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

                if (_Mode == 2)
                {
                    // kiểm tra có trùng mã hay không
                    DataTable dataTable = ClsC_SanPham.Instance.GetSanPham();
                    if (dataTable != null)
                    {
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            if (dr == null) continue;
                            int idSPtmp = Convert.ToInt32(dr["SANPHAM_ID"].ToString());
                            if (idSPtmp != _ID_SanPham && dr["SANPHAM_MA"].ToString() == maSanPham)
                            {
                                MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (ClsC_SanPham.Instance.UpdateSanPham(_ID_SanPham, maSanPham, tenSanPham, loaiSanPhamId, donViTinhId) > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void cbxDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                ucThemHoacCapNhat1.btnAddOrUpdate.PerformClick();
            }
        }
    }
}