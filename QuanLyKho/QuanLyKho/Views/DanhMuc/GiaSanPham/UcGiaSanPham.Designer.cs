namespace QuanLyKho.Views.DanhMuc.GiaSanPham
{
    partial class UcGiaSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.gridGiaTien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GIASANPHAM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SANPHAM_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIGIA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlThemSuaXoa = new DevExpress.XtraEditors.PanelControl();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlheader = new DevExpress.XtraEditors.PanelControl();
            this.GIA_TIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIME_BD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIME_KT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlThemSuaXoa)).BeginInit();
            this.pnlThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlheader)).BeginInit();
            this.pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenLoai);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(903, 49);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tìm kiếm giá tiền";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(56, 26);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoai.Size = new System.Drawing.Size(143, 20);
            this.txtTenLoai.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giá tiền:";
            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.Controls.Add(this.gridGiaTien);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 51);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(903, 438);
            this.pnlMain.TabIndex = 4;
            // 
            // gridGiaTien
            // 
            this.gridGiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGiaTien.Location = new System.Drawing.Point(2, 2);
            this.gridGiaTien.MainView = this.gridView1;
            this.gridGiaTien.Name = "gridGiaTien";
            this.gridGiaTien.Size = new System.Drawing.Size(899, 434);
            this.gridGiaTien.TabIndex = 0;
            this.gridGiaTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GIASANPHAM_ID,
            this.SANPHAM_TEN,
            this.LOAIGIA_TEN,
            this.GIA_TIEN,
            this.TIME_BD,
            this.TIME_KT});
            this.gridView1.GridControl = this.gridGiaTien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // GIASANPHAM_ID
            // 
            this.GIASANPHAM_ID.Caption = "ID";
            this.GIASANPHAM_ID.FieldName = "GIASANPHAM_ID";
            this.GIASANPHAM_ID.Name = "GIASANPHAM_ID";
            this.GIASANPHAM_ID.Visible = true;
            this.GIASANPHAM_ID.VisibleIndex = 0;
            // 
            // SANPHAM_TEN
            // 
            this.SANPHAM_TEN.Caption = "Tên Sản Phẩm";
            this.SANPHAM_TEN.FieldName = "SANPHAM_TEN";
            this.SANPHAM_TEN.Name = "SANPHAM_TEN";
            this.SANPHAM_TEN.Visible = true;
            this.SANPHAM_TEN.VisibleIndex = 1;
            // 
            // LOAIGIA_TEN
            // 
            this.LOAIGIA_TEN.Caption = "Loại giá";
            this.LOAIGIA_TEN.FieldName = "LOAIGIA_TEN";
            this.LOAIGIA_TEN.Name = "LOAIGIA_TEN";
            this.LOAIGIA_TEN.Visible = true;
            this.LOAIGIA_TEN.VisibleIndex = 2;
            // 
            // pnlThemSuaXoa
            // 
            this.pnlThemSuaXoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlThemSuaXoa.Controls.Add(this.ucThemSuaXoa1);
            this.pnlThemSuaXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThemSuaXoa.Location = new System.Drawing.Point(570, 0);
            this.pnlThemSuaXoa.Name = "pnlThemSuaXoa";
            this.pnlThemSuaXoa.Size = new System.Drawing.Size(333, 49);
            this.pnlThemSuaXoa.TabIndex = 3;
            // 
            // ucThemSuaXoa1
            // 
            this.ucThemSuaXoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucThemSuaXoa1.Location = new System.Drawing.Point(0, 0);
            this.ucThemSuaXoa1.Name = "ucThemSuaXoa1";
            this.ucThemSuaXoa1.Size = new System.Drawing.Size(333, 49);
            this.ucThemSuaXoa1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlMain);
            this.panelControl2.Controls.Add(this.pnlheader);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 491);
            this.panelControl2.TabIndex = 6;
            // 
            // pnlheader
            // 
            this.pnlheader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlheader.Controls.Add(this.pnlThemSuaXoa);
            this.pnlheader.Controls.Add(this.groupControl1);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(2, 2);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(903, 49);
            this.pnlheader.TabIndex = 3;
            // 
            // GIA_TIEN
            // 
            this.GIA_TIEN.Caption = "Giá Tiền";
            this.GIA_TIEN.FieldName = "GIA_TIEN";
            this.GIA_TIEN.Name = "GIA_TIEN";
            this.GIA_TIEN.Visible = true;
            this.GIA_TIEN.VisibleIndex = 3;
            // 
            // TIME_BD
            // 
            this.TIME_BD.Caption = "Thời gian bắt đầu";
            this.TIME_BD.FieldName = "TIME_BD";
            this.TIME_BD.Name = "TIME_BD";
            this.TIME_BD.Visible = true;
            this.TIME_BD.VisibleIndex = 4;
            // 
            // TIME_KT
            // 
            this.TIME_KT.Caption = "Thời gian kết thúc";
            this.TIME_KT.FieldName = "TIME_KT";
            this.TIME_KT.Name = "TIME_KT";
            this.TIME_KT.Visible = true;
            this.TIME_KT.VisibleIndex = 5;
            // 
            // UcGiaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcGiaSanPham";
            this.Size = new System.Drawing.Size(907, 491);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlThemSuaXoa)).EndInit();
            this.pnlThemSuaXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlheader)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraGrid.GridControl gridGiaTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GIASANPHAM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn SANPHAM_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIGIA_TEN;
        private DevExpress.XtraEditors.PanelControl pnlThemSuaXoa;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlheader;
        private DevExpress.XtraGrid.Columns.GridColumn GIA_TIEN;
        private DevExpress.XtraGrid.Columns.GridColumn TIME_BD;
        private DevExpress.XtraGrid.Columns.GridColumn TIME_KT;
    }
}
