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

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmDiaLogSoLuong : DevExpress.XtraEditors.XtraForm
    {
        public delegate void GETDATA(int soLuong);
        public GETDATA guiFormCha;
        private int soLuongConLai;
        public FrmDiaLogSoLuong(string pMaSP,string pTenSP,int pSoLuong)
        {
            InitializeComponent();
            txtMaSP.Text = pMaSP;
            txtTenSP.Text = pTenSP;
            soLuongConLai = pSoLuong;
        }
        #region Method
        #endregion

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (guiFormCha != null)
            {
                guiFormCha(0);
            }
            this.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Value==0)
            {
                XtraMessageBox.Show("Vui lòng nhập " +lbSoLuong.Text, "Thông báo [Message]"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return; 
            }
            //Kiểm tra số lượng
            if (txtSoLuong.Value> soLuongConLai)
            {
                XtraMessageBox.Show(lbSoLuong.Text+" không đủ.", "Thông báo [Message]"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }
            if (guiFormCha != null)
            {
                guiFormCha(Convert.ToInt32(txtSoLuong.Value));
                this.Close();
            }    
                
        }
        #endregion


    }
}