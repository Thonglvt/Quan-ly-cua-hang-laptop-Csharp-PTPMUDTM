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

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        CauHinh cauHinh;
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        #region Method

        #endregion

        #region Event
        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            cboAuthentication.Items.Add("Windows Authentication");
            cboAuthentication.Items.Add("SQL Server Authentication");
            cboAuthentication.SelectedIndex = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboServeName_DropDown(object sender, EventArgs e)
        {
            try
            {
                cauHinh = new CauHinh();
                cboServerName.DataSource = cauHinh.GetServerName();
                cboServerName.DisplayMember = "ServerName";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        DataTable dt = new DataTable();
        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            try
            {
                cauHinh = new CauHinh();
                if (cboAuthentication.SelectedIndex == 1)
                {
                    if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                    {
                        XtraMessageBox.Show("Username or password cannot empty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cboDatabase.DataSource = cauHinh.GetDBNameByUser(cboServerName.Text
                        , txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    cboDatabase.DisplayMember = "name";
                }
                else
                {
                    cboDatabase.DataSource = cauHinh.GetDBNameByWindows(cboServerName.Text);
                    cboDatabase.DisplayMember = "name";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: "+ ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDatabase.DataSource = null;
                return;
            }
             
            
           
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboServerName.Text == string.Empty)
                {
                    XtraMessageBox.Show("Bạn chưa nhập Server name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboDatabase.Text == string.Empty)
                {
                    XtraMessageBox.Show("Bạn chưa chọn Database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cauHinh = new CauHinh();
                if (cboAuthentication.SelectedIndex == 1)
                {
                    if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                    {
                        XtraMessageBox.Show("Username or password cannot empty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cauHinh.SaveConfigUser(cboServerName.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text);
                }
                else
                {
                    cauHinh.SaveConfigWindows(cboServerName.Text, cboDatabase.Text);
                }
                XtraMessageBox.Show("Thay đổi cấu hình thành công!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            lcgAccount.Enabled = (cboAuthentication.SelectedIndex == 0) ? false : true;
        }

        #endregion


    }
}