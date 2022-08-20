namespace QuanLyKho.Views.DanhMuc.SanPham
{
    partial class UcSanPham
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
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.gridC_SanPham = new DevExpress.XtraGrid.GridControl();
            this.gridSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SANPHAM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SANPHAM_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SANPHAM_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAISANPHAM_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
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
            // gridC_SanPham
            // 
            this.gridC_SanPham.Location = new System.Drawing.Point(3, 27);
            this.gridC_SanPham.MainView = this.gridSanPham;
            this.gridC_SanPham.Name = "gridC_SanPham";
            this.gridC_SanPham.Size = new System.Drawing.Size(889, 425);
            this.gridC_SanPham.TabIndex = 0;
            this.gridC_SanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSanPham});
            // 
            // gridSanPham
            // 
            this.gridSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SANPHAM_ID,
            this.STT,
            this.SANPHAM_MA,
            this.SANPHAM_TEN,
            this.LOAISANPHAM_TEN,
            this.DONVITINH_TEN});
            this.gridSanPham.GridControl = this.gridC_SanPham;
            this.gridSanPham.Name = "gridSanPham";
            this.gridSanPham.OptionsView.ShowAutoFilterRow = true;
            // 
            // SANPHAM_ID
            // 
            this.SANPHAM_ID.Caption = "ID";
            this.SANPHAM_ID.FieldName = "SANPHAM_ID";
            this.SANPHAM_ID.Name = "SANPHAM_ID";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 20;
            // 
            // SANPHAM_MA
            // 
            this.SANPHAM_MA.Caption = "Mã";
            this.SANPHAM_MA.FieldName = "SANPHAM_MA";
            this.SANPHAM_MA.Name = "SANPHAM_MA";
            this.SANPHAM_MA.Visible = true;
            this.SANPHAM_MA.VisibleIndex = 1;
            // 
            // SANPHAM_TEN
            // 
            this.SANPHAM_TEN.Caption = "Tên sản phẩm";
            this.SANPHAM_TEN.FieldName = "SANPHAM_TEN";
            this.SANPHAM_TEN.Name = "SANPHAM_TEN";
            this.SANPHAM_TEN.Visible = true;
            this.SANPHAM_TEN.VisibleIndex = 2;
            // 
            // LOAISANPHAM_TEN
            // 
            this.LOAISANPHAM_TEN.Caption = "Loại sản phẩm";
            this.LOAISANPHAM_TEN.FieldName = "LOAISANPHAM_TEN";
            this.LOAISANPHAM_TEN.Name = "LOAISANPHAM_TEN";
            this.LOAISANPHAM_TEN.Visible = true;
            this.LOAISANPHAM_TEN.VisibleIndex = 3;
            // 
            // DONVITINH_TEN
            // 
            this.DONVITINH_TEN.Caption = "Đơn vị tính";
            this.DONVITINH_TEN.FieldName = "DONVITINH_TEN";
            this.DONVITINH_TEN.Name = "DONVITINH_TEN";
            this.DONVITINH_TEN.Visible = true;
            this.DONVITINH_TEN.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 491);
            this.panelControl2.TabIndex = 3;
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
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "SẢN PHẨM";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridC_SanPham);
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
            this.layoutControlItem3});
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
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridC_SanPham;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(893, 429);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // UcSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcSanPham";
            this.Size = new System.Drawing.Size(907, 491);
            this.Load += new System.EventHandler(this.UcSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraGrid.GridControl gridC_SanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSanPham;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn SANPHAM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn SANPHAM_MA;
        private DevExpress.XtraGrid.Columns.GridColumn SANPHAM_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn LOAISANPHAM_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
