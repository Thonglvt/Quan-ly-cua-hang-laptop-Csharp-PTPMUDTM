using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLLMenu bllMenu = new BLLMenu();
        BLLNguoiDung bllTaiKhoan = new BLLNguoiDung();
        BLLQLNNhomNguoiDung bllQLNND = new BLLQLNNhomNguoiDung();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            skin();
            AddOrUpdateChucNangHeThong();
            loadRights();
            lbThongTinNhanVien.Caption = "( " + DTOSession.MaNhanVien + " - " 
                                                + DTOSession.TenNhanVien + " )";
        }
        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addForm(typeof(FrmSanPham));
        }


        //--------------------Các hàm xử lý trên form-----------
        //Set giao diện mặc định cho form main
        void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2016 Colorful";
        }
        //Hàm thêm form vào main form
        void addForm(Type tForm)
        {
            //Kiểm tra hiện tại form đã mở hay chưa?
            foreach (Form frm in MdiChildren)
            {
                //Nếu đang mở thì active lên
                if (frm.GetType() == tForm)
                {
                    frm.Activate();
                    return;
                }
            }
            //Add form vào Control
            Form f = (Form)Activator.CreateInstance(tForm);
            f.MdiParent = this;
            f.Show();
        }

        void AddOrUpdateChucNangHeThong()
        {
            //Vào menu tổng
            foreach (RibbonPage page in ribbonControl.Pages)
            {
                if (bllMenu.kiemTraChucNangDaTonTai(page.Name))//Cập nhật
                {
                    bool kq = bllMenu.ChekUpdateTowParameter(page.Name, page.Text);
                }
                else//Thêm mới
                {
                    bool kq = bllMenu.ChekAddTowParam(page.Name, page.Text.Trim());
                }
                //Vào group menu
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    if (bllMenu.kiemTraChucNangDaTonTai(pageGroup.Name))
                    {
                        bool kq = bllMenu.ChekUpdateThreeParameter(pageGroup.Name, pageGroup.Text, page.Name);
                    }
                    else
                    {
                        bool kq = bllMenu.ChekAddThreeParam(pageGroup.Name, pageGroup.Text, page.Name);
                    }
                    //Vào button
                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        if (bllMenu.kiemTraChucNangDaTonTai(barItemLink.Item.Name))
                        {
                            bool kq = bllMenu.ChekUpdateThreeParameter(barItemLink.Item.Name, barItemLink.Item.Caption, pageGroup.Name);
                        }
                        else
                        {
                            bool kq = bllMenu.ChekAddThreeParam(barItemLink.Item.Name, barItemLink.Item.Caption, pageGroup.Name);
                        }
                    }
                }
            }
        }
        public void loadRights()
        {
            var dt = bllQLNND.getRightsByNhomNoJoin(DTOGroupUser.GroupUser);

            foreach (RibbonPage page in ribbonControl.Pages)//Vào menu tổng
            {
                foreach (var item in dt)
                {
                    if (item.MaMenu == page.Name && item.CoQuyen == false)
                    {
                        page.Visible = false;
                    }
                }
                foreach (RibbonPageGroup pageGroup in page.Groups)//Vào group menu
                {
                    foreach (var item in dt)
                    {
                        if (item.MaMenu == pageGroup.Name && item.CoQuyen == false)
                        {
                            pageGroup.Visible = false;
                        }
                    }
                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        foreach (var item in dt)
                        {
                            if (item.MaMenu == barItemLink.Item.Name && item.CoQuyen == false)
                            {
                                barItemLink.Visible = false;
                            }
                        }
                    }
                }
            }
        }
        private void cn020202_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmPhanQuyen));
        }

        private void cn020103_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
            this.Close();
        }

        private void cn020201_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmNhomNguoiDung));
        }

        private void cn010301_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmSanPham));
        }

        private void cn010202_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmImportExcelTinhThanh));
        }

        private void cn010201_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmLapHoaDonBanHang));
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }
        private void cn010101_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmKhachHang));
        }

        private void cn010401_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmImportExcelTinhThanh));
        }

        private void cn010302_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmKhuyenMai));
        }

        private void cn010203_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmHoaDonBanHang));
        }
    }
}
