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
using QuanLyKho.Controllers.ClsC_DanhMuc;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.Controls;
using QuanLyKho;

namespace QuanLyKho.Views.DanhMuc.HoaDonNhap
{
    public partial class UcHoaDonNhap : DevExpress.XtraEditors.XtraUserControl
    {
        /* Biến hứng sản phẩm truyền qua chi tiết hóa đơn*/
        string idSanpham = "";
        string idLoaisanpham = "";
        string idDonvitinh = "";
        string maSanpham = "";
        string tenSanpham = "";
        string tenLoai = "";
        string tenDVT = "";
        /*---------------------------------------------*/

        DataTable dtHoaDonChiTiet;
        DataTable dtHoaDonById;
        DataTable dtHoaDonChiTietById;
        DateTime ngayHienTai;
        string soHoaDon = "";
        int stt = 1;
        int STT_HDCT = 1;
        string idHoaDonNhapSelect = "";
        string id = "";
        bool isTrue = true;
        public int idNguoiNhap;
        private string _status = "st_view";
        private bool _loadHD = false;
        private bool _SaveSuccess = true;
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
                if (_status!="st_add") { ucThemSuaXoa1.btnThem.Visible = true; }
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
        public UcHoaDonNhap( int idUser, bool qt, bool qs, bool qx)
        {
            InitializeComponent();
            
            gvHoaDonNhapCT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            idNguoiNhap = idUser;
            kiemquyen(qt, qs, qx);
        }
        private void setDef()
        {
            // CreateSoHoaDon();

            
                dtHoaDonChiTiet.Clear();
           
              
            txtNhaCungCap.EditValue = Convert.ToInt64(0);
            txtVAT.EditValue = 10;
            txtThanhTienTruocThue.EditValue = "";
            txtThueGTGT.EditValue = "";
            txtSoLo.EditValue = "";
            txtThanhTienSauThue.EditValue = "";
            txtHinhThucThanhToan.EditValue = "Tiền mặt";
            txtTenNguoiLap.EditValue = Convert.ToInt64(idNguoiNhap.ToString());
            txtThanhTienTruocThue.ReadOnly = true;
            txtThanhTienSauThue.ReadOnly = true;
            txtThueGTGT.ReadOnly = true;
            _SaveSuccess = true;
            ngayHienTai = DateTime.Now;
            txtNgayLap.EditValue = ngayHienTai;
            txtMaHoaDon.EditValue = "";
            setup();
        }
        private void LoadTT()
        {
            check_status(_status);
            STT_HDCT = 1;
          
           
            
            
            gcDsSanPham.DataSource = ClsC_HoaDonNhap.Instance.GetDanhSachSanPham();
            gcHoaDonNhapCT.DataSource = dtHoaDonChiTiet;
         
            
         
            txtNhaCungCap.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("DM_NHACUNGCAP");
            txtNhaCungCap.Properties.DisplayMember = "NHACUNGCAP_TEN";
            txtNhaCungCap.Properties.ValueMember= "NHACUNGCAP_ID";
            txtTenNguoiLap.Properties.DataSource = ClsC_DanhMuc.Instance.GetDataDanhMuc("DM_NHANVIEN");
            txtTenNguoiLap.Properties.DisplayMember = "NHANVIEN_TEN";
            txtTenNguoiLap.Properties.ValueMember = "NHANVIEN_ID";
            
            setDef();

        }
       private void check_status(string status)
        {
            if(status =="st_view")//View
            {
                gcDsSanPham.Enabled = false;
                gcHoaDonNhapCT.Enabled = false;


                txtMaHoaDon.Enabled = true;
                txtNgayLap.Enabled = true;
                txtNhaCungCap.Enabled = true;
                txtSoLo.Enabled = true;
                txtTenNguoiLap.Enabled = true;
                txtVAT.Enabled = true;
                txtHinhThucThanhToan.Enabled = true;
            } else if(status =="st_add")
            {
                gcDsSanPham.Enabled = true;
                gcHoaDonNhapCT.Enabled = true;
                txtVAT.Enabled = true;
                //txtMaHoaDon.Enabled             = false;
                //txtNgayLap.Enabled              = false;
                //txtNhaCungCap.Enabled           = false;
                //txtSoLo.Enabled                 = false;
                //txtTenNguoiLap.Enabled          = false;
                //txtVAT.Enabled                  = false;
                //txtHinhThucThanhToan.Enabled    = false;

            }else if (status == "st_edit")
            {
                gcDsSanPham.Enabled = true;
                gcHoaDonNhapCT.Enabled = true;
                txtVAT.Enabled = true;
                txtNgayLap.Enabled = false;


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
            dtHoaDonChiTiet.Columns.Add("GIANHAP", typeof(Decimal));
            dtHoaDonChiTiet.Columns.Add("SOLUONG", typeof(Decimal));
            dtHoaDonChiTiet.Columns.Add("THANHTIEN", typeof(Decimal));



        }
        private void CreateSoHoaDon()
        {
            //soHoaDon = "PN"+ngayHienTai.Year.ToString() + ngayHienTai.Month.ToString() + ngayHienTai.Day.ToString()+"-"+stt.ToString().PadLeft(4,'0');

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
            row["SOLUONG"] = 1;
            row["GIANHAP"] = 0;

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
        private Decimal TinhGTGT( decimal thanhtien, decimal VAT)
        {
            decimal tienGTGT = 0;
            tienGTGT = (thanhtien / 100) * VAT;

            return tienGTGT;
        }
        private void LoadThanhTien()
        {
            
            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                //Thành tiền trước thuê
                txtThanhTienTruocThue.EditValue = gvHoaDonNhapCT.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString();
                //Tiền GTGT
                if (txtVAT.Text != "")
                {

       
                    decimal thanhTienTruocThue = 0;
                    decimal VAT = 0;
                    thanhTienTruocThue = Convert.ToDecimal(gvHoaDonNhapCT.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString());
                    VAT = Convert.ToDecimal(txtVAT.EditValue);
                    txtThueGTGT.EditValue = TinhGTGT(thanhTienTruocThue, VAT);
                }
                //Thành tiền sau thuế

                txtThanhTienSauThue.EditValue = Convert.ToDecimal(txtThueGTGT.EditValue)+ Convert.ToDecimal(txtThanhTienTruocThue.EditValue);
            }
            else
            {
                
               txtThanhTienTruocThue.EditValue = 0;
                txtThueGTGT.EditValue = 0;
                txtThanhTienSauThue.EditValue = 0;
            }
        }
        //Load Hóa đơn nè

        private void LoadDsHoaDon()
        {
            gcDsHoaDon.DataSource = ClsC_HoaDonNhap.Instance.GetDanhSachHoaDon();
        }

        private void LoadThongTinHoaDon()
        {
            //Thông tin hóa đơn
            dtHoaDonById = new DataTable();
            dtHoaDonById = ClsC_HoaDonNhap.Instance.GetHoaDonById(idHoaDonNhapSelect);
           
            foreach (DataRow dr in dtHoaDonById.Rows)
            {
                txtMaHoaDon.EditValue = dr["HOADONNHAP_MA"].ToString();
                txtSoLo.EditValue = dr["HOADONNHAP_SOLO"].ToString();
                txtNhaCungCap.EditValue =Convert.ToInt64( dr["NHACUNGCAP_ID"].ToString());
                txtNgayLap.EditValue = dr["HOADONNHAP_NGAYNHAP"].ToString();
                txtThanhTienTruocThue.EditValue = dr["HOADONNHAP_TONGTIEN"].ToString();
                txtThueGTGT.EditValue = dr["HOADONNHAP_TIEN_GTGT"].ToString();
                txtVAT.EditValue = dr["HOADONNHAP_VAT"].ToString();
                txtThanhTienSauThue.EditValue = dr["HOADONNHAP_TONGTIEN_SAUTHUE"].ToString();
                txtHinhThucThanhToan.EditValue = dr["HTHUC_THANHTOAN"].ToString();
            }
            // Thông tin hóa đơn chi tiết
           // dtHoaDonChiTietById = new DataTable();
            dtHoaDonChiTiet = ClsC_HoaDonNhap.Instance.GetHoaDonChiTietById(idHoaDonNhapSelect);
            gcHoaDonNhapCT.DataSource = dtHoaDonChiTiet;
            DataRow[] drr = dtHoaDonChiTiet.Select("STT=MAX(STT)");
            for(int i=0;i<drr.Length;i++)
            {
                STT_HDCT =Convert.ToInt16( drr[i]["STT"].ToString());
            }
          
            //Không cho phép sửa VAT
            _status = "st_view";
            check_status(_status);
            txtVAT.Enabled = false;
            _loadHD = true;

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
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            addToHoaDonCT();
            //if (dtHoaDonChiTiet.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
            //    {
            //        dtHoaDonChiTiet.Rows[i]["THANHTIEN"] = Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["SOLUONG"]) * Convert.ToDecimal(dtHoaDonChiTiet.Rows[i]["GIANHAP"]);
            //    }

            //}
            LoadThanhTien_inGrid();
            LoadThanhTien();
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
                if(dtHoaDonChiTiet.Rows.Count>0)
                {
                    try
                    {
                         isTrue = true;
                        idHoaDonNhapSelect = "";
                        //Chỗ này insert hóa đơn , đồng thời get id hóa đơn vừa thêm vô
                        idHoaDonNhapSelect = ClsC_HoaDonNhap.Instance.InsertHoaDonNhap(txtMaHoaDon.EditValue.ToString(),
                                                                                    txtSoLo.EditValue.ToString(),
                                                                                    txtNhaCungCap.EditValue.ToString(),
                                                                                    txtTenNguoiLap.EditValue.ToString(),
                                                                                    Convert.ToDateTime(txtNgayLap.EditValue.ToString()),
                                                                                    txtThanhTienTruocThue.EditValue.ToString(),
                                                                                    txtVAT.EditValue.ToString(),
                                                                                    txtThanhTienSauThue.EditValue.ToString(),
                                                                                    txtHinhThucThanhToan.EditValue.ToString());
                        if(idHoaDonNhapSelect=="")
                        {
                            MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //Chỗ này insert chi tiết hóa đơn
                        foreach (DataRow dt in dtHoaDonChiTiet.Rows)
                        {
                            isTrue= ClsC_HoaDonNhap.Instance.InsertHoaDonNhap_CT(idHoaDonNhapSelect, dt["SANPHAM_ID"].ToString(), dt["SOLUONG"].ToString(), dt["GIANHAP"].ToString(), dt["THANHTIEN"].ToString(), Convert.ToDateTime(txtNgayLap.EditValue.ToString()));
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
                        }
                        else
                            MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
              
            }else if(_status=="st_edit")
            {
                try
                {

                    isTrue = ClsC_HoaDonNhap.Instance.UpdateHoaDonNhap(idHoaDonNhapSelect,
                                                            txtSoLo.EditValue.ToString(),
                                                            txtNhaCungCap.EditValue.ToString(),
                                                            txtTenNguoiLap.EditValue.ToString(),

                                                            txtThanhTienTruocThue.EditValue.ToString(),
                                                            txtVAT.EditValue.ToString(),
                                                            txtThanhTienSauThue.EditValue.ToString(),
                                                            txtHinhThucThanhToan.EditValue.ToString());
                    
                    DataRow dr;
                    int ret = 0;
                    for (int i = 0; i <= gvHoaDonNhapCT.RowCount; i++)
                    {
                        dr = gvHoaDonNhapCT.GetDataRow(i);
                        if (dr == null) continue;

                        if (dr.RowState == DataRowState.Unchanged) continue;

                        int id = 0;
                        string idSanPham;
                        string soLuong;
                        string giaNhap;
                        string thanhTien;
                        DateTime ngayNhap;
                        // trường hợp khi thêm mới id sẽ null nên gán không dc
                        if (!dr.IsNull("HOADONNHAPCT_ID"))
                        {
                            id = Convert.ToInt32(dr["HOADONNHAPCT_ID"].ToString());
                        }
                        soLuong = dr["SOLUONG"].ToString();
                        idSanPham = dr["SANPHAM_ID"].ToString();
                        giaNhap = dr["GIANHAP"].ToString();
                        thanhTien = dr["THANHTIEN"].ToString();
                        ngayNhap = Convert.ToDateTime(txtNgayLap.EditValue.ToString());

                        if (string.IsNullOrEmpty(giaNhap) || string.IsNullOrEmpty(thanhTien)) continue;

                        if (dr.RowState == DataRowState.Modified)
                        {
                            // kiểm tra rổng va null
                            if (id <= 0) continue;
                            //Hàm update HD_CT
                           isTrue =  ClsC_HoaDonNhap.Instance.UpdateHoaDonNhap_CT(idHoaDonNhapSelect, id.ToString(), idSanPham, soLuong, giaNhap, thanhTien, ngayNhap);
                        }
                        if (dr.RowState == DataRowState.Added)
                        {
                            isTrue = ClsC_HoaDonNhap.Instance.InsertHoaDonNhap_CT(idHoaDonNhapSelect, idSanpham, soLuong, giaNhap, thanhTien, ngayNhap);
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
                catch(Exception ex)
                {
                    MessageBox.Show("Lưu không thành công!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }else if(_status == "st_delete")
            {
                //ClsC_HoaDonNhap.Instance.DeleteHoaDonNhapCT(id);
                //ClsC_HoaDonNhap.Instance.UpdateHoaDonNhap(idHoaDonNhapSelect,
                //                                  txtSoLo.EditValue.ToString(),
                //                                  txtNhaCungCap.EditValue.ToString(), 1.ToString(),

                //                                  txtThanhTienTruocThue.EditValue.ToString(),
                //                                  txtVAT.EditValue.ToString(),
                //                                  txtThanhTienSauThue.EditValue.ToString(),
                //                                  txtHinhThucThanhToan.EditValue.ToString());
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           

        }
        private bool CheckLuu()
        {
            
           if( txtMaHoaDon.EditValue==""
                || txtNgayLap.EditValue==""
                ||txtTenNguoiLap.EditValue==""
                ||txtSoLo.EditValue==""
                ||txtVAT.EditValue=="" ||
                txtHinhThucThanhToan.EditValue=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return false;
            }else if(gvHoaDonNhapCT.RowCount<=0)
            {
                MessageBox.Show("Vui lòng nhập chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else if(gvHoaDonNhapCT.RowCount > 0)
            {
                for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
                {
                    DataRow dr = dtHoaDonChiTiet.Rows[i];
                   
                    if (dr["SOLUONG"] != DBNull.Value && dr["GIANHAP"] != DBNull.Value)
                        dr["THANHTIEN"] = Convert.ToDecimal(dr["SOLUONG"]) * Convert.ToDecimal(dr["GIANHAP"]);

                }
            }
            //ucThemSuaXoa1.btnLuu.Enabled = true;
            return true;
        }
        private void LoadThanhTien_inGrid()
        {
            if (dtHoaDonChiTiet.Rows.Count > 0)
            {
                for (int i = 0; i < dtHoaDonChiTiet.Rows.Count; i++)
                {
                    DataRow dr = dtHoaDonChiTiet.Rows[i];
                    if (dr.RowState == DataRowState.Unchanged) continue;
                  if(gvHoaDonNhapCT.RowCount>0)
                    if(dr["SOLUONG"]!=DBNull.Value&& dr["GIANHAP"] != DBNull.Value)
                        dr["THANHTIEN"] = Convert.ToDecimal(dr["SOLUONG"]) * Convert.ToDecimal(dr["GIANHAP"]);

                }

            }
        }
        private void gvHoaDonNhapCT_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
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

        private void gcHoaDonNhapCT_Click(object sender, EventArgs e)
        {
            LoadThanhTien();
        }

        private void gcHoaDonNhapCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gvHoaDonNhapCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                LoadThanhTien();
            }
           

        }

        private void gvHoaDonNhapCT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                LoadThanhTien();
            }
            //if (e.KeyChar == (Char) Keys.Delete)
            //{
            //DeleteHoaDonCT();
            //}
    }

        private void txtPhuongThucThanhToan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucThemSuaXoa1_BtnThemClick(object sender, EventArgs e)
        {
            if(_SaveSuccess)
            {
                idHoaDonNhapSelect = "";
                _status = "st_add";
                check_status(_status);
                LoadTT();
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
                //LoadTT();
                setDef();
            }else
            {
                _SaveSuccess = false;
                ucThemSuaXoa1.btnThem.PerformClick();
            }
        }

        private void txtMaHoaDon_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(_status=="st_view")
            {
                popUpDsHoaDon.Show();
                Point p = new Point(this.Parent.Width / 2 - this.Width / 2, this.Parent.Height / 2 - this.Height / 2);
                popUpDsHoaDon.Location = p;
                LoadDsHoaDon();
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
                        idHoaDonNhapSelect = gvDsHoaDon.GetRowCellValue(rowHandle, "HOADONNHAP_ID").ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            popUpDsHoaDon.Hide();
            LoadThongTinHoaDon();

        }

        private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadThanhTien();
        }

        private void ucThemSuaXoa1_BtnSuaClick(object sender, EventArgs e)
        {
            //if (_loadHD == true)//Nếu đang load hóa đơn cũ thì mới bấm được nút sửa
            //{
            //      _status = "st_edit";
            //    check_status(_status);

            //}
            if(dtHoaDonChiTiet.Rows.Count>0)
            {
                _status = "st_edit";
                check_status(_status);
            }
          
           


        }

        private void gcHoaDonNhapCT_Leave(object sender, EventArgs e)
        {
            LoadThanhTien();
        }

        private void gcHoaDonNhapCT_MouseClick(object sender, MouseEventArgs e)
        {
            LoadThanhTien_inGrid();
            LoadThanhTien();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void gvHoaDonNhapCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            string checkNumber = "";
            GridView view = sender as GridView;
            view.ClearColumnErrors();
            GridColumn ColSoLuong = view.Columns["SOLUONG"];
            GridColumn ColGia = view.Columns["GIANHAP"];
            int so = gvHoaDonNhapCT.FocusedRowHandle;
            DataRow dataRow = gvHoaDonNhapCT.GetFocusedDataRow();
            if (dataRow == null) return;
            // kiểm tra rỗng
            if (string.IsNullOrEmpty(dataRow["SOLUONG"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không cho phép rỗng");
               
                return;
              
            }
            if (string.IsNullOrEmpty(dataRow["GIANHAP"].ToString()))
            {
                e.Valid = false;
                view.SetColumnError(ColGia, "Giá không cho phép rỗng");
               
            }
             if (Convert.ToDecimal(dataRow["SOLUONG"].ToString()) < 0)
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không được phép âm");
                return;
            }
            

            if (IsNumber(dataRow["SOLUONG"].ToString()) == false)
            {
                e.Valid = false;
                view.SetColumnError(ColSoLuong, "Số lượng không hợp lệ");
                // checkNumber = "Số lượng không hợp lệ";
               
            }
        }

        private void gvHoaDonNhapCT_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            (sender as GridView).ShowEditor();
        }
        private void DeleteHoaDonCT()
        {

            DataRow dr = gvHoaDonNhapCT.GetFocusedDataRow();
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
                        gvHoaDonNhapCT.DeleteRow(gvHoaDonNhapCT.FocusedRowHandle);

                        LoadThanhTien();
                    }
                }
                else
                {
                    MessageBox.Show("Dữ lệu đã thêm trước đó, không thể xóa!", "Thông báo", MessageBoxButtons.OK);

                }
                
            }
        }
        private void ucThemSuaXoa1_BtnXoaClick(object sender, EventArgs e)
        {
           
        }

        private void gvHoaDonNhapCT_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            //string checkNumber = "";
            //GridView view = sender as GridView;
            //view.ClearColumnErrors();
            //GridColumn ColSoLuong = view.Columns["SOLUONG"];
            //int so = gvHoaDonNhapCT.FocusedRowHandle;
            //DataRow dataRow = gvHoaDonNhapCT.GetFocusedDataRow();
            //if (IsNumber(dataRow["SOLUONG"].ToString()) == false)
            //{
            //    e.Valid = false;
            //    view.SetColumnError(ColSoLuong, "Số lượng không hợp lệ");
            //    // checkNumber = "Số lượng không hợp lệ";

            //}
        }

        private void gcHoaDonNhapCT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Delete)
            {
                DeleteHoaDonCT();

            }
        }
    }
}
