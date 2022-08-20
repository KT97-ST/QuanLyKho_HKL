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

namespace QuanLyKho.Views.UserControls.ThemVaThoat
{
    public partial class UcThemHoacCapNhat : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler BtnAddOrUpdateClick = null;
        public event EventHandler BtnCancelClick = null;

        public UcThemHoacCapNhat()
        {
            InitializeComponent();
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
             BtnAddOrUpdateClick(sender,e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             BtnCancelClick(sender, e);
        }

        public void setNameBtn(string titleName)
        {
            this.btnAddOrUpdate.Text = titleName;
        }
    }
}
