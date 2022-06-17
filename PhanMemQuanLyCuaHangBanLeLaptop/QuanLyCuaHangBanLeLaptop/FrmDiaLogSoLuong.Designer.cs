
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmDiaLogSoLuong
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtTenSP = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgThongTinSP = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbSoLuong = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgThongTinSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtSoLuong);
            this.lcMain.Controls.Add(this.btnExit);
            this.lcMain.Controls.Add(this.btnConfirm);
            this.lcMain.Controls.Add(this.txtTenSP);
            this.lcMain.Controls.Add(this.txtMaSP);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(653, 292);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgThongTinSP});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(653, 292);
            this.Root.TextVisible = false;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(166, 55);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaSP.Size = new System.Drawing.Size(458, 28);
            this.txtMaSP.StyleController = this.lcMain;
            this.txtMaSP.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtMaSP;
            this.layoutControlItem1.Enabled = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(609, 42);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "Mã sản phẩm:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(125, 21);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(166, 97);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenSP.Size = new System.Drawing.Size(458, 118);
            this.txtTenSP.StyleController = this.lcMain;
            this.txtTenSP.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtTenSP;
            this.layoutControlItem2.Enabled = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(609, 132);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Text = "Tên sản phẩm:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(125, 21);
            // 
            // lcgThongTinSP
            // 
            this.lcgThongTinSP.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.lcgThongTinSP.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.lbSoLuong});
            this.lcgThongTinSP.Location = new System.Drawing.Point(0, 0);
            this.lcgThongTinSP.Name = "lcgThongTinSP";
            this.lcgThongTinSP.Size = new System.Drawing.Size(633, 272);
            this.lcgThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.SvgImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.checkbox2;
            this.btnConfirm.Location = new System.Drawing.Point(440, 224);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 44);
            this.btnConfirm.StyleController = this.lcMain;
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnConfirm;
            this.layoutControlItem4.Location = new System.Drawing.Point(416, 174);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(111, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.SvgImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.del5;
            this.btnExit.Location = new System.Drawing.Point(551, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 44);
            this.btnExit.StyleController = this.lcMain;
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnExit;
            this.layoutControlItem5.Location = new System.Drawing.Point(527, 174);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(82, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(166, 229);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(265, 28);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbSoLuong.AppearanceItemCaption.Options.UseFont = true;
            this.lbSoLuong.Control = this.txtSoLuong;
            this.lbSoLuong.Location = new System.Drawing.Point(0, 174);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(416, 48);
            this.lbSoLuong.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbSoLuong.Text = "Số lượng";
            this.lbSoLuong.TextSize = new System.Drawing.Size(125, 21);
            // 
            // FrmDiaLogSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 292);
            this.Controls.Add(this.lcMain);
            this.Name = "FrmDiaLogSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập số lượng sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgThongTinSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.MemoEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraLayout.LayoutControlGroup lcgThongTinSP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private DevExpress.XtraLayout.LayoutControlItem lbSoLuong;
    }
}