namespace QuanLyKho.Views.DanhMuc.KhachHang
{
    partial class UcKhachHang
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KHACHHANG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_TK_ATM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_MASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 491);
            this.panelControl2.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.Controls.Add(this.groupControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(903, 487);
            this.pnlMain.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(175)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(899, 483);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "KHÁCH HÀNG";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_KhachHang);
            this.layoutControl1.Controls.Add(this.ucThemSuaXoa1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(729, 500, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(895, 455);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_KhachHang
            // 
            this.gridControl_KhachHang.Location = new System.Drawing.Point(3, 27);
            this.gridControl_KhachHang.MainView = this.gridKhachHang;
            this.gridControl_KhachHang.Name = "gridControl_KhachHang";
            this.gridControl_KhachHang.Size = new System.Drawing.Size(889, 425);
            this.gridControl_KhachHang.TabIndex = 0;
            this.gridControl_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKhachHang});
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KHACHHANG_ID,
            this.STT,
            this.KHACHHANG_MA,
            this.KHACHHANG_TEN,
            this.KHACHHANG_SDT,
            this.KHACHHANG_DIACHI,
            this.KHACHHANG_TK_ATM,
            this.KHACHHANG_MASOTHUE});
            this.gridKhachHang.GridControl = this.gridControl_KhachHang;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // KHACHHANG_ID
            // 
            this.KHACHHANG_ID.Caption = "ID";
            this.KHACHHANG_ID.FieldName = "KHACHHANG_ID";
            this.KHACHHANG_ID.Name = "KHACHHANG_ID";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 20;
            // 
            // KHACHHANG_MA
            // 
            this.KHACHHANG_MA.Caption = "Mã khách hàng";
            this.KHACHHANG_MA.FieldName = "KHACHHANG_MA";
            this.KHACHHANG_MA.Name = "KHACHHANG_MA";
            this.KHACHHANG_MA.Visible = true;
            this.KHACHHANG_MA.VisibleIndex = 1;
            this.KHACHHANG_MA.Width = 110;
            // 
            // KHACHHANG_TEN
            // 
            this.KHACHHANG_TEN.Caption = "Tên khách hàng";
            this.KHACHHANG_TEN.FieldName = "KHACHHANG_TEN";
            this.KHACHHANG_TEN.Name = "KHACHHANG_TEN";
            this.KHACHHANG_TEN.Visible = true;
            this.KHACHHANG_TEN.VisibleIndex = 2;
            this.KHACHHANG_TEN.Width = 191;
            // 
            // KHACHHANG_SDT
            // 
            this.KHACHHANG_SDT.Caption = "Số điện thoại";
            this.KHACHHANG_SDT.FieldName = "KHACHHANG_SDT";
            this.KHACHHANG_SDT.Name = "KHACHHANG_SDT";
            this.KHACHHANG_SDT.Visible = true;
            this.KHACHHANG_SDT.VisibleIndex = 3;
            this.KHACHHANG_SDT.Width = 168;
            // 
            // KHACHHANG_DIACHI
            // 
            this.KHACHHANG_DIACHI.Caption = "Địa chỉ";
            this.KHACHHANG_DIACHI.FieldName = "KHACHHANG_DIACHI";
            this.KHACHHANG_DIACHI.Name = "KHACHHANG_DIACHI";
            this.KHACHHANG_DIACHI.Visible = true;
            this.KHACHHANG_DIACHI.VisibleIndex = 4;
            this.KHACHHANG_DIACHI.Width = 203;
            // 
            // KHACHHANG_TK_ATM
            // 
            this.KHACHHANG_TK_ATM.Caption = "Tài khoản ngân hàng";
            this.KHACHHANG_TK_ATM.FieldName = "KHACHHANG_TK_ATM";
            this.KHACHHANG_TK_ATM.Name = "KHACHHANG_TK_ATM";
            this.KHACHHANG_TK_ATM.Visible = true;
            this.KHACHHANG_TK_ATM.VisibleIndex = 5;
            this.KHACHHANG_TK_ATM.Width = 100;
            // 
            // KHACHHANG_MASOTHUE
            // 
            this.KHACHHANG_MASOTHUE.Caption = "Mã số thuế";
            this.KHACHHANG_MASOTHUE.FieldName = "KHACHHANG_MASOTHUE";
            this.KHACHHANG_MASOTHUE.Name = "KHACHHANG_MASOTHUE";
            this.KHACHHANG_MASOTHUE.Visible = true;
            this.KHACHHANG_MASOTHUE.VisibleIndex = 6;
            this.KHACHHANG_MASOTHUE.Width = 100;
            // 
            // ucThemSuaXoa1
            // 
            this.ucThemSuaXoa1.Location = new System.Drawing.Point(3, 3);
            this.ucThemSuaXoa1.Name = "ucThemSuaXoa1";
            this.ucThemSuaXoa1.Size = new System.Drawing.Size(889, 20);
            this.ucThemSuaXoa1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.Root.Size = new System.Drawing.Size(895, 455);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ucThemSuaXoa1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(893, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(893, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(893, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_KhachHang;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(893, 429);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // UcKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcKhachHang";
            this.Size = new System.Drawing.Size(907, 491);
            this.Load += new System.EventHandler(this.UcKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraGrid.GridControl gridControl_KhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_MA;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_TK_ATM;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_MASOTHUE;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
