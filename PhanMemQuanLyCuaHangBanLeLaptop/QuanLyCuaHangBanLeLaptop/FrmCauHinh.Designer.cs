
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmCauHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauHinh));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgNhapThongTin = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbServerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbUsername = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgAccount = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cboAuthentication = new System.Windows.Forms.ComboBox();
            this.lbAuthen = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNhapThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbServerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAuthen)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.cboAuthentication);
            this.lcMain.Controls.Add(this.layoutControl1);
            this.lcMain.Controls.Add(this.btnThoat);
            this.lcMain.Controls.Add(this.btnLuu);
            this.lcMain.Controls.Add(this.cboDatabase);
            this.lcMain.Controls.Add(this.txtPassword);
            this.lcMain.Controls.Add(this.txtUsername);
            this.lcMain.Controls.Add(this.cboServerName);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(607, 367);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(24, 298);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(360, 45);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(360, 45);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.deletedatasource_32x32;
            this.btnThoat.Location = new System.Drawing.Point(480, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 36);
            this.btnThoat.StyleController = this.lcMain;
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.managedatasource_32x32;
            this.btnLuu.Location = new System.Drawing.Point(388, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 36);
            this.btnLuu.StyleController = this.lcMain;
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboDatabase
            // 
            this.cboDatabase.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(139, 264);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(440, 29);
            this.cboDatabase.TabIndex = 7;
            this.cboDatabase.DropDown += new System.EventHandler(this.cboDatabase_DropDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(412, 28);
            this.txtPassword.StyleController = this.lcMain;
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(153, 170);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(412, 28);
            this.txtUsername.StyleController = this.lcMain;
            this.txtUsername.TabIndex = 5;
            // 
            // cboServerName
            // 
            this.cboServerName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(139, 54);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(440, 29);
            this.cboServerName.TabIndex = 4;
            this.cboServerName.DropDown += new System.EventHandler(this.cboServeName_DropDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgNhapThongTin});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(607, 367);
            this.Root.TextVisible = false;
            // 
            // lcgNhapThongTin
            // 
            this.lcgNhapThongTin.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.lcgNhapThongTin.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbServerName,
            this.lbDatabase,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.lcgAccount,
            this.lbAuthen});
            this.lcgNhapThongTin.Location = new System.Drawing.Point(0, 0);
            this.lcgNhapThongTin.Name = "lcgNhapThongTin";
            this.lcgNhapThongTin.Size = new System.Drawing.Size(587, 347);
            this.lcgNhapThongTin.Text = "Thông tin cấu hình";
            // 
            // lbServerName
            // 
            this.lbServerName.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbServerName.AppearanceItemCaption.Options.UseFont = true;
            this.lbServerName.Control = this.cboServerName;
            this.lbServerName.Location = new System.Drawing.Point(0, 0);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(563, 38);
            this.lbServerName.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lbServerName.Text = "Server name";
            this.lbServerName.TextSize = new System.Drawing.Size(108, 21);
            // 
            // lbUsername
            // 
            this.lbUsername.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbUsername.AppearanceItemCaption.Options.UseFont = true;
            this.lbUsername.Control = this.txtUsername;
            this.lbUsername.Location = new System.Drawing.Point(0, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(535, 40);
            this.lbUsername.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lbUsername.Text = "Username";
            this.lbUsername.TextSize = new System.Drawing.Size(108, 21);
            // 
            // lbPass
            // 
            this.lbPass.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbPass.AppearanceItemCaption.Options.UseFont = true;
            this.lbPass.Control = this.txtPassword;
            this.lbPass.Location = new System.Drawing.Point(0, 40);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(535, 40);
            this.lbPass.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lbPass.Text = "Password";
            this.lbPass.TextSize = new System.Drawing.Size(108, 21);
            // 
            // lbDatabase
            // 
            this.lbDatabase.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDatabase.AppearanceItemCaption.Options.UseFont = true;
            this.lbDatabase.Control = this.cboDatabase;
            this.lbDatabase.Location = new System.Drawing.Point(0, 210);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(563, 38);
            this.lbDatabase.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lbDatabase.Text = "Database";
            this.lbDatabase.TextSize = new System.Drawing.Size(108, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnLuu;
            this.layoutControlItem5.Location = new System.Drawing.Point(364, 248);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(92, 49);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnThoat;
            this.layoutControlItem6.Location = new System.Drawing.Point(456, 248);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(107, 49);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.layoutControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 248);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(364, 49);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // lcgAccount
            // 
            this.lcgAccount.Enabled = false;
            this.lcgAccount.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbUsername,
            this.lbPass});
            this.lcgAccount.Location = new System.Drawing.Point(0, 76);
            this.lcgAccount.Name = "lcgAccount";
            this.lcgAccount.Size = new System.Drawing.Size(563, 134);
            this.lcgAccount.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lcgAccount.Text = "Account";
            // 
            // cboAuthentication
            // 
            this.cboAuthentication.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboAuthentication.FormattingEnabled = true;
            this.cboAuthentication.Location = new System.Drawing.Point(139, 92);
            this.cboAuthentication.Name = "cboAuthentication";
            this.cboAuthentication.Size = new System.Drawing.Size(440, 29);
            this.cboAuthentication.TabIndex = 11;
            this.cboAuthentication.SelectedIndexChanged += new System.EventHandler(this.cboAuthentication_SelectedIndexChanged);
            // 
            // lbAuthen
            // 
            this.lbAuthen.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbAuthen.AppearanceItemCaption.Options.UseFont = true;
            this.lbAuthen.Control = this.cboAuthentication;
            this.lbAuthen.Location = new System.Drawing.Point(0, 38);
            this.lbAuthen.Name = "lbAuthen";
            this.lbAuthen.Size = new System.Drawing.Size(563, 38);
            this.lbAuthen.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lbAuthen.Text = "Authentication";
            this.lbAuthen.TextSize = new System.Drawing.Size(108, 21);
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 367);
            this.Controls.Add(this.lcMain);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmCauHinh.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "FrmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤU HÌNH SERVER";
            this.Load += new System.EventHandler(this.FrmCauHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgNhapThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbServerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbAuthen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.ComboBox cboDatabase;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.ComboBox cboServerName;
        private DevExpress.XtraLayout.LayoutControlGroup lcgNhapThongTin;
        private DevExpress.XtraLayout.LayoutControlItem lbServerName;
        private DevExpress.XtraLayout.LayoutControlItem lbUsername;
        private DevExpress.XtraLayout.LayoutControlItem lbPass;
        private DevExpress.XtraLayout.LayoutControlItem lbDatabase;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAccount;
        private System.Windows.Forms.ComboBox cboAuthentication;
        private DevExpress.XtraLayout.LayoutControlItem lbAuthen;
    }
}