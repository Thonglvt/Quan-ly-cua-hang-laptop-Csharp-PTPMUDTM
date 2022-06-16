
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmHoaDonBanHang
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTaoDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSDT_KH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLapHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEditNgayLapHDKH = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colTongTienHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetailDH = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditNgayLapHDKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditNgayLapHDKH.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoDH,
            this.btnLuu,
            this.barButtonItem3,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoDH, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTaoDH
            // 
            this.btnTaoDH.Caption = "Tạo đơn";
            this.btnTaoDH.Description = "Chọn khách hàng sau đó tạo hóa đơn";
            this.btnTaoDH.Id = 0;
            this.btnTaoDH.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.insert_16x162;
            this.btnTaoDH.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.insert_32x322;
            this.btnTaoDH.Name = "btnTaoDH";
            this.btnTaoDH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 1;
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.saveto_16x161;
            this.btnLuu.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.saveto_32x323;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "HỦy";
            this.btnHuy.Id = 3;
            this.btnHuy.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.deletelist_16x161;
            this.btnHuy.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.deletelist_32x321;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xuất hóa đơn";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.printer_16x16;
            this.barButtonItem3.ImageOptions.LargeImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.printer_32x32;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1206, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 728);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1206, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1206, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 698);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gridControlPhieuXuat);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 30);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(1206, 698);
            this.lcMain.TabIndex = 4;
            this.lcMain.Text = "layoutControl1";
            // 
            // gridControlPhieuXuat
            // 
            this.gridControlPhieuXuat.Location = new System.Drawing.Point(12, 12);
            this.gridControlPhieuXuat.MainView = this.gridViewPhieuXuat;
            this.gridControlPhieuXuat.Name = "gridControlPhieuXuat";
            this.gridControlPhieuXuat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditNhanVien,
            this.DateEditNgayLapHDKH,
            this.btnDetailDH});
            this.gridControlPhieuXuat.Size = new System.Drawing.Size(1182, 674);
            this.gridControlPhieuXuat.TabIndex = 5;
            this.gridControlPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhieuXuat});
            // 
            // gridViewPhieuXuat
            // 
            this.gridViewPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colMaNhanVien,
            this.colSDT_KH,
            this.colTenKH,
            this.colNgayLapHD,
            this.colTongTienHD,
            this.colDiaChi,
            this.colTrangThai,
            this.colDetail});
            this.gridViewPhieuXuat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewPhieuXuat.GridControl = this.gridControlPhieuXuat;
            this.gridViewPhieuXuat.GroupPanelText = "Kéo thả cột vào đây để gom nhóm";
            this.gridViewPhieuXuat.Name = "gridViewPhieuXuat";
            this.gridViewPhieuXuat.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewPhieuXuat.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPhieuXuat.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridViewPhieuXuat.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPhieuXuat.OptionsPrint.PrintDetails = true;
            this.gridViewPhieuXuat.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewPhieuXuat.OptionsView.RowAutoHeight = true;
            this.gridViewPhieuXuat.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPhieuXuat_RowCellStyle);
            this.gridViewPhieuXuat.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewPhieuXuat_PopupMenuShowing);
            // 
            // colMaHD
            // 
            this.colMaHD.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaHD.AppearanceCell.Options.UseFont = true;
            this.colMaHD.AppearanceCell.Options.UseTextOptions = true;
            this.colMaHD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHD.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colMaHD.AppearanceHeader.Options.UseFont = true;
            this.colMaHD.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaHD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaHD.Caption = "MÃ HÓA ĐƠN #";
            this.colMaHD.FieldName = "id";
            this.colMaHD.MinWidth = 25;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.OptionsColumn.AllowEdit = false;
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            this.colMaHD.Width = 114;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaNhanVien.AppearanceCell.Options.UseFont = true;
            this.colMaNhanVien.AppearanceCell.Options.UseTextOptions = true;
            this.colMaNhanVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNhanVien.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colMaNhanVien.AppearanceHeader.Options.UseFont = true;
            this.colMaNhanVien.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNhanVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNhanVien.Caption = "NHÂN VIÊN";
            this.colMaNhanVien.ColumnEdit = this.LookUpEditNhanVien;
            this.colMaNhanVien.FieldName = "employee_id";
            this.colMaNhanVien.MinWidth = 25;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.AllowEdit = false;
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 1;
            this.colMaNhanVien.Width = 114;
            // 
            // LookUpEditNhanVien
            // 
            this.LookUpEditNhanVien.AutoHeight = false;
            this.LookUpEditNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditNhanVien.Name = "LookUpEditNhanVien";
            this.LookUpEditNhanVien.NullText = "Chọn nhân viên";
            // 
            // colSDT_KH
            // 
            this.colSDT_KH.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSDT_KH.AppearanceCell.Options.UseFont = true;
            this.colSDT_KH.AppearanceCell.Options.UseTextOptions = true;
            this.colSDT_KH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT_KH.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colSDT_KH.AppearanceHeader.Options.UseFont = true;
            this.colSDT_KH.AppearanceHeader.Options.UseTextOptions = true;
            this.colSDT_KH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT_KH.Caption = "SỐ ĐIỆN THOẠI KH";
            this.colSDT_KH.FieldName = "phone";
            this.colSDT_KH.MinWidth = 25;
            this.colSDT_KH.Name = "colSDT_KH";
            this.colSDT_KH.OptionsColumn.AllowEdit = false;
            this.colSDT_KH.Visible = true;
            this.colSDT_KH.VisibleIndex = 2;
            this.colSDT_KH.Width = 114;
            // 
            // colTenKH
            // 
            this.colTenKH.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenKH.AppearanceCell.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colTenKH.AppearanceHeader.Options.UseFont = true;
            this.colTenKH.Caption = "TÊN KHÁCH HÀNG";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.MinWidth = 25;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.OptionsColumn.AllowEdit = false;
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 3;
            this.colTenKH.Width = 84;
            // 
            // colNgayLapHD
            // 
            this.colNgayLapHD.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayLapHD.AppearanceCell.Options.UseFont = true;
            this.colNgayLapHD.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayLapHD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayLapHD.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colNgayLapHD.AppearanceHeader.Options.UseFont = true;
            this.colNgayLapHD.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayLapHD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayLapHD.Caption = "NGÀY LẬP";
            this.colNgayLapHD.ColumnEdit = this.DateEditNgayLapHDKH;
            this.colNgayLapHD.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.colNgayLapHD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLapHD.FieldName = "date_";
            this.colNgayLapHD.MinWidth = 25;
            this.colNgayLapHD.Name = "colNgayLapHD";
            this.colNgayLapHD.OptionsColumn.AllowEdit = false;
            this.colNgayLapHD.Visible = true;
            this.colNgayLapHD.VisibleIndex = 4;
            this.colNgayLapHD.Width = 114;
            // 
            // DateEditNgayLapHDKH
            // 
            this.DateEditNgayLapHDKH.AutoHeight = false;
            this.DateEditNgayLapHDKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditNgayLapHDKH.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.DateEditNgayLapHDKH.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditNgayLapHDKH.Name = "DateEditNgayLapHDKH";
            // 
            // colTongTienHD
            // 
            this.colTongTienHD.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTongTienHD.AppearanceCell.Options.UseFont = true;
            this.colTongTienHD.AppearanceCell.Options.UseTextOptions = true;
            this.colTongTienHD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTienHD.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colTongTienHD.AppearanceHeader.Options.UseFont = true;
            this.colTongTienHD.AppearanceHeader.Options.UseTextOptions = true;
            this.colTongTienHD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTienHD.Caption = "TỔNG TIỀN (VNĐ)";
            this.colTongTienHD.DisplayFormat.FormatString = "{0:0,0}";
            this.colTongTienHD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongTienHD.FieldName = "total";
            this.colTongTienHD.MinWidth = 25;
            this.colTongTienHD.Name = "colTongTienHD";
            this.colTongTienHD.OptionsColumn.AllowEdit = false;
            this.colTongTienHD.Visible = true;
            this.colTongTienHD.VisibleIndex = 5;
            this.colTongTienHD.Width = 114;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiaChi.AppearanceCell.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.Caption = "ĐỊA CHỈ KHÁCH HÀNG";
            this.colDiaChi.FieldName = "Address_";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 6;
            this.colDiaChi.Width = 310;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrangThai.AppearanceCell.Options.UseFont = true;
            this.colTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.colTrangThai.AppearanceHeader.Options.UseFont = true;
            this.colTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.Caption = "TRẠNG THÁI";
            this.colTrangThai.FieldName = "status";
            this.colTrangThai.MinWidth = 25;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.AllowEdit = false;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 7;
            this.colTrangThai.Width = 136;
            // 
            // colDetail
            // 
            this.colDetail.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetail.AppearanceCell.Options.UseFont = true;
            this.colDetail.Caption = "CHI TIẾT";
            this.colDetail.ColumnEdit = this.btnDetailDH;
            this.colDetail.MinWidth = 25;
            this.colDetail.Name = "colDetail";
            this.colDetail.Visible = true;
            this.colDetail.VisibleIndex = 8;
            this.colDetail.Width = 55;
            // 
            // btnDetailDH
            // 
            this.btnDetailDH.AutoHeight = false;
            this.btnDetailDH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xem", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDetailDH.Name = "btnDetailDH";
            this.btnDetailDH.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1206, 698);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlPhieuXuat;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1186, 678);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 748);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHoaDonBanHang_FormClosing);
            this.Load += new System.EventHandler(this.FrmHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditNgayLapHDKH.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditNgayLapHDKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetailDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTaoDH;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraGrid.GridControl gridControlPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhieuXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapHD;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DateEditNgayLapHDKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTienHD;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetailDH;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}