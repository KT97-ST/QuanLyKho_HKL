namespace QuanLyKho.Views.CongNo
{
    partial class UcCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCongNo));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThanhToanCN = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_CongNo = new DevExpress.XtraGrid.GridControl();
            this.gridCongNo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KHACHHANG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHANGHANG_DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_TK_ATM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHACHHANG_MASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIENNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(130)))), ((int)(((byte)(175)))));
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(907, 491);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "CÔNG NỢ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThanhToanCN);
            this.layoutControl1.Controls.Add(this.btnThoat);
            this.layoutControl1.Controls.Add(this.btnXem);
            this.layoutControl1.Controls.Add(this.gridControl_CongNo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(849, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(903, 463);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThanhToanCN
            // 
            this.btnThanhToanCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToanCN.ImageOptions.Image")));
            this.btnThanhToanCN.Location = new System.Drawing.Point(361, 438);
            this.btnThanhToanCN.Name = "btnThanhToanCN";
            this.btnThanhToanCN.Size = new System.Drawing.Size(85, 22);
            this.btnThanhToanCN.StyleController = this.layoutControl1;
            this.btnThanhToanCN.TabIndex = 8;
            this.btnThanhToanCN.Text = "Thanh toán";
            this.btnThanhToanCN.Click += new System.EventHandler(this.btnThanhToanCN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(556, 438);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 22);
            this.btnThoat.StyleController = this.layoutControl1;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(450, 438);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(102, 22);
            this.btnXem.StyleController = this.layoutControl1;
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // gridControl_CongNo
            // 
            this.gridControl_CongNo.Location = new System.Drawing.Point(3, 3);
            this.gridControl_CongNo.MainView = this.gridCongNo;
            this.gridControl_CongNo.Name = "gridControl_CongNo";
            this.gridControl_CongNo.Size = new System.Drawing.Size(897, 431);
            this.gridControl_CongNo.TabIndex = 5;
            this.gridControl_CongNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCongNo});
            // 
            // gridCongNo
            // 
            this.gridCongNo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KHACHHANG_ID,
            this.STT,
            this.KHACHHANG_MA,
            this.KHACHHANG_TEN,
            this.KHACHHANG_SDT,
            this.KHANGHANG_DIACHI,
            this.KHACHHANG_TK_ATM,
            this.KHACHHANG_MASOTHUE,
            this.SOTIENNO});
            this.gridCongNo.GridControl = this.gridControl_CongNo;
            this.gridCongNo.Name = "gridCongNo";
            this.gridCongNo.OptionsView.ShowAutoFilterRow = true;
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
            this.STT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.KHACHHANG_SDT.AppearanceCell.Options.UseTextOptions = true;
            this.KHACHHANG_SDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.KHACHHANG_SDT.Caption = "Số điện thoại";
            this.KHACHHANG_SDT.DisplayFormat.FormatString = "n0";
            this.KHACHHANG_SDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHACHHANG_SDT.FieldName = "KHACHHANG_SDT";
            this.KHACHHANG_SDT.Name = "KHACHHANG_SDT";
            this.KHACHHANG_SDT.Visible = true;
            this.KHACHHANG_SDT.VisibleIndex = 3;
            this.KHACHHANG_SDT.Width = 168;
            // 
            // KHANGHANG_DIACHI
            // 
            this.KHANGHANG_DIACHI.Caption = "Địa chỉ";
            this.KHANGHANG_DIACHI.FieldName = "KHACHHANG_DIACHI";
            this.KHANGHANG_DIACHI.Name = "KHANGHANG_DIACHI";
            this.KHANGHANG_DIACHI.Visible = true;
            this.KHANGHANG_DIACHI.VisibleIndex = 4;
            this.KHANGHANG_DIACHI.Width = 203;
            // 
            // KHACHHANG_TK_ATM
            // 
            this.KHACHHANG_TK_ATM.AppearanceCell.Options.UseTextOptions = true;
            this.KHACHHANG_TK_ATM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.KHACHHANG_TK_ATM.Caption = "Tài khoản ngân hàng";
            this.KHACHHANG_TK_ATM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHACHHANG_TK_ATM.FieldName = "KHACHHANG_TK_ATM";
            this.KHACHHANG_TK_ATM.Name = "KHACHHANG_TK_ATM";
            this.KHACHHANG_TK_ATM.Visible = true;
            this.KHACHHANG_TK_ATM.VisibleIndex = 5;
            this.KHACHHANG_TK_ATM.Width = 100;
            // 
            // KHACHHANG_MASOTHUE
            // 
            this.KHACHHANG_MASOTHUE.AppearanceCell.Options.UseTextOptions = true;
            this.KHACHHANG_MASOTHUE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.KHACHHANG_MASOTHUE.Caption = "Mã số thuế";
            this.KHACHHANG_MASOTHUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.KHACHHANG_MASOTHUE.FieldName = "KHACHHANG_MASOTHUE";
            this.KHACHHANG_MASOTHUE.Name = "KHACHHANG_MASOTHUE";
            this.KHACHHANG_MASOTHUE.Visible = true;
            this.KHACHHANG_MASOTHUE.VisibleIndex = 6;
            this.KHACHHANG_MASOTHUE.Width = 100;
            // 
            // SOTIENNO
            // 
            this.SOTIENNO.Caption = "Số tiền nợ";
            this.SOTIENNO.DisplayFormat.FormatString = "n0";
            this.SOTIENNO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SOTIENNO.FieldName = "SOTIENNO";
            this.SOTIENNO.Name = "SOTIENNO";
            this.SOTIENNO.Visible = true;
            this.SOTIENNO.VisibleIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.Root.Size = new System.Drawing.Size(903, 463);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_CongNo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(901, 435);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(652, 435);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnXem;
            this.layoutControlItem1.Location = new System.Drawing.Point(447, 435);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(106, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThoat;
            this.layoutControlItem3.Location = new System.Drawing.Point(553, 435);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(99, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 435);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(358, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThanhToanCN;
            this.layoutControlItem4.Location = new System.Drawing.Point(358, 435);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // UcCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UcCongNo";
            this.Size = new System.Drawing.Size(907, 491);
            this.Load += new System.EventHandler(this.UcCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCongNo;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_MA;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn KHANGHANG_DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_TK_ATM;
        private DevExpress.XtraGrid.Columns.GridColumn KHACHHANG_MASOTHUE;
        private DevExpress.XtraGrid.GridControl gridControl_CongNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIENNO;
        private DevExpress.XtraEditors.SimpleButton btnThanhToanCN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
