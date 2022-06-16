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
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.Utils;
using DevExpress.XtraGrid.Menu;
using QuanLyCuaHangBanLeLaptop.Popup;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        BLLHoaDonBanHang bllHoaDonBH;
        BLLNhanVien bllNhanVien;
        public FrmHoaDonBanHang()
        {
            InitializeComponent();
        }

        void loadData()
        {
            bllHoaDonBH = new BLLHoaDonBanHang();
            gridControlPhieuXuat.DataSource = bllHoaDonBH.lstPhieuXuat_KH().OrderByDescending(t => t.date_);
        }
        void loadLookupEdit()
        {
            bllNhanVien = new BLLNhanVien();
            LookUpEditNhanVien.DataSource = bllNhanVien.lstMaTenNhanVien();
            LookUpEditNhanVien.DisplayMember = "name";
            LookUpEditNhanVien.ValueMember = "id";

        }
        private void FrmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            loadData();
            btnDetailDH.Click += BtnDetailDH_Click;
        }
        private void BtnDetailDH_Click(object sender, EventArgs e)
        {
            var maSP = gridViewPhieuXuat.GetRowCellValue(gridViewPhieuXuat.FocusedRowHandle, gridViewPhieuXuat.Columns["id"]);
            if (maSP != null)
            {
                var dlg = VBFlyoutDialog.ShowFormPopup(this, null, new UC_ChiTietDonHang(maSP.ToString()));
                if (dlg == DialogResult.OK)
                {
                    //lbl_username.Text = login.UserName;
                    //lblPassword.Text = login.Password;
                    //lblRemember.Text = login.isRemember.ToString();
                }
            }
        }


        

        private void FrmHoaDonBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridViewPhieuXuat.SaveLayoutToXml("data.xml", OptionsLayoutBase.FullLayout);
        }

        //Custom gridview
        #region
        //Menu item click handler 
        void OnFixedClick(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            MenuInfo info = item.Tag as MenuInfo;
            if (info == null) return;

            if (item.Caption.Substring(0, 3) == "Col")
            {
                if (item.Caption == "Color Customize...")
                {
                    ColorPickEdit colorPickerEdit = new ColorPickEdit();
                    FrmColorPicker frm = new FrmColorPicker(colorPickerEdit.Properties);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.TopMost = true;
                    if (frm.ShowDialog(colorPickerEdit.FindForm()) == System.Windows.Forms.DialogResult.OK)
                    {
                        info.Column.AppearanceCell.BackColor = frm.SelectedColor;
                    }

                }
                else
                {
                    info.Column.AppearanceCell.BackColor = ((Bitmap)item.Image).GetPixel(5, 5);
                }
            }
            else if (item.Caption.Substring(0, 3) == "Fon")
            {
                FontDialog fontDialog = new FontDialog();
                fontDialog.ShowDialog();
                info.Column.AppearanceCell.Font = fontDialog.Font;
            }
            else
            {
                if (item.Caption == "Chọn màu...")
                {
                    ColorPickEdit colorPickerEdit = new ColorPickEdit();
                    FrmColorPicker frm = new FrmColorPicker(colorPickerEdit.Properties);
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.TopMost = true;
                    if (frm.ShowDialog(colorPickerEdit.FindForm()) == System.Windows.Forms.DialogResult.OK)
                    {
                        info.Column.AppearanceCell.ForeColor = frm.SelectedColor;
                    }

                }
                else
                {
                    info.Column.AppearanceCell.ForeColor = ((Bitmap)item.Image).GetPixel(5, 5);
                }
            }


        }
        //Create a menu item 
        DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, FixedStyle style, Color color)
        {
            Image image = createImage(color);
            DXMenuCheckItem item = new DXMenuCheckItem(caption, column.Fixed == style, image, new EventHandler(OnFixedClick));
            item.Tag = new MenuInfo(column, style);
            return item;
        }
        public Image createImage(Color color)
        {
            Bitmap flag = new Bitmap(16, 16);
            Graphics flagGraphics = Graphics.FromImage(flag);
            Pen blackPen = new Pen(Color.Black, 2);
            Rectangle rect = new Rectangle(0, 0, 16, 16);
            flagGraphics.DrawRectangle(blackPen, rect);
            flagGraphics.FillRectangle(new SolidBrush(color), 1, 1, 14, 14);
            return flag;
        }
        class MenuInfo
        {
            public MenuInfo(GridColumn column, FixedStyle style)
            {
                this.Column = column;
                this.Style = style;
            }
            public FixedStyle Style;
            public GridColumn Column;
        }
        #endregion

        private void gridViewPhieuXuat_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
            {
                GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
                //menu.Items.Clear();
                if (menu.Column != null)
                {
                    // font chữ

                    DXMenuCheckItem font = new DXMenuCheckItem("Font chữ", true, null, new EventHandler(OnFixedClick));
                    font.Tag = new MenuInfo(menu.Column, FixedStyle.None);
                    menu.Items.Add(font);


                    // Màu nền
                    DXSubMenuItem sItem = new DXSubMenuItem("Màu nền");
                    Color mauhong = ColorTranslator.FromHtml("#FFC2BE");
                    Color mauxanh = ColorTranslator.FromHtml("#A8D5FF");
                    Color xanhduong = ColorTranslator.FromHtml("#C1F49C");
                    Color mauvang = ColorTranslator.FromHtml("#FEF7A5");
                    Color mautim = ColorTranslator.FromHtml("#E0CFE9");
                    Color xanhlam = ColorTranslator.FromHtml("#8DE9DF");
                    Color mautrang = ColorTranslator.FromHtml("#FFFFFF");
                    Color mauden = ColorTranslator.FromHtml("#000000");

                    sItem.Items.Add(CreateCheckItem("Color White", menu.Column, FixedStyle.None, mautrang));
                    sItem.Items.Add(CreateCheckItem("Color Black", menu.Column, FixedStyle.None, mauden));
                    sItem.Items.Add(CreateCheckItem("Color Pink", menu.Column, FixedStyle.None, mauhong));
                    sItem.Items.Add(CreateCheckItem("Color Blue", menu.Column, FixedStyle.None, mauxanh));
                    sItem.Items.Add(CreateCheckItem("Color Green", menu.Column, FixedStyle.None, xanhduong));
                    sItem.Items.Add(CreateCheckItem("Color Yellow", menu.Column, FixedStyle.None, mauvang));
                    sItem.Items.Add(CreateCheckItem("Color Purple", menu.Column, FixedStyle.None, mautim));
                    sItem.Items.Add(CreateCheckItem("Color Cyan", menu.Column, FixedStyle.None, xanhlam));

                    sItem.Items.Add(CreateCheckItem("Color Customize...", menu.Column, FixedStyle.None, Color.Transparent));
                    menu.Items.Add(sItem);

                    // màu chữ
                    DXSubMenuItem mauchu = new DXSubMenuItem("Màu chữ");
                    Color red = ColorTranslator.FromHtml("#F44336");
                    Color pink = ColorTranslator.FromHtml("#E91E63");
                    Color purple = ColorTranslator.FromHtml("#9C27B0");
                    Color DeepPurple = ColorTranslator.FromHtml("#673AB7");
                    Color Indigo = ColorTranslator.FromHtml("#E0CFE9");
                    Color blue = ColorTranslator.FromHtml("#3F51B5");
                    Color cyan = ColorTranslator.FromHtml("#00BCD4");
                    Color Teal = ColorTranslator.FromHtml("#009688");
                    Color green = ColorTranslator.FromHtml("#4CAF50");
                    Color Lime = ColorTranslator.FromHtml("#CDDC39");
                    Color Amber = ColorTranslator.FromHtml("#FFC107");
                    Color Orange = ColorTranslator.FromHtml("#FF9800");
                    Color depOrange = ColorTranslator.FromHtml("#FF5722");
                    Color brown = ColorTranslator.FromHtml("#795548");
                    Color grey = ColorTranslator.FromHtml("#9E9E9E");
                    Color BlueGrey = ColorTranslator.FromHtml("#607D8B");
                    Color Black = ColorTranslator.FromHtml("#000000");
                    Color White = ColorTranslator.FromHtml("#FFFFFF");

                    mauchu.Items.Add(CreateCheckItem("Black", menu.Column, FixedStyle.None, Black));
                    mauchu.Items.Add(CreateCheckItem("White", menu.Column, FixedStyle.None, White));
                    mauchu.Items.Add(CreateCheckItem("Red", menu.Column, FixedStyle.None, red));
                    mauchu.Items.Add(CreateCheckItem("Pink", menu.Column, FixedStyle.None, pink));
                    mauchu.Items.Add(CreateCheckItem("Purple", menu.Column, FixedStyle.None, purple));
                    mauchu.Items.Add(CreateCheckItem("Deep Purple", menu.Column, FixedStyle.None, DeepPurple));
                    mauchu.Items.Add(CreateCheckItem("Indigo", menu.Column, FixedStyle.None, Indigo));
                    mauchu.Items.Add(CreateCheckItem("Blue", menu.Column, FixedStyle.None, blue));
                    mauchu.Items.Add(CreateCheckItem("Cyan", menu.Column, FixedStyle.None, cyan));
                    mauchu.Items.Add(CreateCheckItem("Teal", menu.Column, FixedStyle.None, Teal));
                    mauchu.Items.Add(CreateCheckItem("Green", menu.Column, FixedStyle.None, green));
                    mauchu.Items.Add(CreateCheckItem("Lime", menu.Column, FixedStyle.None, Lime));
                    mauchu.Items.Add(CreateCheckItem("Amber", menu.Column, FixedStyle.None, Amber));
                    mauchu.Items.Add(CreateCheckItem("Orange", menu.Column, FixedStyle.None, Orange));
                    mauchu.Items.Add(CreateCheckItem("Deep Orange", menu.Column, FixedStyle.None, depOrange));
                    mauchu.Items.Add(CreateCheckItem("Brown", menu.Column, FixedStyle.None, brown));
                    mauchu.Items.Add(CreateCheckItem("Grey", menu.Column, FixedStyle.None, grey));
                    mauchu.Items.Add(CreateCheckItem("Blue Grey", menu.Column, FixedStyle.None, BlueGrey));

                    mauchu.Items.Add(CreateCheckItem("Chọn màu...", menu.Column, FixedStyle.None, Color.Transparent));
                    menu.Items.Add(mauchu);

                }
            }
        }

        private void gridViewPhieuXuat_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            //doi mau row chẵn
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.MintCream;
                }
            }
            //Doi mau cell cua colummn status,
            //neu co gia tri Actived thi co mau xanh,
            //neu co gia tri N/A thi co màu đỏ
            if (e.Column.FieldName == "status")
            {
                string stt = View.GetRowCellDisplayText(e.RowHandle, View.Columns["status"]);
                if (stt.Equals("Chưa thanh toán"))
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    e.Appearance.ForeColor = Color.LimeGreen;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Italic);
                }
            }
        }
    }
}