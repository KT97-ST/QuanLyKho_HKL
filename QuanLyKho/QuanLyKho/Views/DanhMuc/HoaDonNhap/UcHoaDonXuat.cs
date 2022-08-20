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
using QuanLyKho.Controllers.HoaDonNhap;
using QuanLyKho.Controllers.HoaDonXuat;
using QuanLyKho.Controllers.ClsC_DanhMuc;
using QuanLyKho.Controllers.TonKho;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.Controls;

namespace QuanLyKho.Views.DanhMuc.HoaDonNhap
{
    public partial class UcHoaDonXuat : DevExpress.XtraEditors.XtraUserControl
    {
        /* Biến hứng sản phẩm truyền qua chi tiết hóa đơn*/
        string idSanpham = "";
        string idLoaisanpham = "";
        string idDonvitinh = "";
        string maSanpham = "";
        string tenSanpham = "";
        string tenLoai = "";
        string tenDVT = "";
        decimal giaXuat =0;
        /*---------------------------------------------*/

   
        
        DataTable dtHoaDonChiTiet;
        DataTable dtHoaDonById;
        DataTable dtHoaDonChiTietById;
        DateTime ngayHienTai;
        string soHoaDon = "";
        int stt = 1;
        int STT_HDCT = 1;
        string idHoaDonNhapSelect = "";
        private bool _SaveSuccess = true;
        int idNguoiNhap;
        private string _status = "st_view";
        private bool _loadHD = false;
        bool isTrue;
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
                if (_status != "st_add") { ucThemSuaXoa1.btnThem.Visible = true; }
            }
            else { ucThemSuaXoa1.btnThem.Visible = false; }

            if (qSua)
            {
                if (_status == "st_view") { ucThemSuaXoa1.btnSua.Visible = true; }
            }
            else { ucThemSuaXoa1.btnSua.Visible = false; }
            if (qXoa)
            {
                if (_status == "st_view") { ucThemSuaXoa1.btnXoa.Visible = true; }
            }
            else { ucThemSuaXoa1.btnXoa.Visible = false; }
        }
        public UcHoaDonXuat(int idUser, bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            gvHoaDonXuatCT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            idNguoiNhap = idUser;
            kiemquyen(qt, qs, qx);
        }
        private void setDef()
        {

            CreateSoHoaDon();
            txtMaHoaDon.Text = soHoaDon;
           // txtKhachHang.EditValue = Convert.ToInt64(0);
            txtVAT.EditValue = 10;
            txtThanhTienTruocThue.EditValue = "";
            txtTienThueGTGT.EditValue = "";
            txtSoLo.EditValue = "";
            txtThanhTienSauThue.EditValue = "";
            txtTienConNo.EditValue = "0";
            txtTienDaThanhToan.EditValue = "0";
            txtHinhThucThanhToan.EditValue = "Tiền mặt";

            dtHoaDonChiTiet.Clear();
            ngayHienTai = DateTime.Now;
            if (_status != "st_add")
            {
                txtNgayLap.EditValue = ngayHienTai;
            }
            txtThanhTienTruocThue.ReadOnly = true;
            txtThanhTienSauThue.ReadOnly = true;
            txtTienThueGTGT.ReadOnly = true;
            txtTienConNo.ReadOnly = true;
            _SaveSuccess = true;
            ckThanhToanDu.CheckState = CheckState.Unchecked;
            txtMaHoaDon.EditValue = "";
            setup();
        }
        private void LoadTT()
        {
            check_status(_status);
            STT_HDCT = 1;
           

           
            gcHoaDonXuatCT.DataSource = dtHoaDonChiTiet;
            
            
           // CreateSoHoaDon();
            txtMaHoaDon.Text = soHoaDon;
            txtKhachHang.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("DM_KHACHHANG");
            txtTenNguoiLap.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("DM_NHANVIEN");
          

            txtTenNguoiLap.EditValue = Convert.ToInt64(idNguoiNhap);
            setDef();
            gcDsSanPham.DataSource = ClsC_HoaDonXuat.Instance.GetDanhSachSanPham(Convert.ToDateTime(txtNgayLap.EditValue.ToString()), 0);

        }
        private void check_status(string status)
        {
            if (status == "st_view")//View
            {
                gcDsSanPham.Enabled = false;
                gcHoaDonXuatCT.Enabled = false;
            
                ckThanhToanDu.Enabled = false;


                txtMaHoaDon.Enabled = true;
                txtNgayLap.Enabled = true;
                txtKhachHang.Enabled = true;
                txtSoLo.Enabled = true;
                txtTenNguoiLap.Enabled = true;
                txtVAT.Enabled = true;
                txtHinhThucThanhToan.Enabled = true;
                txtTienDaThanhToan.Enabled = false;
            }
            else if (status == "st_add")
            {
                gcDsSanPham.Enabled = true;
                gcHoaDonXuatCT.Enabled = true;
                ckThanhToanDu.Enabled = true;

                txtVAT.Enabled = true;
                txtNgayLap.Enabled = false;
                txtTienDaThanhToan.Enabled = true;
                //txtMaHoaDon.Enabled             = false;
                //txtNgayLap.Enabled              = false;
                //txtNhaCungCap.Enabled           = false;
                //txtSoLo.Enabled                 = false;
                //txtTenNguoiLap.Enabled          = false;
                //txtVAT.Enabled                  = false;
                //txtHinhThucThanhToan.Enabled    = false;

            }
            else if (status == "st_edit")
            {
               
                gcDsSanPham.Enabled = true;
                gcHoaDonXuatCT.Enabled = true;
                txtTienDaThanhToan.Enabled = true;
                txtVAT.Enabled = true;
                txtNgayLap.Enabled = false;
                ckThanhToanDu.Enabled = true;

            }
        }
        private void CreateDataTableHDCT()
        {

            dtHoaDonChiTiet = new DataTable();
            dtHoaDonChiTiet.Columns.Add("STT", typeof(Int32));
            dtHoaDonChiTiet.Columns.Add("SANPHAM_ID", typeof(Int32));
            dtHoaDonChiTiet.Columns.Add("LOAISANPHAM_ID", typeof(Int32));
            dtHoaDonChiTiet.Columns.Add("DONVITINH_ID", typeof(Int32));
            dtHoaDonChiTiet.Columns.Add("SANPHAM_MA", typeof(String));
            dtHoaDonChiTiet.Columns.Add("SANPHAM_TEN", typeof(String));
            dtHoaDonChiTiet.Columns.Add("LOAISANPHAM_TEN", typeof(String));
            dtHoaDonChiTiet.Columns.Add("DONVITINH_TEN", typeof(String));
            dtHoaDonChiTiet.Columns.Add("GIAXUAT", typeof(Decimal));
            dtHoaDonChiTiet.Columns.Add("SOLUONG", typeof(Decimal));
            dtHoaDonChiTiet.Columns.Add("THANHTIEN", typeof(Decimal));



        }
        private void CreateSoHoaDon()
        {
          //  soHoaDon = "PX"+ngayHienTai.Year.ToString() + ngayHienTai.Month.ToString() + ngayHienTai.Day.ToString()+"-"+stt.ToString().PadLeft(4,'0');
        }
        private void addToHoaDonCT()
        {
            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                foreach (DataRow dr in dtHoaDonChiTiet.Rows)
                {
                    if (dr["SANPHAM_ID"].ToString() == idSanpham)
                    {
                        return;
                    }
                }
            }
            DataRow row = dtHoaDonChiTiet.NewRow();
            row["STT"] = STT_HDCT;
            row["SANPHAM_ID"] = idSanpham;
            row["LOAISANPHAM_ID"] = idLoaisanpham;
            row["DONVITINH_ID"] = idDonvitinh;
            row["SANPHAM_MA"] = maSanpham;
            row["SANPHAM_TEN"] = tenSanpham;
            row["LOAISANPHAM_TEN"] = tenLoai;
            row["DONVITINH_TEN"] = tenDVT;
            row["GIAXUAT"] =giaXuat;
            row["SOLUONG"] = 1;
          

            dtHoaDonChiTiet.Rows.Add(row);

           
            STT_HDCT++;


        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void UcHoaDonNhap_Load(object sender, EventArgs e)
        {
            setup();
            CreateDataTableHDCT();
            LoadTT();
        }
        private Decimal TinhGTGT(decimal thanhtien, decimal VAT)
        {
            decimal tienGTGT = 0;
            tienGTGT = (thanhtien / 100) * VAT;

            return tienGTGT;
        }
        private Decimal TinhNoConLai(decimal Tongthanhtien, decimal DaTra)
        {
            decimal tienNo = 0;
            tienNo = Tongthanhtien - DaTra;

            return tienNo;
        }
        private void LoadThanhTien()

        {

            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                //Thành tiền trước thuê
                txtThanhTienTruocThue.EditValue = gvHoaDonXuatCT.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString();
                //Tiền GTGT
                if (txtVAT.Text != "")
                {


                    decimal thanhTienTruocThue = 0;
                    decimal VAT = 0;
                    
                    thanhTienTruocThue = Convert.ToDecimal(gvHoaDonXuatCT.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
                    VAT = Convert.ToDecimal(txtVAT.EditValue);
                    txtTienThueGTGT.EditValue = TinhGTGT(thanhTienTruocThue, VAT);
                }
                //Thành tiền sau thuế
                decimal thanhTienSauThue = 0;
                decimal daTra = 0;
                thanhTienSauThue = Convert.ToDecimal(txtTienThueGTGT.EditValue) + Convert.ToDecimal(txtThanhTienTruocThue.EditValue);
                daTra = Convert.ToDecimal(txtTienDaThanhToan.EditValue);
                txtThanhTienSauThue.EditValue = thanhTienSauThue;

                txtTienConNo.EditValue = TinhNoConLai(thanhTienSauThue, daTra);
            }
            else
            {
                txtThanhTienTruocThue.EditValue = 0;
                txtTienThueGTGT.EditValue = 0;
                txtThanhTienSauThue.EditValue = 0;
                txtTienDaThanhToan.EditValue = 0;
            }
        }
        private void LoadDsHoaDon()
        {
            gcDsHoaDon.DataSource = ClsC_HoaDonXuat.Instance.GetDanhSachHoaDon(0);
        }
        private void LoadThongTinHoaDon()
        {
            //Thông tin hóa đơn
           // txtTienConNo.EditValue = "";
            dtHoaDonById = new DataTable();
            dtHoaDonById = ClsC_HoaDonXuat.Instance.GetHoaDonById(idHoaDonNhapSelect);

            foreach (DataRow dr in dtHoaDonById.Rows)
            {
                txtMaHoaDon.EditValue = dr["HOADONXUAT_MA"].ToString();
                txtSoLo.EditValue = dr["HOADONXUAT_SOLO"].ToString();
                txtKhachHang.EditValue = Convert.ToInt64(dr["KHACHHANG_ID"].ToString());
                txtNgayLap.EditValue = dr["HOADONXUAT_NGAYLAP"].ToString();
                txtThanhTienTruocThue.EditValue = dr["HOADONXUAT_TONGTIEN"].ToString();
                txtTienThueGTGT.EditValue = dr["HOADONXUAT_TIEN_GTGT"].ToString();
                txtVAT.EditValue = dr["HOADONXUAT_VAT"].ToString();
                txtThanhTienSauThue.EditValue = dr["HOADONXUAT_TONGTIEN_SAUTHUE"].ToString();
                txtTienDaThanhToan.EditValue = dr["HOADONXUAT_SOTIEN_DATHANHTOAN"].ToString();
                txtHinhThucThanhToan.EditValue = dr["HTHUC_THANHTOAN"].ToString();
            }
            // Thông tin hóa đơn chi tiết
            // dtHoaDonChiTietById = new DataTable();
            dtHoaDonChiTiet = ClsC_HoaDonXuat.Instance.GetHoaDonChiTietById(idHoaDonNhapSelect);
            gcHoaDonXuatCT.DataSource = dtHoaDonChiTiet;
            DataRow[] drr = dtHoaDonChiTiet.Select("STT=MAX(STT)");
            for (int i = 0; i < drr.Length; i++)
            {
                STT_HDCT = Convert.ToInt16(drr[i]["STT"].ToString());
            }
            LoadThanhTien();
            //Không cho phép sửa VAT
            _status = "st_view";
            check_status(_status);
            txtVAT.Enabled = false;
            _loadHD = true;
            LoadThanhTien();
            if(Convert.ToDecimal(txtTienDaThanhToan.EditValue.ToString()) == Convert.ToDecimal(txtThanhTienSauThue.EditValue.ToString()))
            {
                ckThanhToanDu.CheckState = CheckState.Checked;
            }
            else
                ckThanhToanDu.CheckState = CheckState.Unchecked;
        }
        private void gvDsSanPham_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                int[] selectedRows = gvDsSanPham.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        idSanpham = gvDsSanPham.GetRowCellValue(rowHandle, "SANPHAM_ID").ToString();
                    idLoaisanpham = gvDsSanPham.GetRowCellValue(rowHandle, "LOAISANPHAM_ID").ToString();
                    idDonvitinh = gvDsSanPham.GetRowCellValue(rowHandle, "DONVITINH_ID").ToString();
                    maSanpham = gvDsSanPham.GetRowCellValue(rowHandle, "SANPHAM_MA").ToString();
                    tenSanpham = gvDsSanPham.GetRowCellValue(rowHandle, "SANPHAM_TEN").ToString();
                    tenLoai = gvDsSanPham.GetRowCellValue(rowHandle, "LOAISANPHAM_TEN").ToString();
                    tenDVT = gvDsSanPham.GetRowCellValue(rowHandle, "DONVITINH_TEN").ToString();
                    giaXuat = Convert.ToDecimal(gvDsSanPham.GetRowCellValue(rowHandle, "GIAXUAT").ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            addToHoaDonCT();
            //grid chi tiết thay đổi
            //if (dtHoaDonChiTiet.GetChanges() != null)
            //{
            //    if (dtHoaDonChiTiet.Rows.Count > 0)
            //    {
            //        for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
            //        {
            //            dtHoaDonChiTiet.Rows[i]["THANHTIEN"] = Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["SOLUONG"]) * Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["GIAXUAT"]);
            //        }
            //    }
            //}
            LoadThanhTien_inGrid();
            LoadThanhTien();
        }
        private void LoadThanhTien_inGrid()
        {
            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
                {
                    DataRow dr = dtHoaDonChiTiet.Rows[i];
                    if (dr.RowState == DataRowState.Unchanged) continue;
                    if (gvHoaDonXuatCT.RowCount > 0)
                        if (dr["SOLUONG"] != DBNull.Value && dr["GIAXUAT"] != DBNull.Value)
                            dr["THANHTIEN"] = Convert.ToDecimal(dr["SOLUONG"]) * Convert.ToDecimal(dr["GIAXUAT"]);

                }

            }
        }
        private void gcDsSanPham_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void Save_HD()
        {
            if (_status == "st_add")
            {
                if (dtHoaDonChiTiet.Rows.Count > 0)
                {
                    try
                    {
                        idHoaDonNhapSelect = "";
                        //Chỗ này insert hóa đơn , đồng thời get id hóa đơn vừa thêm vô
                        idHoaDonNhapSelect = ClsC_HoaDonXuat.Instance.InsertHoaDonXuat(txtMaHoaDon.EditValue.ToString(),
                                                                                    txtSoLo.EditValue.ToString(),
                                                                                    txtKhachHang.EditValue.ToString(),
                                                                                    txtTenNguoiLap.EditValue.ToString(),
                                                                                    Convert.ToDateTime(txtNgayLap.EditValue.ToString()),
                                                                                    txtThanhTienTruocThue.EditValue.ToString(),
                                                                                    txtVAT.EditValue.ToString(),
                                                                                    txtThanhTienSauThue.EditValue.ToString(),
                                                                                    txtTienDaThanhToan.EditValue.ToString(),
                                                                                    txtHinhThucThanhToan.EditValue.ToString(),
                                                                                    0);
                        if(idHoaDonNhapSelect=="")
                        {
                            MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _status = "st_add";
                            return;
                        }
                        //Chỗ này insert chi tiết hóa đơn
                        foreach (DataRow dt in dtHoaDonChiTiet.Rows)
                        {
                           isTrue= ClsC_HoaDonXuat.Instance.InsertHoaDonXuat_CT(idHoaDonNhapSelect, dt["SANPHAM_ID"].ToString(), dt["SOLUONG"].ToString(), dt["GIAXUAT"].ToString(), dt["THANHTIEN"].ToString(), Convert.ToDateTime(txtNgayLap.EditValue.ToString()));
                        }
                        stt++;
                        dtHoaDonChiTiet.Clear();
                        //UcHoaDonNhap uc = new UcHoaDonNhap();
                        //uc.Refresh();
                        CreateSoHoaDon();
                        UcHoaDonNhap_Load(this, null);
                        if(isTrue)
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _status = "st_view";
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _status = "st_add";
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _status = "st_add";
                    }
                }


            }
            else if (_status == "st_edit")
            {
                try
                {
                   isTrue= ClsC_HoaDonXuat.Instance.UpdateHoaDonXuat(idHoaDonNhapSelect,
                                                          txtSoLo.EditValue.ToString(),
                                                          txtKhachHang.EditValue.ToString(), txtTenNguoiLap.EditValue.ToString(),

                                                          txtThanhTienTruocThue.EditValue.ToString(),
                                                          txtVAT.EditValue.ToString(),
                                                          txtThanhTienSauThue.EditValue.ToString(),
                                                          txtTienDaThanhToan.EditValue.ToString(),
                                                          txtHinhThucThanhToan.EditValue.ToString());
                    if(!isTrue)
                    {
                        MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataRow dr;
                    int ret = 0;
                    for (int i = 0; i <= gvHoaDonXuatCT.RowCount; i++)
                    {
                        dr = gvHoaDonXuatCT.GetDataRow(i);
                        if (dr == null) continue;

                        if (dr.RowState == DataRowState.Unchanged) continue;

                        int id = 0;
                        string idSanPham;
                        string soLuong;
                        string giaXuat;
                        string thanhTien;
                       
                        // trường hợp khi thêm mới id sẽ null nên gán không dc
                        if (!dr.IsNull("HOADONXUATCT_ID"))
                        {
                            id = Convert.ToInt32(dr["HOADONXUATCT_ID"].ToString());
                        }
                        soLuong = dr["SOLUONG"].ToString();
                        idSanPham = dr["SANPHAM_ID"].ToString();
                        giaXuat = dr["GIAXUAT"].ToString();
                        thanhTien = dr["THANHTIEN"].ToString();
                     

                        if (string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(thanhTien)) continue;

                        if (dr.RowState == DataRowState.Modified)
                        {
                            // kiểm tra rổng va null
                            if (id <= 0) continue;
                            //Hàm update HD_CT
                          isTrue =   ClsC_HoaDonXuat.Instance.UpdateHoaDonXuat_CT(idHoaDonNhapSelect, id.ToString(), idSanPham, soLuong, thanhTien);
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            isTrue = ClsC_HoaDonXuat.Instance.InsertHoaDonXuat_CT(idHoaDonNhapSelect, idSanpham, soLuong, giaXuat, thanhTien, Convert.ToDateTime(txtNgayLap.EditValue.ToString()));
                        }
                    }
                    if (ret > 0)
                    {
                        //loadDVT();
                    }
                    if(isTrue)
                    {
                        MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //string Getidhoadonnhap = "";
            ////Getidhoadonnhap = ClsC_HoaDonXuat.Instance.InsertHoaDonNhap(soHoaDon, "Lo1", "1", "1", txtNgayLap.EditValue.ToString(), 1000);
            //foreach (DataRow dt in dtHoaDonChiTiet.Rows)
            //{
            //    // ClsC_HoaDonXuat.Instance.InsertHoaDonNhap_CT(Getidhoadonnhap, dt["SANPHAM_ID"].ToString(), dt["SOLUONG"].ToString(), dt["GIAXUAT"].ToString(), dt["THANHTIEN"].ToString(), txtNgayLap.EditValue.ToString());
            //}
            //stt++;
            //dtHoaDonChiTiet.Clear();
            ////UcHoaDonNhap uc = new UcHoaDonNhap();
            ////uc.Refresh();
            //CreateSoHoaDon();
            //UcHoaDonNhap_Load(this, null);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            

        }

        private void gvHoaDonNhapCT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (dtHoaDonChiTiet.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
            //    {
            //        dtHoaDonChiTiet.Rows[i]["THANHTIEN"] = Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["SOLUONG"]) * Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["GIAXUAT"]);
            //    }
            //}
            
            LoadThanhTien_inGrid();
            LoadThanhTien();
        }

        private void gvHoaDonNhapCT_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
         
        }

        private void gvHoaDonNhapCT_RowCountChanged(object sender, EventArgs e)
        {
            //if(dtHoaDonChiTiet.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
            //    {
            //        dtHoaDonChiTiet.Rows[i]["THANHTIEN"] = Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["SOLUONG"]) * Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["GIANHAP"]);
            //    }
            //}
          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gvHoaDonXuatCT_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gvHoaDonXuatCT_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void gcHoaDonNhapCT_DefaultViewChanged(object sender, EventArgs e)
        {

        }

        private void gvHoaDonXuatCT_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
        }

        private void gcHoaDonNhapCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                LoadThanhTien_inGrid();
                LoadThanhTien();
            }
        }

        private void txtNgayLap_EditValueChanged(object sender, EventArgs e)
        {
            try
           {
                gcDsSanPham.DataSource = ClsC_HoaDonXuat.Instance.GetDanhSachSanPham(Convert.ToDateTime(txtNgayLap.EditValue.ToString()), 0);
            }
            catch
            {

            }

        }

        private void ucThemSuaXoa1_BtnThemClick(object sender, EventArgs e)
        {
            if (_SaveSuccess)
            {
                idHoaDonNhapSelect = "";
                _status = "st_add";
                LoadTT();
            }
           
        }

        private void ucThemSuaXoa1_BtnLuuClick(object sender, EventArgs e)
        {
            if(CheckLuu())
            {
                LoadThanhTien_inGrid();
                LoadThanhTien();

                Save_HD();
                idHoaDonNhapSelect = "";
                _status = "st_view";
                _loadHD = false;
                check_status(_status);
                
                //setDef();
                LoadTT();
            }
            else
            {
                _SaveSuccess = false;
                ucThemSuaXoa1.btnThem.PerformClick();
            }
           
        }

        private void ucThemSuaXoa1_BtnHuyBoClick(object sender, EventArgs e)
        {
            _status = "st_view";
            _loadHD = false;
            check_status(_status);
            //LoadTT();
            setDef();
        }

        private void ucThemSuaXoa1_BtnThoatClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadThanhTien();
        }

        private void txtTienDaThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtThanhTienSauThue_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTienDaThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            
            LoadThanhTien();
            if (Convert.ToDecimal(txtTienDaThanhToan.EditValue.ToString()) == Convert.ToDecimal(txtThanhTienSauThue.EditValue.ToString()))
            {
                ckThanhToanDu.CheckState = CheckState.Checked;
            }
            else
                ckThanhToanDu.CheckState = CheckState.Unchecked;
        }

        private void gvHoaDonXuatCT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            LoadThanhTien_inGrid();
            LoadThanhTien();
        }

        private void gcHoaDonNhapCT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteHoaDonCT();
            }
        }

        private void gcHoaDonNhapCT_MouseClick(object sender, MouseEventArgs e)
        {

            LoadThanhTien_inGrid();
            LoadThanhTien();
        }

        private void txtMaHoaDon_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (_status == "st_view")
            {
            
                popUpDsHoaDon.Show();
                Point p = new Point(this.Parent.Width / 2 - this.Width / 2, this.Parent.Height / 2 - this.Height / 2);
                popUpDsHoaDon.Location = p;
                LoadDsHoaDon();
            }
        }
        private bool CheckLuu()
        {

            if (txtMaHoaDon.EditValue == ""
                 || txtNgayLap.EditValue == ""
                 || txtTenNguoiLap.EditValue == ""
                 || txtSoLo.EditValue == ""
                 || txtVAT.EditValue == "" ||
                 txtHinhThucThanhToan.EditValue == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if (gvHoaDonXuatCT.RowCount <= 0)
            {
                MessageBox.Show("Vui lòng nhập chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (gvHoaDonXuatCT.RowCount > 0)
            {
                for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
                {
                    DataRow dr = dtHoaDonChiTiet.Rows[i];

                    if (dr["SOLUONG"] != DBNull.Value && dr["GIAXUAT"] != DBNull.Value)
                        dr["THANHTIEN"] = Convert.ToDecimal(dr["SOLUONG"]) * Convert.ToDecimal(dr["GIAXUAT"]);

                }
                if(Convert.ToDecimal(txtTienConNo.EditValue.ToString())<0)
                {
                    MessageBox.Show("Số tiền còn nợ không thể âm. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            ucThemSuaXoa1.btnLuu.Enabled = true;
            return true;
        }
        private void DeleteHoaDonCT()
        {

            DataRow dr = gvHoaDonXuatCT.GetFocusedDataRow();
            if (dr == null)
            {
                MessageBox.Show("Dữ liệu không được chọn");
            }
            else
            {
                
                    if (dr.RowState == DataRowState.Added)
                    {
                         DialogResult dlgResult = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlgResult == DialogResult.Yes)
                        {
                        gvHoaDonXuatCT.DeleteRow(gvHoaDonXuatCT.FocusedRowHandle);
                      
                        LoadThanhTien();
                        }
                             


                    }
                    else
                    {
                    MessageBox.Show("Dữ lệu đã thêm trước đó, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
        }
        private void btnThoatpopup_Click(object sender, EventArgs e)
        {
            popUpDsHoaDon.Hide();
        }

        private void btnChonpopup_Click(object sender, EventArgs e)
        {
            idHoaDonNhapSelect = "";
            try
            {


                int[] selectedRows = gvDsHoaDon.GetSelectedRows();
                foreach (int rowHandle in selectedRows)
                {
                    if (rowHandle >= 0)
                        idHoaDonNhapSelect = gvDsHoaDon.GetRowCellValue(rowHandle, "HOADONXUAT_ID").ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            popUpDsHoaDon.Hide();
            LoadThongTinHoaDon();
        }

        private void txtTienDaThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            ///LoadThanhTien();
        }

        private void ucThemSuaXoa1_BtnSuaClick(object sender, EventArgs e)
        {
            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                _status = "st_edit";
                check_status(_status);
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void gvHoaDonXuatCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string checkNumber = "";
            GridView view = sender as GridView;
            view.ClearColumnErrors();
            GridColumn ColSoLuong = view.Columns["SOLUONG"];
      
            int so = gvHoaDonXuatCT.FocusedRowHandle;
            DataRow dataRow = gvHoaDonXuatCT.GetFocusedDataRow();
            if (dataRow == null) return;
            // kiểm tra rỗng
            if (string.IsNullOrEmpty(dataRow["SOLUONG"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không cho phép rỗng");
                return;

            }
            if (Convert.ToDecimal(dataRow["SOLUONG"].ToString())<0)
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không được phép âm");
                return;
            }
            if (Convert.ToDecimal(dataRow["SOLUONG"].ToString()) > 0)
            {
                decimal inPutSoLuong = 0;
                decimal soLuongGetKho = 0;
                inPutSoLuong = Convert.ToDecimal(dataRow["SOLUONG"].ToString());
                soLuongGetKho =Convert.ToDecimal(ClsC_TonKho.Instance.GetTonKhoByIdSP(dataRow["SANPHAM_ID"].ToString()));
               if(inPutSoLuong> soLuongGetKho)
                {
                   MessageBox.Show("Số lượng xuất vượt quá số lượng sản phẩm trong kho!"+"\n" +dataRow["SANPHAM_TEN"].ToString()+" chỉ còn "+ string.Format("{0:n0}",soLuongGetKho.ToString()) +" " + dataRow["DONVITINH_TEN"].ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    view.SetColumnError(ColSoLuong, "Số lượng xuất vượt quá số lượng sản phẩm trong kho!");
                    return;
                }
            }

            if (IsNumber(dataRow["SOLUONG"].ToString()) == false)
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không hợp lệ");
                // checkNumber = "Số lượng không hợp lệ";

            }
        }

        private void gvHoaDonXuatCT_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //string checkNumber = "";
            //GridView view = sender as GridView;
            //view.ClearColumnErrors();
            //GridColumn ColSoLuong = view.Columns["SOLUONG"];

            //int so = gvHoaDonXuatCT.FocusedRowHandle;
            //DataRow dataRow = gvHoaDonXuatCT.GetFocusedDataRow();
            //if (dataRow == null) return;
            //// kiểm tra rỗng
            //if (string.IsNullOrEmpty(dataRow["SOLUONG"].ToString()))
            //{
            //    e.Valid = false;
            //    view.SetColumnError(ColSoLuong, "Số lượng không cho phép rỗng");

            //}
            //else if (Convert.ToDecimal(dataRow["SOLUONG"].ToString()) < 0)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(ColSoLuong, "Số lượng không được phép âm");
            //}


            //if (IsNumber(dataRow["SOLUONG"].ToString()) == false)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(ColSoLuong, "Số lượng không hợp lệ");
            //    // checkNumber = "Số lượng không hợp lệ";

            //}
        }

        private void gvHoaDonXuatCT_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            (sender as GridView).ShowEditor();
        }
        private void checkThanhtoan()
        {
            if (ckThanhToanDu.Checked)
            {
                ckThanhToanDu.ForeColor = Color.Green;
                ckThanhToanDu.Text = "Đã thanh toán đủ!";
                txtTienDaThanhToan.EditValue = txtThanhTienSauThue.EditValue;
                txtTienConNo.EditValue = 0;
                txtTienDaThanhToan.ReadOnly = true;
            }
            else
            {
                txtTienDaThanhToan.ReadOnly = false;
                ckThanhToanDu.ForeColor = Color.Crimson;
                ckThanhToanDu.Text = "Chưa thanh toán đủ!";
                txtTienDaThanhToan.EditValue = 0;
                txtTienConNo.EditValue = txtThanhTienSauThue.EditValue;
            }
        }
        private void ckThanhToanDu_CheckedChanged(object sender, EventArgs e)
        {
            checkThanhtoan();
        }
    }
}
