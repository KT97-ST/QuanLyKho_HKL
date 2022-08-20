namespace QuanLyKho.Views.DanhMuc.SanPham
{
    partial class DlgSanPham
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupThongTinSanPham = new DevExpress.XtraEditors.GroupControl();
            this.cbxDonViTinh = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxLoaiSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucThemHoacCapNhat1 = new QuanLyKho.Views.UserControls.ThemVaThoat.UcThemHoacCapNhat();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinSanPham)).BeginInit();
            this.groupThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTinSanPham
            // 
            this.groupThongTinSanPham.AppearanceCaption.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupThongTinSanPham.AppearanceCaption.Options.UseBorderColor = true;
            this.groupThongTinSanPham.Controls.Add(this.cbxDonViTinh);
            this.groupThongTinSanPham.Controls.Add(this.cbxLoaiSanPham);
            this.groupThongTinSanPham.Controls.Add(this.ucThemHoacCapNhat1);
            this.groupThongTinSanPham.Controls.Add(this.labelControl4);
            this.groupThongTinSanPham.Controls.Add(this.labelControl3);
            this.groupThongTinSanPham.Controls.Add(this.txtTenSanPham);
            this.groupThongTinSanPham.Controls.Add(this.labelControl2);
            this.groupThongTinSanPham.Controls.Add(this.txtMaSanPham);
            this.groupThongTinSanPham.Controls.Add(this.labelControl1);
            this.groupThongTinSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupThongTinSanPham.Location = new System.Drawing.Point(0, 0);
            this.groupThongTinSanPham.Name = "groupThongTinSanPham";
            this.groupThongTinSanPham.Size = new System.Drawing.Size(456, 237);
            this.groupThongTinSanPham.TabIndex = 2;
            this.groupThongTinSanPham.Text = "Thông tin sản phẩm";
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.Location = new System.Drawing.Point(106, 139);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDonViTinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DONVITINH_ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DONVITINH_MA", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DONVITINH_TEN", "Tên loại")});
            this.cbxDonViTinh.Properties.NullText = "";
            this.cbxDonViTinh.Size = new System.Drawing.Size(338, 20);
            this.cbxDonViTinh.TabIndex = 12;
            this.cbxDonViTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxDonViTinh_KeyPress);
            // 
            // cbxLoaiSanPham
            // 
            this.cbxLoaiSanPham.Location = new System.Drawing.Point(106, 108);
            this.cbxLoaiSanPham.Name = "cbxLoaiSanPham";
            this.cbxLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLoaiSanPham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOAISANPHAM_ID", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOAISANPHAM_MA", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOAISANPHAM_TEN", "Tên loại")});
            this.cbxLoaiSanPham.Properties.NullText = "";
            this.cbxLoaiSanPham.Size = new System.Drawing.Size(338, 20);
            this.cbxLoaiSanPham.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Đơn vị tính:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Loại sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(106, 69);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(340, 20);
            this.txtTenSanPham.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên sản phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(106, 37);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Properties.Appearance.Options.UseFont = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(340, 20);
            this.txtMaSanPham.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã:";
            // 
            // ucThemHoacCapNhat1
            // 
            this.ucThemHoacCapNhat1.Location = new System.Drawing.Point(114, 177);
            this.ucThemHoacCapNhat1.Name = "ucThemHoacCapNhat1";
            this.ucThemHoacCapNhat1.Size = new System.Drawing.Size(224, 42);
            this.ucThemHoacCapNhat1.TabIndex = 8;
            // 
            // DlgSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 237);
            this.Controls.Add(this.groupThongTinSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DlgSanPham";
            this.Load += new System.EventHandler(this.DlgSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinSanPham)).EndInit();
            this.groupThongTinSanPham.ResumeLayout(false);
            this.groupThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupThongTinSanPham;
        private UserControls.ThemVaThoat.UcThemHoacCapNhat ucThemHoacCapNhat1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cbxLoaiSanPham;
        private DevExpress.XtraEditors.LookUpEdit cbxDonViTinh;
    }
}