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
using BLL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils;
using DevExpress.XtraEditors.ColorPick.Picker;
using DTO;
using DevExpress.XtraEditors.Controls;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.IO;
using QuanLyCuaHangBanLeLaptop.Popup;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmLapHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        //BLL
        BLLHoaDonBanHang bllHoaDonBH;
        BLLNhanVien bllNhanVien;
        BLLSanPham bllSanPham;
        BLLAutoCodeGeneration bllACG;
        BLLKhachHang bllKhachHang;
        //List<>
        List<DTOSanPhamKhuyenMai> lstSPKhuyenMai;
        List<DTOSanPhamKhuyenMai> lstSPKhuyenMai_CTHD = new List<DTOSanPhamKhuyenMai>();
        List<DTOSanPhamKhuyenMai> lstSPKhuyenMai_CTHD_Tam = new List<DTOSanPhamKhuyenMai>();
        List<ChiTietPhieuXuat> lstChiTietHoaDonKH = new List<ChiTietPhieuXuat>();//Thêm vào db
        List<DTOPhieuXuatKhachHang> lstHoaDon = new List<DTOPhieuXuatKhachHang>();//Thêm vào db
        PhieuXuat HoaDonKH;
        DTOChiTietDonHang lstChiTietDonHang;
        //Class
        PhieuXuat DonHang = new PhieuXuat();
        ChiTietPhieuXuat chiTietDH = new ChiTietPhieuXuat();
        #endregion
        public FrmLapHoaDonBanHang()
        {
            InitializeComponent();
        }

       

        #region Method
        void moDongDonHang()
        {
            layoutControlGroupDMSP.Enabled = !layoutControlGroupDMSP.Enabled;
            lbCTDH.Enabled = !lbCTDH.Enabled;
        }
        void loadData()
        {
            bllHoaDonBH = new BLLHoaDonBanHang();
            bllSanPham = new BLLSanPham();

            lstSPKhuyenMai = bllSanPham.lstSanPhamKhuyenMai();
            lstHoaDon = bllHoaDonBH.lstPhieuXuat_KH();
            gridControlSanPhamKM.DataSource = lstSPKhuyenMai;
        }
        int soLuongTmp = 1;
        void getSoLuongFromFromCon(int soLuong)
        {
            soLuongTmp = soLuong;
        }
        void dongMoThaoTac()
        {
            lbCTDH.Enabled = !btnHuy.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnTaoDH.Enabled = !btnTaoDH.Enabled;
            btnLuu.Enabled = !btnLuu.Enabled;
            colThemSPVaoDH.Visible = !colThemSPVaoDH.Visible;
        }
        #endregion

        #region Event
        private void FrmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            loadData();
            btnAddSPVaoDH.Click += BtnAddSPVaoDH_Click;
            btnDeleteCTHD.Click += BtnDeleteCTHD_Click;
            btnCapNhatCTHD.Click += BtnCapNhatCTHD_Click;
            //
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            colThemSPVaoDH.Visible = false;
            lbCTDH.Enabled = false;

        }
        private void BtnDeleteCTHD_Click(object sender, EventArgs e)
        {
            var maSP = gridViewCTHD.GetRowCellValue(gridViewCTHD.FocusedRowHandle, gridViewCTHD.Columns["MaSP"]);
            var sl = gridViewCTHD.GetRowCellValue(gridViewCTHD.FocusedRowHandle, gridViewCTHD.Columns["SoLuong"]);

            var find = lstSPKhuyenMai.Find(t => t.MaSP == maSP.ToString());
            find.SoLuong += Convert.ToInt32(sl);


            lstSPKhuyenMai_CTHD.RemoveAt(gridViewCTHD.FocusedRowHandle);

            gridControlCTDH.RefreshDataSource();
            gridControlSanPhamKM.RefreshDataSource();
        }

        private void BtnAddSPVaoDH_Click(object sender, EventArgs e)
        {
            //Kiểm tra số lượng còn hàng (Lưu ý load từ db chứ ko sài thuộc tính List)
            //Because có khách hàng đặt hàng qua web số lượng sp sẽ thay đổi List chưa đc cập nhật
            GridView view = sender as GridView;
            var maSP = gridViewSanPhamKM.GetRowCellValue(gridViewSanPhamKM.FocusedRowHandle, gridViewSanPhamKM.Columns["MaSP"]);
            var tenSP = gridViewSanPhamKM.GetRowCellValue(gridViewSanPhamKM.FocusedRowHandle, gridViewSanPhamKM.Columns["TenSP"]);
            var Gia = gridViewSanPhamKM.GetRowCellValue(gridViewSanPhamKM.FocusedRowHandle, gridViewSanPhamKM.Columns["GiaSauKhuyenMai"]);
            var prod = lstSPKhuyenMai.Find(t => t.MaSP == maSP.ToString());//Dùng để giảm số lượng sp
            var soLuong = gridViewSanPhamKM.GetRowCellValue(gridViewSanPhamKM.FocusedRowHandle, gridViewSanPhamKM.Columns["SoLuong"]);

            if (maSP != null && Gia != null)
            {
                //Kiểm tra số lượng còn hàng (Lưu ý load từ db chứ ko sài thuộc tính List)
                //Because có khách hàng đặt hàng qua web số lượng sp sẽ thay đổi
                if (bllSanPham.getSoLuongSPByMaSP(maSP.ToString()) == 0)
                {
                    XtraMessageBox.Show("Sản phẩm này tạm hết hàng.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Kiểm tra trên list tạm
                if (prod.SoLuong == 0)
                {
                    XtraMessageBox.Show("Sản phẩm này tạm hết hàng.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FrmDiaLogSoLuong frm = new FrmDiaLogSoLuong(maSP.ToString(), tenSP.ToString(),Convert.ToInt32(soLuong));
                frm.guiFormCha = new FrmDiaLogSoLuong.GETDATA(getSoLuongFromFromCon);
                frm.ShowDialog();
                //Kiểm tra sản phẩm tồn tại chưa: nếu Có (Số lượng + 1)
                foreach (var item in lstSPKhuyenMai_CTHD)
                {
                    if (item.MaSP.Equals(maSP.ToString()))
                    {
                        item.SoLuong += this.soLuongTmp;
                        item.ThanhTien = item.SoLuong * item.GiaBan;
                        gridControlCTDH.RefreshDataSource();
                        //Giảm số lượng sản phẩm
                        prod.SoLuong = (prod != null) ? prod.SoLuong - this.soLuongTmp : prod.SoLuong;
                        gridControlSanPhamKM.RefreshDataSource();
                        return;
                    }
                }
                DTOSanPhamKhuyenMai sp = new DTOSanPhamKhuyenMai();
                sp.MaSP = maSP.ToString();
                sp.SoLuong = this.soLuongTmp;
                sp.GiaBan = Convert.ToInt32(Gia);
                sp.ThanhTien = sp.GiaBan;
                prod.SoLuong = (prod != null) ? prod.SoLuong - this.soLuongTmp : prod.SoLuong;
                //Add giỏ hàng
                lstSPKhuyenMai_CTHD.Add(sp);

                gridControlCTDH.RefreshDataSource();
                gridControlSanPhamKM.RefreshDataSource();
            }



        }
        private void gridViewSanPhamKM_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            //Doi mau cell cua colummn giá khuyến mãi,
            //neu có giá khuyến mãi thi co mau xanh,
            if (e.Column.FieldName == "GiaSauKhuyenMai")
            {
                string giaKM = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaSauKhuyenMai"]);
                string Gia = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaBan"]);
                if (!giaKM.Equals(Gia))
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.Green;
                }
            }
            if (e.Column.FieldName == "GiaBan")
            {
                string giaKM = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaSauKhuyenMai"]);
                string Gia = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaBan"]);
                if (!giaKM.Equals(Gia))
                {
                    e.Appearance.Font = new Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
                }
            }
            if (e.Column.FieldName == "SoLuong")
            {
                var sl = View.GetRowCellDisplayText(e.RowHandle, View.Columns["SoLuong"]);
                if (sl != null)
                {
                    if (Convert.ToInt32(sl) == 0)
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                    else if (Convert.ToInt32(sl) <= 2)
                    {
                        e.Appearance.ForeColor = Color.Gold;
                    }
                }
            }
        }
        private void btnTaoDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            moDongDonHang();
            //string maDH = bllACG.createIDPhieuXuat();
            //layoutControlGroupCTDH.Text = "Chi tiết đơn hàng: #" + maDH;
            PhieuXuat hd = new PhieuXuat();
            //hd.employee_id
            XtraMessageBox.Show("Đã khởi tạo đơn hàng #", "Thông báo [Message]"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lookupEditKH_EditValueChanged(object sender, EventArgs e)
        {
            btnTaoDH.Enabled = true;
        }
        private void searchLookUpEdit1View_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridLookUpEdit gr = sender as GridLookUpEdit;
            var diaChiKH = searchLookUpEditKHView.GetRowCellValue(e.RowHandle, searchLookUpEditKHView.Columns["Address"]);
            if (diaChiKH != null)
            { this.DonHang.Address_ = diaChiKH.ToString(); return; }
            this.DonHang.Address_ = "Default";
        }
        private void searchLookUpEdit1_BeforePopup(object sender, EventArgs e)
        {
            bllKhachHang = new BLLKhachHang();
            searchLookUpEditKH.Properties.DataSource = bllKhachHang.GetCustomers();
            searchLookUpEditKH.Properties.DisplayMember = "name";
            searchLookUpEditKH.Properties.ValueMember = "id";
        }
        private void BtnCapNhatCTHD_Click(object sender, EventArgs e)
        {
            var soLuongMua = gridViewCTHD.GetRowCellValue(gridViewCTHD.FocusedRowHandle, gridViewCTHD.Columns["SoLuong"]);
            var maSP = gridViewCTHD.GetRowCellValue(gridViewCTHD.FocusedRowHandle, gridViewCTHD.Columns["MaSP"]);
            int soLuongTon = bllSanPham.getSoLuongSPByMaSP(maSP.ToString());
            if (soLuongTon == -1)
            {
                XtraMessageBox.Show("Sản phẩm này tạm ngưng bán.", "Thông báo [Message]"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridControlCTDH.RefreshDataSource();
                return;
            }
            if (Convert.ToInt32(soLuongMua) > soLuongTon)
            {
                lstSPKhuyenMai_CTHD = lstSPKhuyenMai_CTHD_Tam;
                gridControlCTDH.RefreshDataSource();
                //gridControlCTDH.DataSource = lstSPKhuyenMai_CTHD;
                XtraMessageBox.Show("Sản phẩm: #" + maSP + " không đủ số lượng để đáp ứng.", "Thông báo [Message]"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnTaoDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(searchLookUpEditKH.Text.Equals("Chọn khách hàng"))
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng bên dưới hoặc tra cứu khách hàng để thêm khách hàng mới.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //lbCTDH.Enabled = !btnHuy.Enabled;
            //btnHuy.Enabled = !btnHuy.Enabled;
            //btnTaoDH.Enabled = !btnTaoDH.Enabled;
            //btnLuu.Enabled = !btnLuu.Enabled;
            //colThemSPVaoDH.Visible = !colThemSPVaoDH.Visible;
            dongMoThaoTac();
            //this.DonHang.employee_id = DTOSession.MaNhanVien;
            this.DonHang.employee_id = "30102021NV000003";
            var s = searchLookUpEditKHView.GetRowCellValue(searchLookUpEditKHView.FocusedRowHandle, searchLookUpEditKHView.Columns["id"]);
            this.DonHang.customer_id = searchLookUpEditKH.EditValue.ToString();
            this.DonHang.date_ = DateTime.Now;
            this.DonHang.total = 0;
            this.DonHang.status = 0;

            gridControlCTDH.DataSource = lstSPKhuyenMai_CTHD;
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lstSPKhuyenMai_CTHD.Count == 0)
            {
                XtraMessageBox.Show("Không thể xuất hóa đơn vì đơn hàng rỗng.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Xác nhận thanh toán?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                bllACG = new BLLAutoCodeGeneration();
                this.DonHang.id = bllACG.createIDPhieuXuat();

                //B1: Kiểm tra số lượng tồn
                foreach (var item in lstSPKhuyenMai_CTHD)
                {
                    int soLuongTon = bllSanPham.getSoLuongSPByMaSP(item.MaSP);
                    if (soLuongTon == -1)
                    {
                        XtraMessageBox.Show("Sản phẩm này tạm ngưng bán.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (item.SoLuong > soLuongTon)
                    {
                        XtraMessageBox.Show("Sản phẩm: #" + item.MaSP + " không đủ số lượng để đáp ứng.", "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                //B2:Thêm phiếu xuất
                string kqInsertHD = bllHoaDonBH.insertPhieuXuat(this.DonHang);
                if (!kqInsertHD.Equals("1"))
                {
                    XtraMessageBox.Show(kqInsertHD, "Thông báo [Message]"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //B3: Add chi tiết phiếu xuất
                foreach (var item in lstSPKhuyenMai_CTHD)
                {
                    ChiTietPhieuXuat chiTietDH = new ChiTietPhieuXuat();
                    chiTietDH.phieuXuat_id = this.DonHang.id;
                    chiTietDH.product_id = item.MaSP;
                    chiTietDH.quanlity = item.SoLuong;
                    chiTietDH.price = item.GiaBan;
                    kqInsertHD = bllHoaDonBH.insertChiTietPhieuXuat(chiTietDH);
                    if (!kqInsertHD.Equals("1"))
                    {
                        XtraMessageBox.Show(kqInsertHD, "Thông báo [Message]"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                acThongBao.Show(this, "Thông báo", "Thêm đơn hàng thành công."
                           , "", Properties.Resources.success2___Copy, new Message());

                lstHoaDon = bllHoaDonBH.lstPhieuXuat_KH();
                lstSPKhuyenMai = bllSanPham.lstSanPhamKhuyenMai();
                gridControlSanPhamKM.DataSource = lstSPKhuyenMai;
                XtraMessageBox.Show("Thêm mới thành công đơn hàng có mã #" + this.DonHang.id, "Thông báo [Message]"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Mở report Invoice
                List<DTOPhieuXuatKhachHang> lstPXKH = new List<DTOPhieuXuatKhachHang>();
                bllHoaDonBH = new BLLHoaDonBanHang();
                lstPXKH = bllHoaDonBH.getPhieuXuat_KH_NV_SP_ByMaHD(this.DonHang.id);
                using (FrmPrint frm = new FrmPrint())
                {
                    frm.printInvoice(lstPXKH);
                    frm.ShowDialog();
                }
                lstSPKhuyenMai_CTHD = new List<DTOSanPhamKhuyenMai>();
                gridControlCTDH.DataSource = null;

                //btnLuu.Enabled = !btnLuu.Enabled;
                //btnHuy.Enabled = !btnHuy.Enabled;
                //btnTaoDH.Enabled = !btnTaoDH.Enabled;
                //colThemSPVaoDH.Visible = !colThemSPVaoDH.Visible;
                dongMoThaoTac();
            }

        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //btnTaoDH.Enabled = !btnTaoDH.Enabled;
            //btnLuu.Enabled = !btnLuu.Enabled;
            //btnHuy.Enabled = !btnHuy.Enabled;
            //colThemSPVaoDH.Visible = !colThemSPVaoDH.Visible;
            dongMoThaoTac();

            lstSPKhuyenMai_CTHD.Clear();

            gridControlCTDH.RefreshDataSource();

            searchLookUpEditKH.EditValue = null;

            this.lstSPKhuyenMai = bllSanPham.lstSanPhamKhuyenMai();
            gridControlSanPhamKM.DataSource = this.lstSPKhuyenMai;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strFind = txtSearch.Text.Trim();
            if(!BLLHamXuLyChung.CheckPhone(strFind))
            {
                XtraMessageBox.Show("Số điện thoại không đúng định dạng.", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            bllKhachHang = new BLLKhachHang();
            var kh = bllKhachHang.GetCustomers().FirstOrDefault(t => t.id.Equals(strFind) || t.phone.Equals(strFind) || t.cmnd.Equals(strFind) || t.name.Equals(strFind));
            if (kh != null)
            {
                XtraMessageBox.Show("Khách hàng đã tồn tại.", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            if (XtraMessageBox.Show("Khách hàng không tồn tại bạn có muốn thêm khách hàng mới không?", "Thông báo [Message]"
                       , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogThemKhachHangMoi dFrm = new DialogThemKhachHangMoi(strFind);
                dFrm.ShowDialog();
            }


        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        #endregion


    }
}