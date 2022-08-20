using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKho.Models.Connect;
using System.Data.SqlClient;
using Microsoft.Win32;
using DevExpress.XtraWaitForm;
using QuanLyKho.Controllers.DungChung;

namespace QuanLyKho.Views.Connection
{
    public partial class frmConnect : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// mode này dùng để phan biệt đang ở màn hình nào
        /// </summary>
        private int _ModeApp;

        public frmConnect(int mode)
        {
            InitializeComponent();
            _ModeApp = mode;
        }
        private void connectDB()
        {
            string datasource = cbxServerName.Text.Trim();

            string database = txtDataBaseName.Text.Trim();
            string username = txtDBUser.Text.Trim();
            string password = txtDBPass.Text.Trim();
            try
            {
                SqlConnection conn = ClsDB_SERVER_Util.GetDBConnection(datasource, database, username, password);

                // màn hình chờ
                splashScreenManager1.ShowWaitForm();
                conn.Open();

                // kết nối thành công thì lưu lại thông tin kết nối
                QuanLyKho.Properties.Settings.Default.datasource = datasource;
                QuanLyKho.Properties.Settings.Default.database = database;
                QuanLyKho.Properties.Settings.Default.username = username;
                QuanLyKho.Properties.Settings.Default.password = Cls_Encode_Decode.Instance.EncodeString(password);
                QuanLyKho.Properties.Settings.Default.Save();

                conn.Close();
                // đóng màn hình chờ
                splashScreenManager1.CloseWaitForm();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Kết nối không thành công"+"\n"+ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            connectDB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(_ModeApp == 0)
            {
                this.Close();
            }
            else
            {
                Environment.Exit(1);
                // Close();
            }
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            loadServerName();
        }

        private void loadServerName()
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cbxServerName.Items.Add(ServerName + "\\" + instanceName);
                    }
                }
            }
        }

        private void txtDBPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                btnDongy.PerformClick();
            }
        }
    }
}