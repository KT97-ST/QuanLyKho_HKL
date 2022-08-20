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
using QuanLyKho.Controllers.LoaiSanPham;
using QuanLyKho.Controllers.DungChung;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace QuanLyKho.Views.DanhMuc.Loai_SanPham
{
    public partial class UcLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        bool qThem=false;
        bool qSua=false;
        bool qXoa=false;
        private void kiemquyen(bool qthem,bool qsua,bool qxoa)
        {
            qThem = qthem;
            qSua = qsua;
            qXoa = qxoa;
          
        }
        private void setup()
        {

            if (qThem)
            {
                ucThemSuaXoa1.btnThem.Visible = true;
            }
            else { ucThemSuaXoa1.btnThem.Visible = false; }

            if (qSua)
            {
                ucThemSuaXoa1.btnSua.Visible = true;
            }
            else { ucThemSuaXoa1.btnSua.Visible = false; }
            if (qXoa)
            {
                ucThemSuaXoa1.btnXoa.Visible = true;
            }
            else { ucThemSuaXoa1.btnXoa.Visible = false; }
        }
        public UcLoaiSanPham(bool qt,bool qs,bool qx)
        {
            InitializeComponent();
            Init();
            kiemquyen(qt, qs, qx);
        }

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        private void Init()
        {
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(InsertLoaiSanPham);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(UpdateLoaiSanPham);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(DeleteLoaiSanPham);
            this.ucThemSuaXoa1.BtnLuuClick += new System.EventHandler(SaveLoaiSanPham);
            this.ucThemSuaXoa1.BtnHuyBoClick += new System.EventHandler(Cancel);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(Exit);

            ReadOnlyGrid(true);
        }
        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridLoaiSanPham.OptionsBehavior.ReadOnly = val;
        }

        private void UcLoaiSanPham_Load(object sender, EventArgs e)
        {
            setup();
            LoadLoaiSanPham();
        }

        #region hàm nhận sự kiện click, thêm, lưu, xóa
        // load data
        private void LoadLoaiSanPham()
        {
            gridControlLoaiSanPham.DataSource = ClsC_LoaiSanPham.Instance.LoadLoaiSanPham();
        }
        // thêm mới
        private void InsertLoaiSanPham(object sender, EventArgs e)
        {
            gridLoaiSanPham.AddNewRow();
            gridLoaiSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            ReadOnlyGrid(false);
        }

        // sửa
        private void UpdateLoaiSanPham(object sender, EventArgs e)
        {
            gridLoaiSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            ReadOnlyGrid(false);
        }

        // cập nhật
        private void SaveLoaiSanPham(object sender, EventArgs e)
        {
            SaveLoaiSanPham();
            // lưu xong về trạng thái view
            gridLoaiSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            ReadOnlyGrid(true);
        }
        // xóa 
        private void DeleteLoaiSanPham(object sender, EventArgs e)
        {
            DeleteLoaiSanPham();
        }

        // Hủy bỏ
        private void Cancel(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = gridControlLoaiSanPham.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu, bạn có muốn lưu hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveLoaiSanPham();
                }
            }
            gridLoaiSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            // huy bỏ thì về trạng thái view
            ReadOnlyGrid(true);
            LoadLoaiSanPham();
        }

        // thoát
        private void Exit(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
        #region Các hàm
        // save loại sản phẩm
        private void SaveLoaiSanPham()
        {
            DataRow dr;
            int ret = 0;
            for (int i = 0; i <= gridLoaiSanPham.RowCount; i++)
            {
                dr = gridLoaiSanPham.GetDataRow(i);
                if (dr == null) continue;

                if (dr.RowState == DataRowState.Unchanged) continue;

                int id = 0;
                string ma;
                string ten;
                // trường hợp khi thêm mới id sẽ null nên gán không dc
                if (!dr.IsNull("LOAISANPHAM_ID"))
                {
                    id = Convert.ToInt32(dr["LOAISANPHAM_ID"].ToString());
                }
                ma = dr["LOAISANPHAM_MA"].ToString();
                ten = dr["LOAISANPHAM_TEN"].ToString();

                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)) continue;

                if (dr.RowState == DataRowState.Modified)
                {
                    // kiểm tra rổng va null
                    if (id <= 0) continue;
                    if (ClsC_LoaiSanPham.Instance.UpdateLoaiSanPham(id, ma, ten) > 0)
                    {
                        ret++;
                    }
                }
                if (dr.RowState == DataRowState.Added)
                {
                    if (ClsC_LoaiSanPham.Instance.InsertLoaiSanPham(ma, ten) > 0)
                    {
                        ret++;
                    }
                }
            }
            if (ret > 0)
            {
                //MessageBox.Show("Lưu thành công");
                LoadLoaiSanPham();
            }
        }

        /// <summary>
        /// Xóa loại sản phẩm
        /// </summary>
        private void DeleteLoaiSanPham()
        {
            DataRow dr = gridLoaiSanPham.GetFocusedDataRow();
            if (dr == null)
            {
                MessageBox.Show("Dữ liệu không được chọn");
            }
            else
            {
                DialogResult dlgResult = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    if (dr.RowState == DataRowState.Added)
                    {
                        gridLoaiSanPham.DeleteRow(gridLoaiSanPham.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["LOAISANPHAM_ID"].ToString());

                        if(ClsC_LoaiSanPham.Instance.CheckLoaiSPInSanPham(id) > 0)
                        {
                            MessageBox.Show("Không thể xóa vì loại sản phẩm này đã tồn tại trong bảng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (ClsC_LoaiSanPham.Instance.DeleteLoaiSanPham(id) > 0)
                        {
                            LoadLoaiSanPham();
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Rời khỏi trang thì hỏi lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcLoaiSanPham_ParentChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = gridControlLoaiSanPham.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                SaveLoaiSanPham();
            }
        }

        // bắt lỗi nhập trùng hoặc rỗng
        private void gridLoaiSanPham_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.ClearColumnErrors();
            GridColumn ColMaDonViTinh = view.Columns["LOAISANPHAM_MA"];
            //GridColumn ColIdDonViTinh = view.Columns["DONVITINH_ID"];
            int so = gridLoaiSanPham.FocusedRowHandle;
            DataRow dataRow = gridLoaiSanPham.GetFocusedDataRow();
            if (dataRow == null) return;

            // kiểm tra rỗng
            if (string.IsNullOrEmpty(dataRow["LOAISANPHAM_MA"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColMaDonViTinh, "Mã không rỗng");
                return;
            }

            bool isEqua = false;

            for (int i = 0; i <= gridLoaiSanPham.RowCount; i++)
            {
                if (i != so)
                {
                    DataRow dr = gridLoaiSanPham.GetDataRow(i);
                    if (dr == null) continue;
                    if (dr["LOAISANPHAM_MA"].ToString() == dataRow["LOAISANPHAM_MA"].ToString())
                    {
                        isEqua = true;
                    }
                }
            }
            if (isEqua)
            {
                e.Valid = false;
                view.SetColumnError(ColMaDonViTinh, "Mã không được trùng");
            }
        }

        private void gridLoaiSanPham_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridLoaiSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ucThemSuaXoa1.AllowDelete)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteLoaiSanPham();
                }
            }
        }      
    }
}
