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
    public partial class DialogThemKhachHangMoi : DevExpress.XtraEditors.XtraForm
    {
        BLLTinhThanhPho bllTTP;
        BLLQuanHuyen bllQH;
        BLLPhuongXa bllPX;
        public DialogThemKhachHangMoi(string sdt)
        {
            InitializeComponent();
            txtSDT.Text = sdt;
        }


        #region Method
        void loadCboTTP()
        {
            bllTTP = new BLLTinhThanhPho();
            cboTinhTP.DataSource = bllTTP.GetTP();
            cboTinhTP.DisplayMember = "TenTinhThanhPho";
            cboTinhTP.ValueMember = "MaTinhThanhPho";

        }
        void loadCboQH(string maTTP)
        {
            bllQH = new BLLQuanHuyen();
            cboQuanHuyen.DataSource = bllQH.getQuanHuyenByTinhTP(maTTP);
            cboQuanHuyen.DisplayMember = "TenQuanHuyen";
            cboQuanHuyen.ValueMember = "MaQuanHuyen";
        }
        void loadCboPX(string maQH)
        {
            bllPX = new BLLPhuongXa();
            cboPhuongXa.DataSource = bllPX.getPhuongXaByQuanHuyen(maQH);
            cboPhuongXa.DisplayMember = "TenPhuongXa";
            cboPhuongXa.ValueMember = "MaPhuongXa";
        }
        #endregion

        #region Event
        private void DialogThemKhachHangMoi_Load(object sender, EventArgs e)
        {
            loadCboTTP();
        }
        private void rbtnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboTinhTP_SelectedIndexChanged(object sender, EventArgs e)     
        {
            loadCboQH(cboTinhTP.SelectedValue.ToString());
        }
        private void cboQuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCboPX(cboQuanHuyen.SelectedValue.ToString());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra rỗng
            if (txtTenKH.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return;
            }
            if (deNgaySinh.EditValue==null)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày sinh.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgaySinh.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập email.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập CMND/CCCD.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMND.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            //Check định dạng sdt
            if (!BLLHamXuLyChung.CheckPhone(txtSDT.Text))
            {
                XtraMessageBox.Show("Sai định dạng số điện thoại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            //Check định dạng email
            if (!BLLHamXuLyChung.CheckEmail(txtEmail.Text.ToString()))
            {
                XtraMessageBox.Show("Sai định dạng email.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            //Địa chỉ
            if (cboTinhTP.SelectedValue==null)
            {
                XtraMessageBox.Show("Vui lòng chọn tỉnh/thành phố.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTinhTP.Focus();
                return;
            }
            if (cboQuanHuyen.SelectedValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn quận/huyện.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboQuanHuyen.Focus();
                return;
            }
            if (cboPhuongXa.SelectedValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn phường/xã.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPhuongXa.Focus();
                return;
            }
            if (txtSoNha.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập só nhà, tên đường.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNha.Focus();
                return;
            }
            BLLKhachHang bllKH = new BLLKhachHang();
            BLLAutoCodeGeneration autoID = new BLLAutoCodeGeneration();
            Customer ct = new Customer();
            ct.id = autoID.createIDKH();
            ct.name = txtTenKH.Text.Trim();
            ct.birthday = Convert.ToDateTime(deNgaySinh.EditValue);
            ct.gender = (rbtnNam.Checked) ? rbtnNam.Text : rbtnNu.Text;
            ct.phone = txtSDT.Text.Trim();
            ct.email = txtEmail.Text.Trim();
            ct.cmnd = txtCMND.Text.Trim();
            ct.avatar = "";
            ct.countProducts = 0;
            ct.totalMoney = 0;
            ct.username = txtSDT.Text.Trim();
            ct.Address = txtSoNha.Text + ", " + cboPhuongXa.Text
                         + ", " + cboQuanHuyen.Text + ", " 
                         + cboTinhTP.Text.ToString();
            BLLNguoiDung bllND = new BLLNguoiDung();
            Account acc = new Account();
            acc.username = txtSDT.Text;
            acc.password = txtSDT.Text;
            acc.account_type = 2;
            string insertAcc = bllND.insert(acc);
            if (!insertAcc.Equals("1"))
            {
                XtraMessageBox.Show("Error: " + insertAcc, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            string kqInsert = bllKH.insert(ct);
            if (kqInsert.Equals("1"))
            {
                XtraMessageBox.Show("Thêm thành công", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Error: " + kqInsert, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion


    }
}