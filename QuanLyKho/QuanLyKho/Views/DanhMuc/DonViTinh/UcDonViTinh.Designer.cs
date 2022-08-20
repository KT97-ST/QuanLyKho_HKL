namespace QuanLyKho.Views.DanhMuc.DonViTinh
{
    partial class UcDonViTinh
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.gridDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma_DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten_DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.DONVITINH_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ĐƠN VỊ TÍNH";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ucThemSuaXoa1);
            this.layoutControl1.Controls.Add(this.gridControlDonViTinh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(729, 500, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(895, 455);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            // gridControlDonViTinh
            // 
            this.gridControlDonViTinh.Location = new System.Drawing.Point(3, 27);
            this.gridControlDonViTinh.MainView = this.gridDonViTinh;
            this.gridControlDonViTinh.Name = "gridControlDonViTinh";
            this.gridControlDonViTinh.Size = new System.Drawing.Size(889, 425);
            this.gridControlDonViTinh.TabIndex = 0;
            this.gridControlDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDonViTinh});
            this.gridControlDonViTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControlDonViTinh_KeyDown);
            // 
            // gridDonViTinh
            // 
            this.gridDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.STT,
            this.Ma_DonViTinh,
            this.Ten_DonViTinh});
            this.gridDonViTinh.GridControl = this.gridControlDonViTinh;
            this.gridDonViTinh.Name = "gridDonViTinh";
            this.gridDonViTinh.OptionsView.ShowAutoFilterRow = true;
            this.gridDonViTinh.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridDonViTinh_InvalidRowException);
            this.gridDonViTinh.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridDonViTinh_ValidateRow);
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "DONVITINH_ID";
            this.id.Name = "id";
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 20;
            // 
            // Ma_DonViTinh
            // 
            this.Ma_DonViTinh.Caption = "Mã";
            this.Ma_DonViTinh.FieldName = "DONVITINH_MA";
            this.Ma_DonViTinh.Name = "Ma_DonViTinh";
            this.Ma_DonViTinh.Visible = true;
            this.Ma_DonViTinh.VisibleIndex = 1;
            this.Ma_DonViTinh.Width = 291;
            // 
            // Ten_DonViTinh
            // 
            this.Ten_DonViTinh.Caption = "Tên";
            this.Ten_DonViTinh.FieldName = "DONVITINH_TEN";
            this.Ten_DonViTinh.Name = "Ten_DonViTinh";
            this.Ten_DonViTinh.Visible = true;
            this.Ten_DonViTinh.VisibleIndex = 2;
            this.Ten_DonViTinh.Width = 291;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 491);
            this.panelControl2.TabIndex = 5;
            // 
            // DONVITINH_TEN
            // 
            this.DONVITINH_TEN.Caption = "Tên đơn vị tính";
            this.DONVITINH_TEN.FieldName = "DONVITINH_TEN";
            this.DONVITINH_TEN.Name = "DONVITINH_TEN";
            // 
            // DONVITINH_MA
            // 
            this.DONVITINH_MA.Caption = "Mã đơn vị tính ";
            this.DONVITINH_MA.FieldName = "DONVITINH_MA";
            this.DONVITINH_MA.Name = "DONVITINH_MA";
            // 
            // DONVITINH_ID
            // 
            this.DONVITINH_ID.Caption = "ID";
            this.DONVITINH_ID.FieldName = "DONVITINH_ID";
            this.DONVITINH_ID.Name = "DONVITINH_ID";
            // 
            // ucThemSuaXoa1
            // 
            this.ucThemSuaXoa1.Location = new System.Drawing.Point(3, 3);
            this.ucThemSuaXoa1.Name = "ucThemSuaXoa1";
            this.ucThemSuaXoa1.Size = new System.Drawing.Size(889, 20);
            this.ucThemSuaXoa1.TabIndex = 4;
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
            this.layoutControlItem2.Control = this.gridControlDonViTinh;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(893, 429);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // UcDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcDonViTinh";
            this.Size = new System.Drawing.Size(907, 491);
            this.Load += new System.EventHandler(this.UcDonViTinh_Load);
            this.ParentChanged += new System.EventHandler(this.UcDonViTinh_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH_MA;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH_ID;
        private DevExpress.XtraGrid.GridControl gridControlDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn Ma_DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn Ten_DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
