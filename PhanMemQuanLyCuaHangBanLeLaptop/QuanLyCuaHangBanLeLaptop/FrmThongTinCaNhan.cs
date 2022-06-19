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
    public partial class FrmThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        RadioGroup rg = new RadioGroup();
        BLLNhanVien bllNV;
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }

        #region Method
        void loadData()
        {
            rg.Controls.Add(rbtnNam);
            rg.Controls.Add(rbtnNu);

            txtMaNV.Text = DTOSession.MaNhanVien;
            txtTenNV.Text = DTOSession.TenNhanVien;
            deNgSinh.EditValue = DTOSession.NgaySinh;
            rg.SelectedIndex = (DTOSession.GioiTinh).Equals("Nam") ? 0 : 1;
            txtSDT.Text = DTOSession.SoDienThoai;
            txtEmail.Text = DTOSession.Email;
            txtCCCD.Text = DTOSession.CCCD;
            txtLuong.Text = string.Format("{0:0,0 đ}", DTOSession.Luong);
            txtNgayVL.Text = DTOSession.NgayVaoLam.ToString();
        }
        #endregion

        #region Event
        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSua.Enabled = !btnSua.Enabled;
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgInfo.Enabled = !lcgInfo.Enabled;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtTenNV.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show(lbTenNV.Text+" không được để trống.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }
            if (txtCCCD.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show(lbCCCD.Text + " không được để trống.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Focus();
                return;
            }
            if (!BLLHamXuLyChung.CheckPhone(txtSDT.Text.Trim()))
            {
                XtraMessageBox.Show(lbSDT.Text + " không đúng định dạng.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            if (!BLLHamXuLyChung.CheckEmail(txtEmail.Text.Trim()))
            {
                XtraMessageBox.Show(lbEmail.Text + " không đúng định dạng.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            bllNV = new BLLNhanVien();
            //Check trùng sdt
            var nv = bllNV.getAll_NV().FirstOrDefault(t => t.phone == txtSDT.Text);
            if (nv!=null && txtSDT.Text!=DTOSession.SoDienThoai)
            {
                XtraMessageBox.Show(lbSDT.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            //Check trùng Email
            nv = bllNV.getAll_NV().FirstOrDefault(t => t.email == txtEmail.Text);
            if (nv != null && txtEmail.Text != DTOSession.Email)
            {
                XtraMessageBox.Show(lbEmail.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            //Check trùng CCCD
            nv = bllNV.getAll_NV().FirstOrDefault(t => t.cmnd == txtCCCD.Text);
            if (nv != null && txtCCCD.Text != DTOSession.CCCD)
            {
                XtraMessageBox.Show(lbCCCD.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Focus();
                return;
            }
            Employee empl = new Employee();
            empl.id = txtMaNV.Text.Trim();
            empl.name = txtTenNV.Text.Trim();
            empl.birthday = Convert.ToDateTime(deNgSinh.EditValue);
            empl.gender = rbtnNam.Checked ? rbtnNam.Text : rbtnNu.Text;
            empl.phone = txtSDT.Text.Trim();
            empl.email = txtEmail.Text.Trim();
            empl.cmnd = txtCCCD.Text.Trim();
            string kqUpd = bllNV.update(empl);

            if(kqUpd.Equals("1"))
            {
                XtraMessageBox.Show("Cập nhật thành công", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                btnSua.Enabled = !btnSua.Enabled;
                btnLuu.Enabled = !btnLuu.Enabled;
                btnHuy.Enabled = !btnHuy.Enabled;
                lcgInfo.Enabled = !lcgInfo.Enabled;

                DTOSession.TenNhanVien = empl.name;
                DTOSession.NgaySinh = Convert.ToDateTime(empl.birthday);
                DTOSession.GioiTinh = empl.gender;
                DTOSession.SoDienThoai = empl.phone;
                DTOSession.Email = empl.email;
                DTOSession.CCCD = empl.cmnd;

                return;
            }    
            XtraMessageBox.Show("Error: "+kqUpd, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            



        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSua.Enabled = !btnSua.Enabled;
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgInfo.Enabled = !lcgInfo.Enabled;
            loadData();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion


    }
}