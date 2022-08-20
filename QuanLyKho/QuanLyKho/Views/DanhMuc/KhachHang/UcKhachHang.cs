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
using QuanLyKho.Controllers.KhachHang;

namespace QuanLyKho.Views.DanhMuc.KhachHang
{
    public partial class UcKhachHang : DevExpress.XtraEditors.XtraUserControl
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
        public UcKhachHang(bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            Init();
            kiemquyen(qt, qs, qx);
        }

        private void Init()
        {
            this.ucThemSuaXoa1.SetStatus(1);
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(Insert_KhachHang);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(Update_KhachHang);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(Delete_KhachHang);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(Exit_KhachHang);
            ReadOnlyGrid(true);
        }

        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridKhachHang.OptionsBehavior.ReadOnly = val;
        }

        private void UcKhachHang_Load(object sender, EventArgs e)
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
        private void Insert_KhachHang(object sender, EventArgs e)
        {
            DlgKhachHang dlgKH = new DlgKhachHang(InsertMode);
            if (dlgKH.ShowDialog() == DialogResult.OK)
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
        private void Update_KhachHang(object sender, EventArgs e)
        {
            DataRow dr = gridKhachHang.GetFocusedDataRow();

            DlgKhachHang dlgKH = new DlgKhachHang(UpdateMode, dr);
            if (dlgKH.ShowDialog() == DialogResult.OK)
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
        private void Delete_KhachHang(object sender, EventArgs e)
        {
            DeleteKH();
        }

        // thoát
        private void Exit_KhachHang(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region CÁC Hàm
        private void LoadData()
        {
            gridControl_KhachHang.DataSource = ClsC_KhachHang.Instance.GetKhachHang();
        }

        // xóa
        private void DeleteKH()
        {
            DataRow dr = gridKhachHang.GetFocusedDataRow();
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
                        gridKhachHang.DeleteRow(gridKhachHang.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["KHACHHANG_ID"].ToString());

                        // kiểm tra xem khách hàng muốn xóa có tồn tại hóa đơn xuất nào không. nếu có thì không cho xóa
                        if (ClsC_KhachHang.Instance.CheckKHInHDX(id) > 0)
                        {
                            MessageBox.Show("Không thể xóa vì khách hàng đã có hóa đơn xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (ClsC_KhachHang.Instance.DeleteKhachHang(id) > 0)
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
