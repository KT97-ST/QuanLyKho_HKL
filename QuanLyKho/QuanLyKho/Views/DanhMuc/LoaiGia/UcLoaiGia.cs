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
using QuanLyKho.Controllers.LoaiGia;
using QuanLyKho.Controllers.DungChung;

namespace QuanLyKho.Views.DanhMuc.LoaiGia
{
    public partial class UcLoaiGia : DevExpress.XtraEditors.XtraUserControl
    {
        public UcLoaiGia()
        {
            InitializeComponent();
            Innit();
        }

        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        private void Innit()
        {
            this.ucThemSuaXoa1.BtnThemClick += new System.EventHandler(InsertGiaTien_LoaiGia);
            this.ucThemSuaXoa1.BtnXoaClick += new System.EventHandler(DeleteGiaTien_LoaiGia);
            this.ucThemSuaXoa1.BtnLuuClick += new System.EventHandler(SaveGiaTien_LoaiGia);
            this.ucThemSuaXoa1.SetVisableBtnEdit(false);
            this.ucThemSuaXoa1.SetVisableBtnDelect(false);

            LoadGiaTien_LoaiGia();
        }

        #region hàm nhận sự kiện click, thêm, lưu, xóa

        // load data
        private void LoadGiaTien_LoaiGia()
        {
            gridControl_GiaTien.DataSource = ClsC_LoaiGia.Instance.LoadGiaTien_LoaiGia();
        }
        // thêm mới
        private int idMax;
        private void InsertGiaTien_LoaiGia(object sender, EventArgs e)
        {
            gridGiaTien.AddNewRow();

            //List<int> listID = new List<int>();
            //DataRow dr;
            //for (int i = 0; i <= gridGiaTien.RowCount; i++)
            //{
            //    dr = gridGiaTien.GetDataRow(i);
            //    if (dr == null) continue;
            //    if (dr.RowState == DataRowState.Added) continue;
            //    listID.Add(Convert.ToInt32(dr["LOAISANPHAM_ID"].ToString()));
            //}
            //if (listID.Count > 0)
            //    idMax = listID.Max();
        }
        // cập nhật
        private void SaveGiaTien_LoaiGia(object sender, EventArgs e)
        {
            SaveGiaTien_LoaiGia();
        }
        // xóa 
        private void DeleteGiaTien_LoaiGia(object sender, EventArgs e)
        {
            DeleteGiaTien_LoaiGia();
        }
        #endregion
        #region Các hàm
        // save loại sản phẩm
        private void SaveGiaTien_LoaiGia()
        {
            DataTable dt = new DataTable();
            dt = gridControl_GiaTien.DataSource as DataTable;

            bool checkModified = ClsCheckSave.Instance.CheckModified(dt);
            if (checkModified)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataRow dr;
                    int ret = 0;
                    for (int i = 0; i <= gridGiaTien.RowCount; i++)
                    {
                        dr = gridGiaTien.GetDataRow(i);
                        if (dr == null) continue;

                        if (dr.RowState == DataRowState.Unchanged) continue;

                        int id = 0;
                        string ma;
                        string ten;
                        // trường hợp khi thêm mới id sẽ null nên gán không dc
                        if (!dr.IsNull("LOAIGIA_ID"))
                        {
                            id = Convert.ToInt32(dr["LOAIGIA_ID"].ToString());
                        }
                        ma = dr["LOAIGIA_MA"].ToString();
                        ten = dr["LOAIGIA_TEN"].ToString();

                        if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten)) continue;

                        if (dr.RowState == DataRowState.Modified)
                        {
                            // kiểm tra rổng va null
                            if (id <= 0) continue;
                            if (ClsC_LoaiGia.Instance.UpdateGiaTien_LoaiGia(id, ma, ten) > 0)
                            {
                                ret++;
                            }
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            if (ClsC_LoaiGia.Instance.InsertGiaTien_LoaiGia(ma, ten) > 0)
                            {
                                ret++;
                            }
                        }
                    }
                    if (ret > 0)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadGiaTien_LoaiGia();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có gì thay đổi");
            }
        }

        /// <summary>
        /// Xóa giá tiền - loại giá
        /// </summary>
        private void DeleteGiaTien_LoaiGia()
        {
            DataRow dr = gridGiaTien.GetFocusedDataRow();
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
                        gridGiaTien.DeleteRow(gridGiaTien.FocusedRowHandle);
                    }
                    else
                    {
                        int id = Convert.ToInt32(dr["LOAIGIA_ID"].ToString());

                        if (ClsC_LoaiGia.Instance.DeleteGiaTien_LoaiGia(id) > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                            LoadGiaTien_LoaiGia();
                        }
                    }
                }
            }
        }
        #endregion
    }
}
