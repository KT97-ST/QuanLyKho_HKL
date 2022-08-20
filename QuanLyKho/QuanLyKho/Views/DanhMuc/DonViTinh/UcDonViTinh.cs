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
using QuanLyKho.Controllers;
using QuanLyKho.Controllers.DungChung;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using QuanLyKho.Views.DanhMuc.SanPham;

namespace QuanLyKho.Views.DanhMuc.DonViTinh
{
    public partial class UcDonViTinh : DevExpress.XtraEditors.XtraUserControl
    {
        private const int AddNewDVt = 1; // 1 thì thêm mới
        private const int UpdateDVT = 2; // 2 thì cập nhật
        bool qThem = false;
        bool qSua = false;
        bool qXoa = false;
        private void kiemquyen(bool qthem, bool qsua, bool qxoa)
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
        public UcDonViTinh(bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            Innit();
            kiemquyen(qt, qs, qx);
        }
        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        private void Innit()
        {
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(ThemDonViTinh);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(SuaDonViTinh);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(DelDonViTinh);
            this.ucThemSuaXoa1.BtnLuuClick += new System.EventHandler(LuuDonViTinh);
            this.ucThemSuaXoa1.BtnHuyBoClick += new System.EventHandler(HuyBo);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(ThoatViTinh);

            ReadOnlyGrid(true);
        }

        private void UcDonViTinh_Load(object sender, EventArgs e)
        {
            setup();
            loadDVT();            
        }

        #region sữ kiện Hàm Thêm Sửa Xóa
        private void ThemDonViTinh(object sender, EventArgs e)
        {
            gridDonViTinh.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            ReadOnlyGrid(false);
        }

        private void SuaDonViTinh(object sender, EventArgs e)
        {
            gridDonViTinh.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            ReadOnlyGrid(false);
        }

        private void LuuDonViTinh(object sender, EventArgs e)
        {
            SaveDonViTinh();
            gridDonViTinh.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
           // ucThemSuaXoa1.SetDisplayButton(0);
            ReadOnlyGrid(true);
        }

        private void ThoatViTinh(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HuyBo(object sender, EventArgs e)
        {
            if (IsModified())
            {
                if(MessageBox.Show("Dữ liệu chưa được lưu, bạn có muốn lưu hay không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveDonViTinh();
                }
            }
            gridDonViTinh.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            // huy bỏ thì về trạng thái view
            ReadOnlyGrid(true);
            loadDVT();
        }
        private void DelDonViTinh(object sender, EventArgs e)
        {
            DelDonViTinh();
        }
        #endregion

        #region Các hàm thêm sửa xóa lưu
        // lưu đơn vị tính
        private void SaveDonViTinh()
        {
                   
            DataRow dr;
            int ret = 0;
            for (int i = 0; i <= gridDonViTinh.RowCount; i++)
            {
                dr = gridDonViTinh.GetDataRow(i);
                if (dr == null) continue;

                if (dr.RowState == DataRowState.Unchanged) continue;

                int id = 0;
                string ma;
                string ten;
                // trường hợp khi thêm mới id sẽ null nên gán không dc
                if (!dr.IsNull("DONVITINH_ID"))
                {
                    id = Convert.ToInt32(dr["DONVITINH_ID"].ToString());
                }
                ma = dr["DONVITINH_MA"].ToString();
                ten = dr["DONVITINH_TEN"].ToString();

                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)) continue;

                if (dr.RowState == DataRowState.Modified)
                {
                    // kiểm tra rổng va null
                    if (id <= 0) continue;
                    if (DonViTinh_Controller.Instance.Update_DonViTinh(id, ma, ten) > 0)
                    {
                        ret++;
                    }
                }
                if (dr.RowState == DataRowState.Added)
                {
                    if (DonViTinh_Controller.Instance.Insert_DonViTinh(ma, ten) > 0)
                    {
                        ret++;
                    }
                }
            }
            if (ret > 0)
            {
                loadDVT();
            }
        }

        /// <summary>
        /// lấy danh sách đơn vị tính
        /// </summary>
        private void loadDVT()
        {
            gridControlDonViTinh.DataSource = DonViTinh_Controller.Instance.LoadDVT();
        }

        /// <summary>
        /// Xóa đơn vị tính
        /// </summary>
        private void DelDonViTinh()
        {
            DataRow dr = gridDonViTinh.GetFocusedDataRow();

            if(dr == null)
            {
                MessageBox.Show("Dữ liệu không được chọn");
            }
            else
            {
                DialogResult dlgResult = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    if(dr.RowState == DataRowState.Added)
                    {
                        gridDonViTinh.DeleteRow(gridDonViTinh.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["DONVITINH_ID"].ToString());
                        if(DonViTinh_Controller.Instance.ChechIssetDVTInSanPham(id) > 0)
                        {
                            MessageBox.Show("Không thể xóa vì đơn vị tính đã tồn tại trong sản phầm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (DonViTinh_Controller.Instance.Delete_DonVitinh(id) > 0)
                        {
                            loadDVT();
                        }
                    }
                }
            }
        }
        #endregion

        #region Các sự kiện
        /// <summary>
        /// rời khỏi trang 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcDonViTinh_ParentChanged(object sender, EventArgs e)
        {
            if (IsModified())
            {
                SaveDonViTinh();
            }
        }

        // kiểm tra dữ liệu có thay đổi hay không
        private bool IsModified()
        {
            DataTable dt = new DataTable();
            dt = gridControlDonViTinh.DataSource as DataTable;
            return ClsCheckSave.Instance.CheckModified(dt);
        }

        // bắt lỗi nhập trùng hoặc rỗng
        private void gridDonViTinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn ColMaDonViTinh = view.Columns["DONVITINH_MA"];
            //GridColumn ColIdDonViTinh = view.Columns["DONVITINH_ID"];
            int so = gridDonViTinh.FocusedRowHandle;
            DataRow dataRow = gridDonViTinh.GetFocusedDataRow();
            if (dataRow == null) return;
            // kiểm tra rỗng
            if (string.IsNullOrEmpty(dataRow["DONVITINH_MA"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColMaDonViTinh, "Mã không rỗng");
                return;
            }

            bool isEqua = false;

            for(int i =0; i <= gridDonViTinh.RowCount; i++)
            {
                if(i != so)
                {
                    DataRow dr = gridDonViTinh.GetDataRow(i);
                    if (dr == null) continue;
                    if(dr["DONVITINH_MA"].ToString() == dataRow["DONVITINH_MA"].ToString())
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
        private void gridDonViTinh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridDonViTinh.OptionsBehavior.ReadOnly = val;
        }

        #endregion

        #region bắt sự kiện nhập từ bàn phím
        // nhận sự kiện từ bàn phím
        private void gridControlDonViTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ucThemSuaXoa1.AllowDelete)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DelDonViTinh();
                }
            }
        }
        #endregion
    }
}
