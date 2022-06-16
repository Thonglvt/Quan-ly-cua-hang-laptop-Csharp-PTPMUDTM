using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmNhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Message msg = new Message();
        BLLQLNNhomNguoiDung bllQLNND = new BLLQLNNhomNguoiDung();
        BLLNhomNguoiDung bllNhomND = new BLLNhomNguoiDung();
        BLLHamXuLyChung bllHamXuLy = new BLLHamXuLyChung();
        BLLNguoiDung bllNguoiDung = new BLLNguoiDung();
        public FrmNhomNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmNhomNguoiDung_Load(object sender, EventArgs e)
        {
            loadNhomNguoiDung();
            unenableText();
            loadNguoiDung();
            btnluu.Enabled = false;
            btnXoa.Enabled = false;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }
        void loadNhomNguoiDung()
        {
            gridControlNhomND.DataSource = bllNhomND.lstGroup();
            txtMaNhom.Focus();
            lookUpEditNhomND.Properties.DataSource = bllNhomND.lstGroup();
            lookUpEditNhomND.Properties.DisplayMember = "TenNhom";
            lookUpEditNhomND.Properties.ValueMember = "MaNhom";
            lookUpEditNhomND.Properties.NullText = "Chọn nhóm người dùng";
        }
        void loadNguoiDung()
        {
            gridControlDSNguoiDung.DataSource = bllNguoiDung.lstAccountEmployeeMix();
            gridControlDSNDThuocMaNhomND.DataSource = bllNguoiDung.lstAccountEmployeeMix();
        }
        void unenableText()
        {
            txtMaNhom.Enabled = false;
            txtTenNhom.Enabled = false;
            txtGhiChu.Enabled = false;
        }
        void enableText()
        {
            txtMaNhom.Enabled = true;
            txtTenNhom.Enabled = true;
            txtGhiChu.Enabled = true;
        }
        void emptyText()
        {
            txtMaNhom.Text = string.Empty;
            txtTenNhom.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var maNhom = gridViewNhomQuyen.GetRowCellValue(gridViewNhomQuyen.FocusedRowHandle, gridViewNhomQuyen.Columns["MaNhom"]);
            var tenNhom = gridViewNhomQuyen.GetRowCellValue(gridViewNhomQuyen.FocusedRowHandle, gridViewNhomQuyen.Columns["TenNhom"]);
            var ghiChu = gridViewNhomQuyen.GetRowCellValue(gridViewNhomQuyen.FocusedRowHandle, gridViewNhomQuyen.Columns["GhiChu"]);
            if (maNhom != null && tenNhom != null && ghiChu != null)
            {
                txtMaNhom.Text = maNhom.ToString();
                txtTenNhom.Text = tenNhom.ToString();
                txtGhiChu.Text = ghiChu.ToString();

                btnXoa.Enabled = true;
                btnluu.Enabled = false;
                btnSua.Enabled = true;
                unenableText();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            emptyText();
            enableText();
            txtMaNhom.Focus();
            btnluu.Enabled = true;
        }

        private void txtMaNhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Down)
            {
                txtTenNhom.Focus();
            }
        }

        private void txtTenNhom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Up)
            {
                txtMaNhom.Focus();
            }
        }

        private void txtTenNhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Down)
            {
                txtGhiChu.Focus();
            }
        }

        private void txtGhiChu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Up)
            {
                txtTenNhom.Focus();
            }
        }

        private void txtMaNhom_KeyPress(object sender, KeyPressEventArgs e)
        {
            string convert = bllHamXuLy.convertToUnSign(txtMaNhom.Text.Trim());
            txtMaNhom.Text = convert;
        }

        private void txtMaNhom_Leave(object sender, EventArgs e)
        {
            string convert = bllHamXuLy.convertToUnSign(txtMaNhom.Text.Trim());
            txtMaNhom.Text = convert;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenNhom.Enabled = true;
            txtGhiChu.Enabled = true;
            txtTenNhom.Focus();
            btnluu.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadNhomNguoiDung();
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNhom = bllHamXuLy.convertToUnSign(txtMaNhom.Text.Trim());
            string tenNhom = txtTenNhom.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            //Thêm mới
            if(txtMaNhom.Enabled)
            {
                if(maNhom ==string.Empty)
                {
                    errProThongBao.SetError(txtMaNhom, lbMaNhom.Text + " không được để trống.");
                    return;
                    //acThongBao.Show(this, "Thông báo", lbMaNhom.Text + " không được để trống.","", Properties.Resources.warning_32x32, msg);
                }
                if(tenNhom == string.Empty)
                {
                    errProThongBao.SetError(txtMaNhom, lbTenNhom.Text + " không được để trống.");
                    return;
                }  
                else
                {
                    //Kiểm tra khóa chính
                    if(bllNhomND.checkKhoaChinh(maNhom))
                    {
                        XtraMessageBox.Show(lbMaNhom.Text+ " đã tồn tại [ \""+txtMaNhom.Text+"\" already exists]", "Thông báo [Message]"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bllNhomND.insert(maNhom, tenNhom, ghiChu);
                    acThongBao.Show(this, "Thông báo", "Thêm mới thành công."
                        , "",Properties.Resources.success2___Copy, msg);
                    loadNhomNguoiDung();
                    unenableText();
                    btnluu.Enabled = false;
                    //btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    emptyText();
                }
            }    
            //Cập nhật
            else
            {
                bllNhomND.update(maNhom, tenNhom, ghiChu);
                acThongBao.Show(this, "Thông báo", "Cập nhật thành công."
                        , "", Properties.Resources.success2___Copy, msg);
                loadNhomNguoiDung();
                unenableText();
                btnluu.Enabled = false;
                //btnXoa.Enabled = false;
                btnSua.Enabled = false;
                emptyText();
            }    
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (XtraMessageBox.Show("Xác nhận xóa", "Thông báo [Message]", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    e.Cancle = true;
            //}
            if (XtraMessageBox.Show("Xác nhận xóa", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gridViewNhomQuyen.SelectedRowsCount > 0)
                {
                    //Kiểm tra khóa ngoại trên bản phân quyền
                    var maNhom = gridViewNhomQuyen.GetRowCellValue(gridViewNhomQuyen.FocusedRowHandle, gridViewNhomQuyen.Columns["MaNhom"]);
                    if (bllNhomND.checkKhoaNgoaiOnTblPhanQuyen(maNhom.ToString()))
                    {
                        XtraMessageBox.Show("Nhóm người dùng này đang được sử dụng để phân quyền [User group already used].", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    bllNhomND.delete(maNhom.ToString().Trim());
                    acThongBao.Show(this, "Thông báo", "Xóa thành công."
                            , "", Properties.Resources.success2___Copy, msg);
                    loadNhomNguoiDung();
                    unenableText();
                    btnluu.Enabled = false;
                    //btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    emptyText();
                }
            }
        }

        private void lookUpEditNhomND_EditValueChanged(object sender, EventArgs e)
        {
            string maNhom = lookUpEditNhomND.EditValue.ToString();
            string tenNhom = lookUpEditNhomND.Text.ToString();
            gridControlDSNDThuocMaNhomND.DataSource = bllNguoiDung.lstEmpByGroup(maNhom);
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            layoutControlGroupNDThuocNhom.Text = "Người dùng thuộc nhóm [" + tenNhom + "]:";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var username = gridViewNguoiDung.GetRowCellValue(gridViewNguoiDung.FocusedRowHandle, gridViewNguoiDung.Columns["username"]);
            var maNhom = lookUpEditNhomND.EditValue.ToString();
            
            //Kiểm tra user đã thuộc nhóm này hay chưa
            if(bllNguoiDung.kiemTraNguoiDungTonTaiInNhomND(username.ToString(),maNhom.ToString())==true)
            {
                XtraMessageBox.Show("Người dùng hiện đã có trong nhóm này.[User already exists in the group]", "Thông báo [Message]"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //add vào nhóm
            bool kq = bllNguoiDung.insertUserToGroup(username.ToString(), maNhom.ToString());
            if (kq)
            {
                acThongBao.Show(this, "Thông báo", "Thêm người dùng vào nhóm thành công."
                             , "", Properties.Resources.success2___Copy, msg);
                gridControlDSNDThuocMaNhomND.DataSource = bllNguoiDung.lstEmpByGroup(maNhom);
            }
            else
            {
                XtraMessageBox.Show("Người dùng này đã thuộc nhóm khác.", "Thông báo [Message]"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var username = gridViewUserThuocNhomND.GetRowCellValue(gridViewUserThuocNhomND.FocusedRowHandle, gridViewUserThuocNhomND.Columns["username"]);
            var maNhom = lookUpEditNhomND.EditValue.ToString();

            //add vào nhóm
            bool kq = bllNguoiDung.removeUserFromGroup(username.ToString(), maNhom.ToString());
            acThongBao.Show(this, "Thông báo", "Thao tác thành công."
                         , "", Properties.Resources.success2___Copy, msg);
            gridControlDSNDThuocMaNhomND.DataSource = bllNguoiDung.lstEmpByGroup(maNhom);
        }

        private void gridViewNhomQuyen_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
            GridView view = sender as GridView;
            object row = view.GetRow(e.RowHandle);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridViewNhomQuyen.DataRowCount; i++)
            {
                XtraMessageBox.Show(gridViewNhomQuyen.GetRowCellValue(i, "TenNhom").ToString());
                //do something  
            }
        }
    }
}