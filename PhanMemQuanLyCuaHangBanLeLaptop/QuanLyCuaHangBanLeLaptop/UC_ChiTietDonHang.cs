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
    public partial class UC_ChiTietDonHang : UserControl
    {
        BLLHoaDonBanHang bllHoaDon = new BLLHoaDonBanHang();
        ChiTietPhieuXuat pCTPX = new ChiTietPhieuXuat();
        List<ChiTietPhieuXuat> lstCTPX = new List<ChiTietPhieuXuat>();
        string MaHD;
        public UC_ChiTietDonHang(string pMaPX)
        {
            InitializeComponent();
            this.MaHD = pMaPX;
            bllHoaDon = new BLLHoaDonBanHang();
            gridControlCTHD.DataSource = bllHoaDon.GetChiTietPhieuXuats_Prod_KH_ByID(pMaPX);
        }

        private void UC_ChiTietDonHang_Load(object sender, EventArgs e)
        {
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            var prodID = gvCTHD.GetRowCellValue(gvCTHD.FocusedRowHandle, gvCTHD.Columns["product_id"]);
            var soLuong = gvCTHD.GetRowCellValue(gvCTHD.FocusedRowHandle, gvCTHD.Columns["quanlity"]);
            
            //Kiểm tra số lượng

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            
        }

        private void gridControlCTHD_Click(object sender, EventArgs e)
        {

        }
        //void checkHD(string pKQ)
        //{
        //    if (pKQ.Equals("Đã thanh toán"))
        //        dongThaoTac();
        //    else
        //        moThaoTac();
        //}
        //void dongThaoTac()
        //{
        //    txtMaHD.Enabled = false;
        //    txtDonGia.Enabled = false;
        //    txtSoLuong.Enabled = false;
        //    gridLookUpEditSP.Enabled = false;
        //    btnSave.Enabled = false;
        //}
        //void moThaoTac()
        //{
        //    txtMaHD.Enabled = true;
        //    txtDonGia.Enabled = true;
        //    txtSoLuong.Enabled = true;
        //    gridLookUpEditSP.Enabled = true;
        //    btnSave.Enabled = true;
        //}
    }
}
