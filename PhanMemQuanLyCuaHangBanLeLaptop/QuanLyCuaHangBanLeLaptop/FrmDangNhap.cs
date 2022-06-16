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
using DevExpress.XtraEditors.DXErrorProvider;
using BLL;
using DTO;
namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLLNguoiDung bllTaiKhoan = new BLLNguoiDung();
        BLLNhanVien bllNhanVien = new BLLNhanVien();
        public FrmDangNhap()
        {
            InitializeComponent();
            txtUsername.Focus();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.PasswordChar = (txtPassword.Properties.PasswordChar == '*') ? '\0' : '*';
            var username = DTOGroupUser.GroupUser;
            if(username!=null)
            {
                txtUsername.Text = username.ToString();
            }    
            else
            {
                txtUsername.Text = "admin";
                txtPassword.Text = "123";
            }    
            txtUsername.Focus();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                txtPassword.Focus();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == string.Empty)
            {
                txtUsername.Focus();
                errThongBao.SetError(txtUsername, "Tên đăng nhập không được để trống");
            }
            else if (password == string.Empty)
            {
                txtPassword.Focus();
                errThongBao.SetError(txtPassword, "Mật khẩu không được để trống");
            }
            else
            {
                //Kiểm tra Account tồn tại
                if (bllTaiKhoan.kiemTraDangNhap(username, password))
                {
                    XtraMessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    DTOGroupUser.GroupUser = username;
                    Employee empl = bllNhanVien.getNhanVienTheoUsername(username);
                    DTOSession.MaNhanVien = empl.id;
                    DTOSession.TenNhanVien = empl.name;
                    DTOSession.NgaySinh = (DateTime)empl.birthday;
                    DTOSession.GioiTinh = empl.gender;
                    DTOSession.SoDienThoai = empl.phone;
                    DTOSession.Email = empl.email;
                    DTOSession.CCCD = empl.cmnd;
                    DTOSession.Luong = Convert.ToInt32(empl.salary);
                    DTOSession.Hinh = empl.avatar;
                    DTOSession.NgayVaoLam = (DateTime)empl.hire_date;
                    DTOSession.Username = empl.username;

                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    Hide();
                }
                else
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}