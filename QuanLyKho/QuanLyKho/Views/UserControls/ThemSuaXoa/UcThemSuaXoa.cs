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

namespace QuanLyKho.Views.UserControls.ThemSuaXoa
{
    public partial class UcThemSuaXoa : DevExpress.XtraEditors.XtraUserControl
    {
        private int _Mode = 0;

        public event EventHandler BtnThemClick = null;
        public event EventHandler BtnSuaClick = null;
        public event EventHandler BtnXoaClick = null;
        public event EventHandler BtnLuuClick = null;
        public event EventHandler BtnHuyBoClick = null;
        public event EventHandler BtnThoatClick = null;

        // cho phép xóa (Nhấn phím delete để xóa)
        public bool AllowDelete = false;

        public UcThemSuaXoa()
        {
            InitializeComponent();
        }

        public void SetStatus(int mode)
        {
            _Mode = mode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetDisplayButton(1);
            BtnThemClick(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SetDisplayButton(2);
            BtnSuaClick(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            BtnXoaClick(sender, e);
        }

        private void bntLuu_Click_1(object sender, EventArgs e)
        {
            SetDisplayButton(0);
            BtnLuuClick(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            SetDisplayButton(0);
            BtnHuyBoClick(sender, e);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            BtnThoatClick(sender, e);
        }

        #region set enabled button
        public void SetEnabledBntReset(bool enabled)
        {
            this.btnHuyBo.Enabled = enabled;
        }
        public void SetEnabledBtnSave(bool enabled)
        {
            this.btnLuu.Enabled = enabled;
        }

        // cai dat an hien button 
        public void SetVisableBtnEdit(bool visable)
        {
            this.btnSua.Visible = visable;
        }
        // cai dat an hien button  xoa
        public void SetVisableBtnDelect(bool visable)
        {
            this.btnXoa.Visible = visable;
        }

        /// <summary>
        /// hàm set ẩn hiển các nút
        /// </summary>
        /// <param name="mode"> 0 view, 1 add, 2 update </param>
        private void SetDisplayButton(int mode)
        {
            if (_Mode == 0)
            {


                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Visible = false;
                btnHuyBo.Visible = false;
                btnThoat.Visible = false;

                // view
                if (mode == 0)
                {
                    btnThem.Visible = true;
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                    btnThoat.Visible = true;
                    AllowDelete = false;
                }

                // add
                if (mode == 1)
                {

                    btnLuu.Visible = true;
                    btnHuyBo.Visible = true;
                    btnThoat.Visible = true;
                    AllowDelete = true;
                }

                // update
                if (mode == 2)
                {

                    btnLuu.Visible = true;
                    btnHuyBo.Visible = true;
                    btnThoat.Visible = true;
                    AllowDelete = false;
                }
            }
            else if(_Mode == 1)
            {
                btnLuu.Visible = false;
                btnHuyBo.Visible = false;
            }else if(_Mode == 3)
            {
                // chỉ hiện nút thoát
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnLuu.Visible = false;
                btnHuyBo.Visible = false;
            }

        }




        #endregion

        private void UcThemSuaXoa_Load(object sender, EventArgs e)
        {
            SetDisplayButton(0);
        }
    }
}
