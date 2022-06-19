
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmKhachHang
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
            this.gridControlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKhachHang
            // 
            this.gridControlKhachHang.Location = new System.Drawing.Point(12, 12);
            this.gridControlKhachHang.MainView = this.gridViewKhachHang;
            this.gridControlKhachHang.Name = "gridControlKhachHang";
            this.gridControlKhachHang.Size = new System.Drawing.Size(1178, 736);
            this.gridControlKhachHang.TabIndex = 4;
            this.gridControlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colSDT,
            this.colEmail,
            this.colCCCD,
            this.colSLDaMua,
            this.colTongTien,
            this.colDiaChi});
            this.gridViewKhachHang.GridControl = this.gridControlKhachHang;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.RowHeight = 30;
            // 
            // colMaKH
            // 
            this.colMaKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colMaKH.AppearanceCell.Options.UseFont = true;
            this.colMaKH.AppearanceCell.Options.UseTextOptions = true;
            this.colMaKH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colMaKH.AppearanceHeader.Options.UseFont = true;
            this.colMaKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaKH.Caption = "MÃ KHÁCH HÀNG";
            this.colMaKH.FieldName = "id";
            this.colMaKH.MinWidth = 25;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.AllowEdit = false;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            this.colMaKH.Width = 94;
            // 
            // colTenKH
            // 
            this.colTenKH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTenKH.AppearanceCell.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTenKH.AppearanceHeader.Options.UseFont = true;
            this.colTenKH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenKH.Caption = "TÊN KHÁCH HÀNG";
            this.colTenKH.FieldName = "name";
            this.colTenKH.MinWidth = 25;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.OptionsColumn.AllowEdit = false;
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            this.colTenKH.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colNgaySinh.AppearanceCell.Options.UseFont = true;
            this.colNgaySinh.AppearanceCell.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.colNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.Caption = "NGÀY SINH";
            this.colNgaySinh.FieldName = "birthday";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.AllowEdit = false;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 94;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colGioiTinh.AppearanceCell.Options.UseFont = true;
            this.colGioiTinh.AppearanceCell.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colGioiTinh.AppearanceHeader.Options.UseFont = true;
            this.colGioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.Caption = "GIỚI TÍNH";
            this.colGioiTinh.FieldName = "gender";
            this.colGioiTinh.MinWidth = 25;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSDT.AppearanceCell.Options.UseFont = true;
            this.colSDT.AppearanceCell.Options.UseTextOptions = true;
            this.colSDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colSDT.AppearanceHeader.Options.UseFont = true;
            this.colSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT.Caption = "SỐ ĐIỆN THOẠI";
            this.colSDT.FieldName = "phone";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "EMAIL";
            this.colEmail.FieldName = "email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 94;
            // 
            // colCCCD
            // 
            this.colCCCD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colCCCD.AppearanceCell.Options.UseFont = true;
            this.colCCCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colCCCD.AppearanceHeader.Options.UseFont = true;
            this.colCCCD.AppearanceHeader.Options.UseTextOptions = true;
            this.colCCCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCCCD.Caption = "CMND/CCCD";
            this.colCCCD.FieldName = "cmnd";
            this.colCCCD.MinWidth = 25;
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.OptionsColumn.AllowEdit = false;
            this.colCCCD.Visible = true;
            this.colCCCD.VisibleIndex = 6;
            this.colCCCD.Width = 94;
            // 
            // colSLDaMua
            // 
            this.colSLDaMua.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colSLDaMua.AppearanceCell.Options.UseFont = true;
            this.colSLDaMua.AppearanceCell.Options.UseTextOptions = true;
            this.colSLDaMua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSLDaMua.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colSLDaMua.AppearanceHeader.Options.UseFont = true;
            this.colSLDaMua.AppearanceHeader.Options.UseTextOptions = true;
            this.colSLDaMua.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSLDaMua.Caption = "ĐÃ MUA";
            this.colSLDaMua.FieldName = "countProducts";
            this.colSLDaMua.MinWidth = 25;
            this.colSLDaMua.Name = "colSLDaMua";
            this.colSLDaMua.OptionsColumn.AllowEdit = false;
            this.colSLDaMua.Visible = true;
            this.colSLDaMua.VisibleIndex = 7;
            this.colSLDaMua.Width = 94;
            // 
            // colTongTien
            // 
            this.colTongTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colTongTien.AppearanceCell.Options.UseFont = true;
            this.colTongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colTongTien.AppearanceHeader.Options.UseFont = true;
            this.colTongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.colTongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTongTien.Caption = "TỔNG TIỀN";
            this.colTongTien.DisplayFormat.FormatString = "{0:0,0}";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongTien.FieldName = "totalMoney";
            this.colTongTien.MinWidth = 25;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.OptionsColumn.AllowEdit = false;
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 9;
            this.colTongTien.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.colDiaChi.AppearanceCell.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.colDiaChi.AppearanceHeader.Options.UseFont = true;
            this.colDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "ĐỊA CHỈ";
            this.colDiaChi.FieldName = "Address";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 8;
            this.colDiaChi.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1202, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 760);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1202, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 760);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1202, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 760);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gridControlKhachHang);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(1202, 760);
            this.lcMain.TabIndex = 5;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1202, 760);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlKhachHang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1182, 740);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 760);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmKhachHang";
            this.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCCCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDaMua;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}