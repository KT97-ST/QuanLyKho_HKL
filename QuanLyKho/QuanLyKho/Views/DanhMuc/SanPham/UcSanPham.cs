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
using QuanLyKho.Views.UserControls.ThemSuaXoa;
using QuanLyKho.Controllers.SanPham;

namespace QuanLyKho.Views.DanhMuc.SanPham
{
    public partial class UcSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        // thêm mới
        private const int InsertMode = 1;
        // cập nhật
        private const int UpdateMode = 2;

        public UcSanPham()  
        {
            InitializeComponent();
            Init();
        }

        // khởi tạo
        private void Init()
        {
            this.ucThemSuaXoa1.SetStatus(1);
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(Insert_SanPham);
            this.ucThemSuaXoa1.BtnSuaClick += new System.EventHandler(Update_SanPham);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(Delete_SanPham);
            this.ucThemSuaXoa1.BtnThoatClick += new System.EventHandler(Exit_SanPham);

            ReadOnlyGrid(true);
        }

        // cho phép thêm sửa trên grid
        private void ReadOnlyGrid(bool val)
        {
            gridSanPham.OptionsBehavior.ReadOnly = val;
        }

        /// <summary>
        ///  load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region Các hàm nhận sự kiện button click

        /// <summary>
        ///  thêm mới sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_SanPham(object sender, EventArgs e)
        {
           DlgSanPham dlgSanPham = new DlgSanPham(1);
           if(dlgSanPham.ShowDialog() == DialogResult.OK)
           {
                // thành công
                LoadData();
            }
            
        }

        /// <summary>
        /// Cập nhật sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_SanPham(object sender, EventArgs e)
        {
            DataRow dr = gridSanPham.GetFocusedDataRow();

            DlgSanPham dlgSanPham = new DlgSanPham(2,dr);
            if (dlgSanPham.ShowDialog() == DialogResult.OK)
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
        private void Delete_SanPham(object sender, EventArgs e)
        {
            DeleteSP();
        }

        // thoát
        private void Exit_SanPham(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Các hàm
        // lấy dữ liệu
        private void LoadData()
        {
            gridC_SanPham.DataSource = ClsC_SanPham.Instance.GetSanPham();
        }

        // xóa
        private void DeleteSP()
        {
            DataRow dr = gridSanPham.GetFocusedDataRow();
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
                        gridSanPham.DeleteRow(gridSanPham.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["SANPHAM_ID"].ToString());

                        if (ClsC_SanPham.Instance.CheckSanPhamInHDN(id) > 0)
                        {
                            MessageBox.Show("Không thể xóa vì trong hóa đơn nhập đã tồn tại sản phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (ClsC_SanPham.Instance.DeleteSanPham(id) > 0)
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
