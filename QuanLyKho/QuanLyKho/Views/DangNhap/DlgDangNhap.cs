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
using QuanLyKho.Controllers.DangNhap;
using QuanLyKho.Views.Connection;
using QuanLyKho.Controllers.DungChung;

namespace QuanLyKho.Views.DangNhap
{
    public partial class DlgDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DlgDangNhap()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Tài khoản không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string userName = txtTaiKhoan.EditValue.ToString();
                string passWord = Cls_Encode_Decode.Instance.EncodeString(txtMatKhau.EditValue.ToString());

                DataTable dt = ClsC_DangNhap.Instance.CheckLogin(userName, passWord);


                if (dt.Rows.Count == 1)
                {
                    int iDUser = 0;
                    // id người dùng
                    foreach (DataRow dr in dt.Rows)
                    {
                        iDUser = Convert.ToInt32(dr["NHANVIEN_ID"].ToString());
                    }

                    frmMain frmMain = new frmMain(iDUser);
                    this.Hide();
                    if (frmMain.ShowDialog() == DialogResult.Cancel)
                    {
                        txtTaiKhoan.EditValue = "";
                        txtMatKhau.EditValue = "";

                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// khi load lên là kiểm tra coi có kết nối hay chưa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DlgDangNhap_Load(object sender, EventArgs e)
        {
            checkConnect();

#if Debug_QL
            txtTaiKhoan.EditValue = "admin";
            txtMatKhau.EditValue = "khabanh";
#endif
        }

        private bool checkConnect()
        {
            bool ret = false;
            splashScreenManager1.ShowWaitForm();
            bool isConnect = ClsC_DangNhap.Instance.IsServerConnected();
            splashScreenManager1.CloseWaitForm();

            if (isConnect == false)
            {

                if (MessageBox.Show("Mất kết nối với server, xin vui lòng kết nối lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                   // this.Hide();
                    frmConnect frmConnect = new frmConnect(1);
                    if (frmConnect.ShowDialog() == DialogResult.OK)
                    {
                        frmConnect.Close();
                        ret = true;
                       // this.StartPosition = FormStartPosition.CenterScreen;
                      //  this.Show();
                    }
                    else
                    {
                        ret = false;
                    }
                }
                else
                {
                    // tắt chương trình
                    Application.Exit();
                }

            }
            return ret;
        }
       
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {

                btnLogin.PerformClick();
            }
        }

        private void txtTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}