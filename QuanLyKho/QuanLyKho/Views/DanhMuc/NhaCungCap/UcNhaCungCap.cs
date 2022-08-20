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
using QuanLyKho.Controllers.NhaCungCap;
using QuanLyKho.Controllers.DungChung;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using System.Text.RegularExpressions;

namespace QuanLyKho.Views.DanhMuc.NhaCungCap
{
    public partial class UcNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        // thêm mới
        private const int InsertMode = 1;
        // cập nhật
        private const int UpdateMode = 2;
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
        public UcNhaCungCap(bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            Init();
            kiemquyen(qt, qs, qx);
        }

        private void Init()
        {
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(Insert_NhaCungCap);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(Update_NhaCungCap);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(Delete_NhaCungCap);
            this.ucThemSuaXoa1.BtnLuuClick += new System.EventHandler(Save_NhaCungCap);
            this.ucThemSuaXoa1.BtnHuyBoClick += new System.EventHandler(Cancel_NhaCungCap);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(Exit_NhaCungCap);

            ReadOnlyGrid(true);
        }

        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridNhaCungCap.OptionsBehavior.ReadOnly = val;
        }

        private void UcNhaCungCap_Load(object sender, EventArgs e)
        {
            setup();
            LoadData();
        }
        #region Các hàm
        // lấy dữ liệu
        private void LoadData()
        {
            gridControl_NhaCungCap.DataSource = ClsC_NhaCungCap.Instance.LoadNhaCungCap(); 
        }
        #endregion 

        #region Cách hàm nhận sự kiện
        /// <summary>
        /// thêm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_NhaCungCap(object sender, EventArgs e)
        {
            gridNhaCungCap.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            ReadOnlyGrid(false);
        }
     
        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_NhaCungCap(object sender, EventArgs e)
        {
            gridNhaCungCap.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            ReadOnlyGrid(false);
        }

        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_NhaCungCap(object sender, EventArgs e)
        {
            DeleteNhaCungCap();
        }

        // lưu
        private void Save_NhaCungCap(object sender, EventArgs e)
        {
            SaveNhaCungCap();
            gridNhaCungCap.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            ReadOnlyGrid(true);
        }       

        // huy bỏ
        private void Cancel_NhaCungCap(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = gridControl_NhaCungCap.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu, bạn có muốn lưu hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveNhaCungCap();
                }
            }
            gridNhaCungCap.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            // huy bỏ thì về trạng thái view
            ReadOnlyGrid(true);
            LoadData();
        }

        private void Exit_NhaCungCap(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region các hàm


        /// <summary>
        /// Xóa nhà cung cấp
        /// </summary>
        private void DeleteNhaCungCap()
        {
            DataRow dr = gridNhaCungCap.GetFocusedDataRow();
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
                        gridNhaCungCap.DeleteRow(gridNhaCungCap.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["NHACUNGCAP_ID"].ToString());

                        if(ClsC_NhaCungCap.Instance.CheckIsset_NhaCungCapInHoaDonNhap(id) > 0)
                        {
                            MessageBox.Show("Không thể xóa vì nhà cung cấp đã tồn tại trong hóa đơn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (ClsC_NhaCungCap.Instance.DeleteNhaCungCap(id) > 0)
                        {
                           // MessageBox.Show("Xóa thành công");
                            LoadData();
                        }
                    }
                }
            }
        }

        // save nhà cung cấp
        private void SaveNhaCungCap()
        {
            DataTable dt = new DataTable();
            dt = gridControl_NhaCungCap.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                
                DataRow dr;
                int ret = 0;
                for (int i = 0; i <= gridNhaCungCap.RowCount; i++)
                {
                    dr = gridNhaCungCap.GetDataRow(i);
                    if (dr == null) continue;
                    if (dr.RowState == DataRowState.Unchanged) continue;

                    int id = 0;
                    string ma;
                    string ten;
                    string sdt;
                    string diaChi;
                    string tkATM;
                    string maSoThue;
                    // trường hợp khi thêm mới id sẽ null nên gán không dc
                    if (!dr.IsNull("NHACUNGCAP_ID"))
                    {
                        id = Convert.ToInt32(dr["NHACUNGCAP_ID"].ToString());
                    }
                    ma = dr["NHACUNGCAP_MA"].ToString();
                    ten = dr["NHACUNGCAP_TEN"].ToString();
                    sdt = dr["NHACUNGCAP_SDT"].ToString();
                    diaChi = dr["NHACUNGCAP_DIACHI"].ToString();
                    tkATM = dr["NHACUNGCAP_TK_ATM"].ToString();
                    maSoThue = dr["NHACUNGCAP_MASOTHUE"].ToString();
                    if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)) continue;

                    if (dr.RowState == DataRowState.Modified)
                    {
                        // kiểm tra rổng va null
                        if (id <= 0) continue;
                        if (ClsC_NhaCungCap.Instance.UpdateNhaCungCap(id, ma, ten, sdt, diaChi, tkATM, maSoThue) > 0)
                        {
                            ret++;
                        }
                    }
                    if (dr.RowState == DataRowState.Added)
                    {
                        if (ClsC_NhaCungCap.Instance.InsertNhaCungCap(ma, ten, sdt, diaChi, tkATM, maSoThue) > 0)
                        {
                            ret++;
                        }
                    }
                }
                if (ret > 0)
                {
                    // MessageBox.Show("Lưu thành công");
                    LoadData();
                }
            }
            else
            {
               // MessageBox.Show("Không có gì thay đổi");
            }
        }
        #endregion

        // có phải là số hay không
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        /// <summary>
        /// Rời khỏi trang thì hỏi lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcNhaCungCap_ParentChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = gridControl_NhaCungCap.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                SaveNhaCungCap();
            }
        }

        // bắt lỗi nhập trùng hoặc rỗng
        private void gridNhaCungCap_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            // thông báo 
            string checkSDT = "";
            string checkATM = "";
            // có trùng mã hay không
            bool isEqua = false;

            GridView view = sender as GridView;
            GridColumn ColMaNhaCungCap = view.Columns["NHACUNGCAP_MA"];
            GridColumn ColSdtNhaCungCap = view.Columns["NHACUNGCAP_SDT"];
            GridColumn ColATMNhaCungCap = view.Columns["NHACUNGCAP_TK_ATM"];


            int so = gridNhaCungCap.FocusedRowHandle;
            DataRow dataRow = gridNhaCungCap.GetFocusedDataRow();
            if (dataRow == null) return;

            // kiểm tra tính hợp lệ số điện thoại
            if(dataRow["NHACUNGCAP_SDT"].ToString().Trim().Length > 11)
            {
                checkSDT = "Số điện không được dài hơn 11 chữ số";
            }
            else if (dataRow["NHACUNGCAP_SDT"].ToString().Trim().Length > 0 &&
                    dataRow["NHACUNGCAP_SDT"].ToString().Trim().Length <= 11)
            {
                if (IsNumber(dataRow["NHACUNGCAP_SDT"].ToString().Trim()) == false)
                {
                    checkSDT = "Số điện thoại không hợp lệ";
                }
            }

            if(IsNumber(dataRow["NHACUNGCAP_TK_ATM"].ToString().Trim()) == false)
             {
                checkATM = "Số tài khoản ATM không hợp lệ";
            }

            // kiểm tra rỗng
            if (string.IsNullOrEmpty(dataRow["NHACUNGCAP_MA"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColMaNhaCungCap, "Mã không rỗng");
                return;
            }

            for (int i = 0; i <= gridNhaCungCap.RowCount; i++)
            {
                if (i != so)
                {
                    DataRow dr = gridNhaCungCap.GetDataRow(i);
                    if (dr == null) continue;
                    if (dr["NHACUNGCAP_MA"].ToString() == dataRow["NHACUNGCAP_MA"].ToString())
                    {
                        isEqua = true;
                    }
                }
            }
            // nếu true thì trùng
            if (isEqua)
            {
                e.Valid = false;
                view.SetColumnError(ColMaNhaCungCap, "Mã không được trùng");
            }

            if(checkSDT != "")
            {
                e.Valid = false;
                view.SetColumnError(ColSdtNhaCungCap, checkSDT);
            }

            if (checkATM != "")
            {
                e.Valid = false;
                view.SetColumnError(ColATMNhaCungCap, checkATM);
            }
        }

        private void gridNhaCungCap_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ucThemSuaXoa1.AllowDelete)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteNhaCungCap();
                }
            }
        }
    }
}
