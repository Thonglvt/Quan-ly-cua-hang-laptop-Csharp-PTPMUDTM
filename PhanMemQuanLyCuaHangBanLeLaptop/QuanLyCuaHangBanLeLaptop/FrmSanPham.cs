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
        RefreshHelper helper;
        BLLSanPham bllSanPham = new BLLSanPham();
        BLLThuongHieu bllThuongHieu = new BLLThuongHieu();
        public FrmSanPham()
        {
            InitializeComponent();
            helper = new RefreshHelper(gridViewSanPham, "id");
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            loadThuongHieu();
            loadSanPham();
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var maSP = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["id"]);
            var tenSP = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["Name"]);
            var thuongHieu = gridViewSanPham.GetRowCellValue(gridViewSanPham.FocusedRowHandle, gridViewSanPham.Columns["trademark_id"]);

            if (maSP != null && tenSP != null&& thuongHieu != null)
            {
                if(bllSanPham.updateNameTrademarkProduct(maSP.ToString(),tenSP.ToString(),Convert.ToInt32(thuongHieu)))
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
        List<Product> lll;
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
        List<Product> listMovie;
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //GetData(100);
            loadSanPham();

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow dr;
            for (int i = 0; i < gridViewSanPham.RowCount; i++)
            {
                //dr = gridViewSanPham.GetDataRow(i);
                //if (dr != null)
                //{
                //    if (dr.RowState == DataRowState.Added)
                //    { 

                //    }
                //    if (dr.RowState == DataRowState.Modified)
                //    { }
                //}
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSanPham.AddNewRow();
            gridViewSanPham.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlSanPham.DataSource = lll;
        }
    }
}