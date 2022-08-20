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
using QuanLyKho.Controllers.ClsC_DanhMuc;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyKho.Controllers.NhanVien;

namespace QuanLyKho.Views.DanhMuc.NhanVien
{
    public partial class UcNhanVien : DevExpress.XtraEditors.XtraUserControl
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
        public UcNhanVien(bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            Init();
            kiemquyen(qt, qs, qx);
        }

        private void Init()
        {
            this.ucThemSuaXoa1.SetStatus(1);
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(Insert_NhanVien);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(Update_NhanVien);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(Delete_NhanVien);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(Exit_NhanVien);
            ReadOnlyGrid(true);
        }
 
        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridNhanVien.OptionsBehavior.ReadOnly = val;
        }

        private void UcNhanVien_Load(object sender, EventArgs e)
        {
            setup();
            LoadData();
        }

        #region Các hàm nhận sự kiện button click

        /// <summary>
        ///  thêm mới nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_NhanVien(object sender, EventArgs e)
        {
            DlgNhanVien dlgNV = new DlgNhanVien(InsertMode);
            if (dlgNV.ShowDialog() == DialogResult.OK)
            {
                // thành công
                LoadData();
            }

        }

        /// <summary>
        /// Cập nhật nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_NhanVien(object sender, EventArgs e)
        {
            DataRow dr = gridNhanVien.GetFocusedDataRow();

            DlgNhanVien dlgNV = new DlgNhanVien(UpdateMode, dr);
            if (dlgNV.ShowDialog() == DialogResult.OK)
            {
                // thành công
                LoadData();
            }
        }

        /// <summary>
        /// xóa sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_NhanVien(object sender, EventArgs e)
        {
            DeleteNV();
        }

        // thoát
        private void Exit_NhanVien(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region CÁC Hàm
        private void LoadData()
        {
            gridC_NhanVien.DataSource = ClsC_NhanVien.Instance.GetNhanVien();
        }

        // xóa
        private void DeleteNV()
        {
            DataRow dr = gridNhanVien.GetFocusedDataRow();
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
                        gridNhanVien.DeleteRow(gridNhanVien.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["NHANVIEN_ID"].ToString());
                        if (ClsC_NhanVien.Instance.DeleteNhanVien(id) > 0)
                        {
                            // MessageBox.Show("Xóa thành công");
                            LoadData();
                        }
                    }
                }
            }
        }
        #endregion
    }
}
