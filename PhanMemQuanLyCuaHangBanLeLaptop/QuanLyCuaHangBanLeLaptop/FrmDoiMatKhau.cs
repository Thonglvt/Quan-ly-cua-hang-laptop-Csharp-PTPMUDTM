using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        BLLNguoiDung bllND;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        #region Method
        #endregion

        #region Event
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Check rỗng
            if(txtOldPass.Text.Trim()==string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập "+lbPassOld.Text, "Thông báo [Message]"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbNewPass.Text, "Thông báo [Message]"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Focus();
                return;
            }
            if (txtComfirmPass.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbConfirm.Text, "Thông báo [Message]"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComfirmPass.Focus();
                return;
            }
            //Kiểm tra pass cũ
            bllND = new BLLNguoiDung();
            var tk = bllND.lstUsers().Find(t => t.username == DTOSession.Username && t.password.Trim()==txtOldPass.Text.Trim());
            if (tk==null)
            {
                XtraMessageBox.Show(lbPassOld.Text + " không chính xác.", "Thông báo [Message]"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPass.Focus();
                return;
            }
            if(txtComfirmPass.Text !=txtNewPass.Text)
            {
                XtraMessageBox.Show(lbConfirm.Text + " không khớp.", "Thông báo [Message]"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComfirmPass.Focus();
                return;
            }
            //
            if (XtraMessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Account acc = new Account();
                acc.username = DTOSession.Username;
                acc.password = txtComfirmPass.Text.Trim();
                string kqDoiPass = bllND.updatePass(acc);
                if (kqDoiPass.Equals("1"))
                {
                    XtraMessageBox.Show("Thanh đổi mật khẩu thành công", "Thông báo [Message]"
                                  , MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
                XtraMessageBox.Show("Error: " + kqDoiPass, "Thông báo [Message]"
                                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
        }
        #endregion


    }
}