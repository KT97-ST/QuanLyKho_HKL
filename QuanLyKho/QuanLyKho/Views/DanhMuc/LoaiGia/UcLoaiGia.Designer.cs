namespace QuanLyKho.Views.DanhMuc.LoaiGia
{
    partial class UcLoaiGia
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
            this.gridControl_GiaTien = new DevExpress.XtraGrid.GridControl();
            this.gridGiaTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LOAIGIA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIGIA_MA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIGIA_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.pnlheader = new DevExpress.XtraEditors.PanelControl();
            this.ucThemSuaXoa1 = new QuanLyKho.Views.UserControls.ThemSuaXoa.UcThemSuaXoa();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_GiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlheader)).BeginInit();
            this.pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_GiaTien
            // 
            this.gridControl_GiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_GiaTien.Location = new System.Drawing.Point(2, 2);
            this.gridControl_GiaTien.MainView = this.gridGiaTien;
            this.gridControl_GiaTien.Name = "gridControl_GiaTien";
            this.gridControl_GiaTien.Size = new System.Drawing.Size(836, 432);
            this.gridControl_GiaTien.TabIndex = 0;
            this.gridControl_GiaTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGiaTien});
            // 
            // gridGiaTien
            // 
            this.gridGiaTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LOAIGIA_ID,
            this.LOAIGIA_MA,
            this.LOAIGIA_TEN});
            this.gridGiaTien.GridControl = this.gridControl_GiaTien;
            this.gridGiaTien.Name = "gridGiaTien";
            this.gridGiaTien.OptionsView.ShowAutoFilterRow = true;
            // 
            // LOAIGIA_ID
            // 
            this.LOAIGIA_ID.Caption = "ID";
            this.LOAIGIA_ID.FieldName = "LOAIGIA_ID";
            this.LOAIGIA_ID.Name = "LOAIGIA_ID";
            // 
            // LOAIGIA_MA
            // 
            this.LOAIGIA_MA.Caption = "Mã giá";
            this.LOAIGIA_MA.FieldName = "LOAIGIA_MA";
            this.LOAIGIA_MA.Name = "LOAIGIA_MA";
            this.LOAIGIA_MA.Visible = true;
            this.LOAIGIA_MA.VisibleIndex = 0;
            // 
            // LOAIGIA_TEN
            // 
            this.LOAIGIA_TEN.Caption = "Tên loại giá";
            this.LOAIGIA_TEN.FieldName = "LOAIGIA_TEN";
            this.LOAIGIA_TEN.Name = "LOAIGIA_TEN";
            this.LOAIGIA_TEN.Visible = true;
            this.LOAIGIA_TEN.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlMain);
            this.panelControl2.Controls.Add(this.pnlheader);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(844, 489);
            this.panelControl2.TabIndex = 9;
            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.Controls.Add(this.gridControl_GiaTien);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 51);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(840, 436);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlheader
            // 
            this.pnlheader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlheader.Controls.Add(this.ucThemSuaXoa1);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(2, 2);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(840, 49);
            this.pnlheader.TabIndex = 3;
            // 
            // ucThemSuaXoa1
            // 
            this.ucThemSuaXoa1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucThemSuaXoa1.Location = new System.Drawing.Point(0, 0);
            this.ucThemSuaXoa1.Name = "ucThemSuaXoa1";
            this.ucThemSuaXoa1.Size = new System.Drawing.Size(687, 49);
            this.ucThemSuaXoa1.TabIndex = 1;
            // 
            // UcLoaiGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Name = "UcLoaiGia";
            this.Size = new System.Drawing.Size(844, 489);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_GiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlheader)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_GiaTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGiaTien;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIGIA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIGIA_MA;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIGIA_TEN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.PanelControl pnlheader;
        private UserControls.ThemSuaXoa.UcThemSuaXoa ucThemSuaXoa1;
    }
}
