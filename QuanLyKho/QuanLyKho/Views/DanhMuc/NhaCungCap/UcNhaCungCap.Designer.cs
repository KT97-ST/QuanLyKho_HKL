namespace QuanLyKho.Views.DanhMuc.NhaCungCap
{
    partial class UcNhaCungCap
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
            this.gridControl_NhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gridNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NHACUNGCAP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_TK_ATM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHACUNGCAP_MASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_NhaCungCap
            // 
            this.gridControl_NhaCungCap.Location = new System.Drawing.Point(3, 27);
            this.gridControl_NhaCungCap.MainView = this.gridNhaCungCap;
            this.gridControl_NhaCungCap.Name = "gridControl_NhaCungCap";
            this.gridControl_NhaCungCap.Size = new System.Drawing.Size(889, 425);
            this.gridControl_NhaCungCap.TabIndex = 0;
            this.gridControl_NhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNhaCungCap});
            // 
            // gridNhaCungCap
            // 
            this.gridNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NHACUNGCAP_ID,
            this.STT,
            this.NHACUNGCAP_MA,
            this.NHACUNGCAP_TEN,
            this.NHACUNGCAP_SDT,
            this.NHACUNGCAP_DIACHI,
            this.NHACUNGCAP_TK_ATM,
            this.NHACUNGCAP_MASOTHUE});
            this.gridNhaCungCap.GridControl = this.gridControl_NhaCungCap;
            this.gridNhaCungCap.Name = "gridNhaCungCap";
            this.gridNhaCungCap.OptionsView.ShowAutoFilterRow = true;
            this.gridNhaCungCap.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridNhaCungCap_InvalidRowException);
            this.gridNhaCungCap.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridNhaCungCap_ValidateRow);
            this.gridNhaCungCap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridNhaCungCap_KeyDown);
            // 
            // NHACUNGCAP_ID
            // 
            this.NHACUNGCAP_ID.Caption = "ID";
            this.NHACUNGCAP_ID.FieldName = "NHACUNGCAP_ID";
            this.NHACUNGCAP_ID.Name = "NHACUNGCAP_ID";
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
            // NHACUNGCAP_MA
            // 
            this.NHACUNGCAP_MA.Caption = "Mã nhà cung cấp";
            this.NHACUNGCAP_MA.FieldName = "NHACUNGCAP_MA";
            this.NHACUNGCAP_MA.Name = "NHACUNGCAP_MA";
            this.NHACUNGCAP_MA.Visible = true;
            this.NHACUNGCAP_MA.VisibleIndex = 1;
            this.NHACUNGCAP_MA.Width = 70;
            // 
            // NHACUNGCAP_TEN
            // 
            this.NHACUNGCAP_TEN.Caption = "Tên nhà cung cấp";
            this.NHACUNGCAP_TEN.FieldName = "NHACUNGCAP_TEN";
            this.NHACUNGCAP_TEN.Name = "NHACUNGCAP_TEN";
            this.NHACUNGCAP_TEN.Visible = true;
            this.NHACUNGCAP_TEN.VisibleIndex = 2;
            this.NHACUNGCAP_TEN.Width = 219;
            // 
            // NHACUNGCAP_SDT
            // 
            this.NHACUNGCAP_SDT.Caption = "Số điện thoại";
            this.NHACUNGCAP_SDT.FieldName = "NHACUNGCAP_SDT";
            this.NHACUNGCAP_SDT.Name = "NHACUNGCAP_SDT";
            this.NHACUNGCAP_SDT.Visible = true;
            this.NHACUNGCAP_SDT.VisibleIndex = 3;
            this.NHACUNGCAP_SDT.Width = 219;
            // 
            // NHACUNGCAP_DIACHI
            // 
            this.NHACUNGCAP_DIACHI.Caption = "Địa chỉ";
            this.NHACUNGCAP_DIACHI.FieldName = "NHACUNGCAP_DIACHI";
            this.NHACUNGCAP_DIACHI.Name = "NHACUNGCAP_DIACHI";
            this.NHACUNGCAP_DIACHI.Visible = true;
            this.NHACUNGCAP_DIACHI.VisibleIndex = 4;
            this.NHACUNGCAP_DIACHI.Width = 226;
            // 
            // NHACUNGCAP_TK_ATM
            // 
            this.NHACUNGCAP_TK_ATM.Caption = "TK ATM";
            this.NHACUNGCAP_TK_ATM.DisplayFormat.FormatString = "n0";
            this.NHACUNGCAP_TK_ATM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NHACUNGCAP_TK_ATM.FieldName = "NHACUNGCAP_TK_ATM";
            this.NHACUNGCAP_TK_ATM.Name = "NHACUNGCAP_TK_ATM";
            this.NHACUNGCAP_TK_ATM.Visible = true;
            this.NHACUNGCAP_TK_ATM.VisibleIndex = 5;
            this.NHACUNGCAP_TK_ATM.Width = 123;
            // 
            // NHACUNGCAP_MASOTHUE
            // 
            this.NHACUNGCAP_MASOTHUE.Caption = "Mã số thuế";
            this.NHACUNGCAP_MASOTHUE.FieldName = "NHACUNGCAP_MASOTHUE";
            this.NHACUNGCAP_MASOTHUE.Name = "NHACUNGCAP_MASOTHUE";
            this.NHACUNGCAP_MASOTHUE.Visible = true;
            this.NHACUNGCAP_MASOTHUE.VisibleIndex = 6;
            this.NHACUNGCAP_MASOTHUE.Width = 76;
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
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "NHÀ CUNG CẤP";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_NhaCungCap);
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
            this.layoutControlItem3.Control = this.gridControl_NhaCungCap;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(893, 429);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // UcNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcNhaCungCap";
            this.Size = new System.Drawing.Size(907, 491);
            this.Load += new System.EventHandler(this.UcNhaCungCap_Load);
            this.ParentChanged += new System.EventHandler(this.UcNhaCungCap_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
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

        private DevExpress.XtraGrid.GridControl gridControl_NhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_MA;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_TEN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_TK_ATM;
        private DevExpress.XtraGrid.Columns.GridColumn NHACUNGCAP_MASOTHUE;
    }
}
