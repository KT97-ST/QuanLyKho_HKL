namespace QuanLyKho.Views.UserControls.ThemVaThoat
{
    partial class UcThemHoacCapNhat
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::QuanLyKho.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(115, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.ImageOptions.Image = global::QuanLyKho.Properties.Resources.apply_32x32;
            this.btnAddOrUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(106, 36);
            this.btnAddOrUpdate.TabIndex = 0;
            this.btnAddOrUpdate.Text = "Thêm ";
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // UcThemHoacCapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Name = "UcThemHoacCapNhat";
            this.Size = new System.Drawing.Size(224, 42);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnAddOrUpdate;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
