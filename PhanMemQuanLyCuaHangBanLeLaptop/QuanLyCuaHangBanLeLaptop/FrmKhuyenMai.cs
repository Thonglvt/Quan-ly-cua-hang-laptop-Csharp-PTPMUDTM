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
using DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        BLLSanPham bllSP;
        BLLKhuyenMai bllKM;
        #endregion
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }


        #region Method
        private void loadData()
        {
            bllKM = new BLLKhuyenMai();
            gcSanPhamKM.DataSource = bllKM.getSanPhamKMNotNull();

        }
        private void emptyText()
        {
            sleSP.EditValue = null;
            txtGiaGiam.Value = 0;
        }
        private void loadSle()
        {
            bllSP = new BLLSanPham();
            sleSP.Properties.DataSource = bllSP.lstProducts();
            sleSP.Properties.DisplayMember = "id";
            sleSP.Properties.ValueMember = "id";

        }
        #endregion

        #region Event
        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            loadData();
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var maSP = gvSanPhamKM.GetRowCellValue(gvSanPhamKM.FocusedRowHandle, gvSanPhamKM.Columns["MaSP"]);
            var ngayBD = gvSanPhamKM.GetRowCellValue(gvSanPhamKM.FocusedRowHandle, gvSanPhamKM.Columns["date_start"]);
            var ngayKT = gvSanPhamKM.GetRowCellValue(gvSanPhamKM.FocusedRowHandle, gvSanPhamKM.Columns["date_end"]);

            if(Convert.ToDateTime(ngayKT)<DateTime.Now)
            {

                XtraMessageBox.Show("Không thể xóa (Vì khuyến mãi này đã kết thúc)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (maSP != null && ngayBD != null)
            {
                if (XtraMessageBox.Show("Bạn muốn xóa khuyến mãi này?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bllKM = new BLLKhuyenMai();
                    string kqDelete = bllKM.delete(maSP.ToString(), Convert.ToDateTime(ngayBD));
                    if (kqDelete.Equals("1"))
                    {
                        XtraMessageBox.Show("Xóa thành công", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                        loadData();
                        return;
                    }
                    XtraMessageBox.Show("Error: "+kqDelete, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void gvSanPhamKM_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
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
                    e.Appearance.ForeColor = Color.ForestGreen;
                }
            }
            if (e.Column.FieldName == "GiaBan")
            {
                string giaKM = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaSauKhuyenMai"]);
                string Gia = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaBan"]);
                if (!giaKM.Equals(Gia))
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Strikeout);
                }
            }
            if (e.Column.FieldName == "date_end")
            {
                DateTime ngayKT = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["date_end"]));
                if (ngayKT < DateTime.Now)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThem.Enabled = !btnThem.Enabled;
            lcgDetail.Enabled = !lcgDetail.Enabled;

            emptyText();

        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThem.Enabled = !btnThem.Enabled;
            lcgDetail.Enabled = !lcgDetail.Enabled;
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Kiểm tra khi text empty
            if (sleSP.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sleSP.Focus();
                return;
            }
            if (deNgayBD_Edit.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày bắt đầu khuyến mãi", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayBD_Edit.Focus();
                return;
            }
            if (deNgayKT_Edit.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày kết thúc khuyến mãi", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayKT_Edit.Focus();
                return;
            }
            if (Convert.ToDateTime(deNgayKT_Edit.EditValue) < DateTime.Now)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày kết thúc khuyến mãi lớn hơn ngày hiện tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayKT_Edit.Focus();
                return;
            }
            if (txtGiaGiam.Value == 0)
            {
                XtraMessageBox.Show("Giá khuyến mãi phải lớn hơn 0.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaGiam.Focus();
                return;
            }
            //Kiểm tra ngày kết thúc phải lớn hơn ngày bắt đầu
            DateTime ngayBD = Convert.ToDateTime(deNgayBD_Edit.EditValue);
            DateTime ngayKT = Convert.ToDateTime(deNgayKT_Edit.EditValue);
            if (ngayKT < ngayBD)
            {
                XtraMessageBox.Show("Ngày không hợp lệ (Ngày kết thúc > ngày bắt đầu khuyến mãi)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kiểm tra sản phẩm này còn trong thời gian khuyến mãi
            bllKM = new BLLKhuyenMai();
            string maSP = sleSP.EditValue.ToString();
            var checkKM = bllKM.getSanPhamKMNotNull().FirstOrDefault(t=>t.MaSP == maSP);
            if(checkKM!=null)
            {
                if(ngayBD <= checkKM.date_end)
                {
                    XtraMessageBox.Show("Sản phẩm này đang trong thời gian khuyến mãi (Chọn ngày bắt đầu lớn hơn ngày kết thúc khuyến mãi hiện có của sản phẩm)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
            }
            //Thêm khuyến mãi
            promotion prm = new promotion();
            prm.product_id = maSP;
            prm.date_start = ngayBD;
            prm.date_end = ngayKT;
            prm.price =  txtGiaGiam.Value;

            string kqInsert = bllKM.insert(prm);

            if (kqInsert.Equals("1"))
            {
                XtraMessageBox.Show("Đã thêm khuyến mãi của sản phẩm có mã "+maSP, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                btnHuy.PerformClick();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Error: "+kqInsert, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void sleSP_BeforePopup(object sender, EventArgs e)
        {
            loadSle();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        #endregion


    }
}