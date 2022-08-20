using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKho.Views.DanhMuc.SanPham;
using QuanLyKho.Views.DanhMuc.Loai_SanPham;
using QuanLyKho.Views.DanhMuc.DonViTinh;
using QuanLyKho.Views.DanhMuc.KhachHang;
using QuanLyKho.Views.DanhMuc.LoaiGia;
using QuanLyKho.Views.DanhMuc.NhanVien;
using QuanLyKho.Views.DanhMuc.NhaCungCap;
using QuanLyKho.Views.DanhMuc.GiaSanPham;
using QuanLyKho.Views.DanhMuc.HoaDonNhap;
using QuanLyKho.Views.Kho;
using QuanLyKho.Views.Connection;
using QuanLyKho.Views.CongNo;
using QuanLyKho.Views.DoanhThu;
using QuanLyKho.Controllers.ClsC_DanhMuc;


namespace QuanLyKho
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private LabelControl LabelTieuDe;
        private static frmMain instance;
        bool qThem = false;
        bool qSua = false;
        bool qXoa = false;

        public int _IdUser = 0;
        string CHUCNANG_MA = "";

     

        public frmMain(int idUser) 
        {
            InitializeComponent();
            _IdUser = idUser;
        }

        private bool IsClose = true;

        private void accordion_DM_SamPham_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "SẢN PHẨM";
            UcSanPham ucSanPham  = new UcSanPham();
            AddTab(ucSanPham);
        }

        public void AddTab(XtraUserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            this.Refresh();
            pnlMain.Controls.Add(userControl);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsClose == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // Use this since we are a WinForms app
                    // System.Windows.Forms.Application.Exit();
                    this.Dispose();
                    System.Environment.Exit(0);
                }
                else
                {
                    // Use this since we are a console app
                    this.Dispose();
                    System.Environment.Exit(1);
                }
            }
        }
        private void KiemQuyen( int idNV,string chucnang_ma,out bool qthem, out bool qsua, out bool qxoa)
        {
            ClsC_KiemQuyen.Instance.KiemQuyentheoID(idNV, chucnang_ma,out qthem, out qsua, out qxoa);
          
        }
        private void accordion_DM_LoaiSamPham_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "LOẠI SẢN PHẨM";
            CHUCNANG_MA = "DM_LOAI";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcLoaiSanPham ucLoaiSanPham = new UcLoaiSanPham(qThem, qSua,qXoa);
            AddTab(ucLoaiSanPham);
        }

        private void accordion_DM_NhaCungCap_Click(object sender, EventArgs e)
        {
            // lblTitle.Text = "NHÀ CUNG CẤP";
            CHUCNANG_MA = "DM_NCC";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcNhaCungCap ucNhaCungCap = new UcNhaCungCap(qThem, qSua, qXoa);
            AddTab(ucNhaCungCap);
        }

        private void accordionDM_DON_VI_TINH_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "ĐƠN VỊ TÍNH";
            CHUCNANG_MA = "DM_DVT";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcDonViTinh ucDonViTinh = new UcDonViTinh(qThem, qSua, qXoa);
            AddTab(ucDonViTinh);
        }

        private void accordionDM_GIA_SAN_PHAM_Click(object sender, EventArgs e)
        {
            ////lblTitle.Text = "GIÁ SẢN PHẨM";
          
            //UcGiaSanPham ucGiaSanPham = new UcGiaSanPham();
            //AddTab(ucGiaSanPham);
        }

        private void accordionDM_LOAI_GIA_Click(object sender, EventArgs e)
        {
          //  lblTitle.Text = "LOẠI GIÁ";
            UcLoaiGia ucLoaiGia = new UcLoaiGia();
            AddTab(ucLoaiGia);
        }

        private void accordionDM_NHAN_VIEN_Click(object sender, EventArgs e)
        {
            // lblTitle.Text = "NHÂN VIÊN";
            CHUCNANG_MA = "DM_NV";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcNhanVien ucNhanVien = new UcNhanVien(qThem, qSua, qXoa);
            AddTab(ucNhanVien);
        }

        private void accordionDM_KHACH_HANG_Click(object sender, EventArgs e)
        {

            // lblTitle.Text = "KHÁCH HÀNG";
            CHUCNANG_MA = "DM_KH";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcKhachHang ucKhachHang = new UcKhachHang(qThem, qSua, qXoa);
            AddTab(ucKhachHang);
        }

       

        private void acHD_Nhap_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "HÓA ĐƠN NHẬP";
            CHUCNANG_MA = "HD_NHAP";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcHoaDonNhap ucHoaDonNhap = new UcHoaDonNhap(_IdUser, qThem, qSua, qXoa);
            AddTab(ucHoaDonNhap);
        }

        private void acHD_Xuat_Click(object sender, EventArgs e)
        {

            // lblTitle.Text = "HÓA ĐƠN XUẤT";
            CHUCNANG_MA = "HD_XUAT";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcHoaDonXuat ucHoaDonXuat = new UcHoaDonXuat(_IdUser, qThem, qSua, qXoa);
            AddTab(ucHoaDonXuat);
        }

        private void acCapNhatGia_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "CẬP NHẬT GIÁ";
            CHUCNANG_MA = "CN_GIA";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcCapNhatGia ucCapNhatGia = new UcCapNhatGia(qThem, qSua, qXoa);
            AddTab(ucCapNhatGia);
        }

        private void accordion_DangXuat_Click(object sender, EventArgs e)
        {
            IsClose = false;
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void accordion_CauHinhServer_Click(object sender, EventArgs e)
        {
            frmConnect frmConnect = new frmConnect(0);
            frmConnect.ShowDialog();
        }

        private void accordion_CongNo_Click(object sender, EventArgs e)
        {
            CHUCNANG_MA = "CONGNO";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcCongNo ucCongNo = new UcCongNo();
            AddTab(ucCongNo);
        }

        private void acHoaDonXuatDL_Click(object sender, EventArgs e)
        {
            CHUCNANG_MA = "HD_XUATDL";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcHoaDonXuat_DaiLy ucHoaDonXuat_DaiLy = new UcHoaDonXuat_DaiLy(_IdUser, qThem, qSua, qXoa);
            AddTab(ucHoaDonXuat_DaiLy);
        }

        private void acTonKho_Click(object sender, EventArgs e)
        {
            CHUCNANG_MA = "TONKHO";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcTonKho ucTonKho = new UcTonKho();
            AddTab(ucTonKho);
        }

        private void acTKNhapXuat_Click(object sender, EventArgs e)
        {
            CHUCNANG_MA = "DOANHTHU";
            KiemQuyen(_IdUser, CHUCNANG_MA, out qThem, out qSua, out qXoa);
            UcTongDoanhThu ucTongDoanhThu = new UcTongDoanhThu();
            AddTab(ucTongDoanhThu);
        }
    }
}
