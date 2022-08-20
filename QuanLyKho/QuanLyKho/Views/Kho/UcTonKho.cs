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
using QuanLyKho.Controllers.TonKho;

namespace QuanLyKho.Views.Kho
{
    public partial class UcTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        public UcTonKho()
        {
            InitializeComponent();
        }
        private void LoadTonKho()
        {
            gcTonKho.DataSource= ClsC_TonKho.Instance.GetTonKho();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTonKho();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UcTonKho_Load(object sender, EventArgs e)
        {
            LoadTonKho();
        }
    }
}
