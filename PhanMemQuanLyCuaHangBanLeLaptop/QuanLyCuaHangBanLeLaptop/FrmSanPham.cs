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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DTO;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmSanPham : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        RefreshHelper helper;
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLThuongHieu bllThuongHieu = new BLLThuongHieu();
        List<Product> listMovie;
        BLLLoaiSanPham bllLSP;
        BLLAutoCodeGeneration bllACG;
        BLLChiTIetSanPham bllCTSP;
        #endregion

        public FrmSanPham()
        {
            InitializeComponent();
            helper = new RefreshHelper(gridViewSanPham, "id");
        }

        #region Method
        void loadSanPham()
        {
            //QL_LaptopDataContext db = new QL_LaptopDataContext();
            //gridControlSanPham.DataSource= db.Products.ToList();
            bllSanPham = new BLLSanPham();
            gridControlSanPham.DataSource = bllSanPham.lstProducts();
        }
        void loadThuongHieu()
        {
            lkThuongHieu.DataSource = bllThuongHieu.lstThuongHieus();
            lkThuongHieu.DisplayMember = "name";
            lkThuongHieu.ValueMember = "id";
            lkThuongHieu.NullText = "Chọn thương hiệu";
        }
        void loadSLE_DSSP()
        {
            bllLSP = new BLLLoaiSanPham();
            bllThuongHieu = new BLLThuongHieu();

            sleLoaiSP.DataSource = bllLSP.getAll();
            sleLoaiSP.DisplayMember = "CateName";
            sleLoaiSP.ValueMember = "CateID";
        }    
        void loadSLE_ThongTin()
        {
            bllLSP = new BLLLoaiSanPham();
            bllThuongHieu = new BLLThuongHieu();
            sleLoaiSPTTSP.Properties.DataSource = bllLSP.getAll();
            sleLoaiSPTTSP.Properties.DisplayMember = "CateName";
            sleLoaiSPTTSP.Properties.ValueMember = "CateID";

            sleThuongHieu.Properties.DataSource = bllThuongHieu.lstThuongHieus();
            sleThuongHieu.Properties.DisplayMember = "name";
            sleThuongHieu.Properties.ValueMember = "id";
        }
        void dongMoThaoTac()
        {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgThongTinSP.Enabled = !lcgThongTinSP.Enabled;
            emptyThongTin();
        }
        void emptyThongTin()
        {
            txtMaSP.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            sleLoaiSPTTSP.EditValue = null;
            sleThuongHieu.EditValue = null;


        }
        //Refresh data
        public async void GetData(int numRecord)
        {
            helper.SaveViewInfo();
            listMovie = new List<Product>();
            //listMovie.Clear();
            gridViewSanPham.ShowLoadingPanel();
            listMovie = bllSanPham.lstProducts();
            if (listMovie != null)

            {
                //gridControlSanPham.DataSource = listMovie.Take(numRecord);
                gridControlSanPham.DataSource = bllSanPham.lstProducts();
                gridViewSanPham.HideLoadingPanel();
                helper.LoadViewInfo();
            }
        }
        //public Task<List<Result>> LoadDataAsync()
        //{
        //    return Task.Run(() => {
        //        var json = File.ReadAllText("movie.json");
        //        var data = JsonConvert.DeserializeObject<List<Result>>(json);
        //        return data;
        //    });
        //}
        #endregion

        #region Event
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            loadThuongHieu();
            loadSanPham();
            btnUpdate.Click += BtnUpdate_Click;
            loadSLE_DSSP();
            loadSLE_ThongTin();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var maSP = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["id"]);
            var tenSP = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["Name"]);
            var thuongHieu = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["trademark_id"]);

            if (maSP != null && tenSP != null && thuongHieu != null)
            {
                if (bllSanPham.updateNameTrademarkProduct(maSP.ToString(), tenSP.ToString(), Convert.ToInt32(thuongHieu)))
                {
                    acThongBao.Show(this, "Thông báo", "Cập nhật thành công."
                       , "", Properties.Resources.success2___Copy, new Message());
                    GetData(100);
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật! Vui lòng kiểm tra lại thông tin", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            return;

        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //GetData(100);
            loadSanPham();

        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Check rỗng
            if(txtTenSP.Text.Trim()==string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sleThuongHieu.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn thương hiệu", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sleLoaiSPTTSP.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn loại sản phẩm", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDonGia.Value <=0)
            {
                XtraMessageBox.Show("Vui lòng nhập giá bán", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product p = new Product();
            bllACG = new BLLAutoCodeGeneration();
            p.id = bllACG.createIDProducts();
            p.Name = txtTenSP.Text.Trim();
            p.quanlity = Convert.ToInt32(txtSoLuong.Value);
            p.purchase = 0;
            p.price = txtDonGia.Value;
            p.trademark_id = Convert.ToInt32(sleThuongHieu.EditValue);
            p.avatar = "";
            p.view_ = 0;
            p.CateID = sleLoaiSPTTSP.EditValue.ToString();
            bllSanPham = new BLLSanPham();
            bllCTSP = new BLLChiTIetSanPham();
            string kqInsert = bllSanPham.insertProduct(p);
            if (kqInsert.Equals("1"))
            {
                XtraMessageBox.Show("Thêm sản phẩm thành công", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.None);
                dongMoThaoTac();
                btnThem.Enabled = !btnThem.Enabled;
                loadSanPham();
                return;
            }
            XtraMessageBox.Show("Error: "+ kqInsert, "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoThaoTac();
            btnThem.Enabled = !btnThem.Enabled;
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoThaoTac();
            btnThem.Enabled = !btnThem.Enabled;
        }
        private void sleThuongHieu_BeforePopup(object sender, EventArgs e)
        {
            loadSLE_ThongTin();
        }

        private void sleLoaiSPTTSP_BeforePopup(object sender, EventArgs e)
        {
            loadSLE_ThongTin();
        }
        #endregion


    }
}