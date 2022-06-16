
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlSanPham = new DevExpress.XtraGrid.GridControl();
            this.gridViewSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuongHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkThuongHieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.seSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.seDaBan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.seGiaBan = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlSanPham = new DevExpress.XtraLayout.LayoutControl();
            this.acThongBao = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkThuongHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSanPham)).BeginInit();
            this.layoutControlSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlSanPham
            // 
            this.gridControlSanPham.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControlSanPham.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControlSanPham.Location = new System.Drawing.Point(12, 12);
            this.gridControlSanPham.MainView = this.gridViewSanPham;
            this.gridControlSanPham.Name = "gridControlSanPham";
            this.gridControlSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkThuongHieu,
            this.seSoLuong,
            this.seDaBan,
            this.seGiaBan,
            this.btnUpdate});
            this.gridControlSanPham.Size = new System.Drawing.Size(1222, 665);
            this.gridControlSanPham.TabIndex = 4;
            this.gridControlSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSanPham});
            // 
            // gridViewSanPham
            // 
            this.gridViewSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colThuongHieu,
            this.colSoLuong,
            this.colDaBan,
            this.colGiaBan,
            this.colUpdate});
            this.gridViewSanPham.GridControl = this.gridControlSanPham;
            this.gridViewSanPham.GroupPanelText = "Kéo cột vào đây để nhóm theo tên cột đó";
            this.gridViewSanPham.Name = "gridViewSanPham";
            this.gridViewSanPham.NewItemRowText = "Thêm mới sản phẩm";
            this.gridViewSanPham.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSanPham.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewSanPham.OptionsDetail.AutoZoomDetail = true;
            this.gridViewSanPham.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridViewSanPham.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colMaSP
            // 
            this.colMaSP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colMaSP.AppearanceCell.Options.UseFont = true;
            this.colMaSP.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSP.AppearanceHeader.Options.UseFont = true;
            this.colMaSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSP.Caption = "MÃ SẢN PHẨM";
            this.colMaSP.FieldName = "id";
            this.colMaSP.MinWidth = 25;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 100;
            // 
            // colTenSP
            // 
            this.colTenSP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenSP.AppearanceCell.Options.UseFont = true;
            this.colTenSP.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.AppearanceHeader.Options.UseFont = true;
            this.colTenSP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSP.Caption = "TÊN SẢN PHẨM";
            this.colTenSP.FieldName = "Name";
            this.colTenSP.MinWidth = 100;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 400;
            // 
            // colThuongHieu
            // 
            this.colThuongHieu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colThuongHieu.AppearanceCell.Options.UseFont = true;
            this.colThuongHieu.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colThuongHieu.AppearanceHeader.Options.UseFont = true;
            this.colThuongHieu.AppearanceHeader.Options.UseTextOptions = true;
            this.colThuongHieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThuongHieu.Caption = "THƯƠNG HIỆU";
            this.colThuongHieu.ColumnEdit = this.lkThuongHieu;
            this.colThuongHieu.FieldName = "trademark_id";
            this.colThuongHieu.MinWidth = 25;
            this.colThuongHieu.Name = "colThuongHieu";
            this.colThuongHieu.Visible = true;
            this.colThuongHieu.VisibleIndex = 2;
            this.colThuongHieu.Width = 107;
            // 
            // lkThuongHieu
            // 
            this.lkThuongHieu.AutoHeight = false;
            this.lkThuongHieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkThuongHieu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Mã#"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Tên thương hiệu")});
            this.lkThuongHieu.Name = "lkThuongHieu";
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSoLuong.AppearanceCell.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.Caption = "SỐ LƯỢNG";
            this.colSoLuong.FieldName = "quanlity";
            this.colSoLuong.MinWidth = 25;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.OptionsColumn.AllowFocus = false;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 107;
            // 
            // colDaBan
            // 
            this.colDaBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDaBan.AppearanceCell.Options.UseFont = true;
            this.colDaBan.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDaBan.AppearanceHeader.Options.UseFont = true;
            this.colDaBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colDaBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDaBan.Caption = "ĐÃ BÁN";
            this.colDaBan.FieldName = "purchase";
            this.colDaBan.MinWidth = 25;
            this.colDaBan.Name = "colDaBan";
            this.colDaBan.OptionsColumn.AllowEdit = false;
            this.colDaBan.Visible = true;
            this.colDaBan.VisibleIndex = 4;
            this.colDaBan.Width = 107;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGiaBan.AppearanceCell.Options.UseFont = true;
            this.colGiaBan.AppearanceCell.Options.UseTextOptions = true;
            this.colGiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiaBan.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGiaBan.AppearanceHeader.Options.UseFont = true;
            this.colGiaBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colGiaBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiaBan.Caption = "GIÁ BÁN";
            this.colGiaBan.DisplayFormat.FormatString = "{0:0,0}";
            this.colGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaBan.FieldName = "price";
            this.colGiaBan.MinWidth = 25;
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.OptionsColumn.AllowEdit = false;
            this.colGiaBan.OptionsColumn.AllowFocus = false;
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 5;
            this.colGiaBan.Width = 315;
            // 
            // colUpdate
            // 
            this.colUpdate.Caption = "Save";
            this.colUpdate.ColumnEdit = this.btnUpdate;
            this.colUpdate.MaxWidth = 50;
            this.colUpdate.MinWidth = 25;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Visible = true;
            this.colUpdate.VisibleIndex = 6;
            this.colUpdate.Width = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoHeight = false;
            editorButtonImageOptions2.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.saveall_32x32;
            this.btnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // seSoLuong
            // 
            this.seSoLuong.AutoHeight = false;
            this.seSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Name = "seSoLuong";
            // 
            // seDaBan
            // 
            this.seDaBan.AutoHeight = false;
            this.seDaBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDaBan.Name = "seDaBan";
            // 
            // seGiaBan
            // 
            this.seGiaBan.AutoHeight = false;
            this.seGiaBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGiaBan.Name = "seGiaBan";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnRefresh,
            this.btnLuu,
            this.btnThem,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.SvgImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.changeview;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.save_16x161;
            this.btnLuu.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.save_32x321;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 4;
            this.btnThem.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.add_16x16;
            this.btnThem.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.add_32x322;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1246, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1246, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 689);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1246, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 689);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1246, 689);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlSanPham;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1226, 669);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlSanPham
            // 
            this.layoutControlSanPham.Controls.Add(this.gridControlSanPham);
            this.layoutControlSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSanPham.Location = new System.Drawing.Point(0, 30);
            this.layoutControlSanPham.Name = "layoutControlSanPham";
            this.layoutControlSanPham.Root = this.Root;
            this.layoutControlSanPham.Size = new System.Drawing.Size(1246, 689);
            this.layoutControlSanPham.TabIndex = 0;
            this.layoutControlSanPham.Text = "layoutControl1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 719);
            this.Controls.Add(this.layoutControlSanPham);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkThuongHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSanPham)).EndInit();
            this.layoutControlSanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControlSanPham;
        private DevExpress.XtraGrid.GridControl gridControlSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colThuongHieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkThuongHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDaBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seDaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit seGiaBan;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUpdate;
        private DevExpress.XtraBars.Alerter.AlertControl acThongBao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}