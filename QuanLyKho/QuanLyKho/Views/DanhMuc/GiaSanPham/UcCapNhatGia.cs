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


namespace QuanLyKho.Views.DanhMuc.GiaSanPham
{
    public partial class UcCapNhatGia : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime timeNow;
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
                btnThem.Visible = true;
            }
            else { btnThem.Visible = false; }

            //if (qSua)
            //{
            //    ucThemSuaXoa1.btnSua.Visible = true;
            //}
            //else { ucThemSuaXoa1.btnSua.Visible = false; }
            //if (qXoa)
            //{
            //    ucThemSuaXoa1.btnXoa.Visible = true;
            //}
            //else { ucThemSuaXoa1.btnXoa.Visible = false; }
        }
        public UcCapNhatGia(bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            kiemquyen(qt, qs, qx);
        }
        private void LoadThongTinGia()
        {
            gcThongTinGia.DataSource = ClsC_CapNhatGia.Instance.GetThongTinGia();
            
        }
        private void LoadTT_DanhMuc()
        {
            timeNow = DateTime.Now;

            cbSanPham.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("DM_SANPHAM");
            cbLoaiGia.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("GIATIEN_LOAIGIA", "WHERE LOAIGIA_ID<>1");
            cbSanPham.Refresh();
            cbLoaiGia.Refresh();
            txtGiaTien.EditValue = "";
            deThoiGianHLUC.EditValue=timeNow;
        }
        private void UcCapNhatGia_Load(object sender, EventArgs e)
        {
            setup();
            LoadThongTinGia();
            LoadTT_DanhMuc();
        }
        private void ThemGiaMoi()
        {
            try
            {
                if (cbSanPham.Text == "" || cbLoaiGia.Text == "" ||
                    txtGiaTien.Text == "" || Convert.ToDateTime(deThoiGianHLUC.EditValue.ToString()) == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ClsC_CapNhatGia.Instance.InsertGiaMoi(cbSanPham.EditValue.ToString(), cbLoaiGia.EditValue.ToString(), txtGiaTien.EditValue.ToString(), Convert.ToDateTime(deThoiGianHLUC.EditValue.ToString()));
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongTinGia();
                    LoadTT_DanhMuc();
                }

            }
            catch(Exception EX)
            {
                MessageBox.Show("Thêm thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemGiaMoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
