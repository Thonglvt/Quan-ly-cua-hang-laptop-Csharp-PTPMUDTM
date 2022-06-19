
namespace QuanLyCuaHangBanLeLaptop
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPassOld = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.lbNewPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtComfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.lbConfirm = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.layoutControl1);
            this.lcMain.Controls.Add(this.btnDong);
            this.lcMain.Controls.Add(this.btnLuu);
            this.lcMain.Controls.Add(this.txtComfirmPass);
            this.lcMain.Controls.Add(this.txtNewPass);
            this.lcMain.Controls.Add(this.txtOldPass);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(628, 226);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbPassOld,
            this.emptySpaceItem1,
            this.lbNewPass,
            this.lbConfirm,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(628, 226);
            this.Root.TextVisible = false;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(230, 17);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtOldPass.Properties.Appearance.Options.UseFont = true;
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(381, 28);
            this.txtOldPass.StyleController = this.lcMain;
            this.txtOldPass.TabIndex = 4;
            // 
            // lbPassOld
            // 
            this.lbPassOld.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbPassOld.AppearanceItemCaption.Options.UseFont = true;
            this.lbPassOld.Control = this.txtOldPass;
            this.lbPassOld.Location = new System.Drawing.Point(0, 0);
            this.lbPassOld.Name = "lbPassOld";
            this.lbPassOld.Size = new System.Drawing.Size(608, 42);
            this.lbPassOld.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbPassOld.Text = "Mật khẩu cũ";
            this.lbPassOld.TextSize = new System.Drawing.Size(201, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 184);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(608, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(230, 59);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNewPass.Properties.Appearance.Options.UseFont = true;
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(381, 28);
            this.txtNewPass.StyleController = this.lcMain;
            this.txtNewPass.TabIndex = 5;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbNewPass.AppearanceItemCaption.Options.UseFont = true;
            this.lbNewPass.Control = this.txtNewPass;
            this.lbNewPass.Location = new System.Drawing.Point(0, 42);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(608, 42);
            this.lbNewPass.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbNewPass.Text = "Mật khẩu mới";
            this.lbNewPass.TextSize = new System.Drawing.Size(201, 21);
            // 
            // txtComfirmPass
            // 
            this.txtComfirmPass.Location = new System.Drawing.Point(230, 101);
            this.txtComfirmPass.Name = "txtComfirmPass";
            this.txtComfirmPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtComfirmPass.Properties.Appearance.Options.UseFont = true;
            this.txtComfirmPass.Properties.PasswordChar = '*';
            this.txtComfirmPass.Size = new System.Drawing.Size(381, 28);
            this.txtComfirmPass.StyleController = this.lcMain;
            this.txtComfirmPass.TabIndex = 6;
            // 
            // lbConfirm
            // 
            this.lbConfirm.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbConfirm.AppearanceItemCaption.Options.UseFont = true;
            this.lbConfirm.Control = this.txtComfirmPass;
            this.lbConfirm.Location = new System.Drawing.Point(0, 84);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(608, 42);
            this.lbConfirm.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbConfirm.Text = "Xác nhận mật khẩu mới";
            this.lbConfirm.TextSize = new System.Drawing.Size(201, 21);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.SvgImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.checkbox3;
            this.btnLuu.Location = new System.Drawing.Point(421, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 44);
            this.btnLuu.StyleController = this.lcMain;
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnLuu;
            this.layoutControlItem1.Location = new System.Drawing.Point(404, 126);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(101, 58);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ImageOptions.SvgImage = global::QuanLyCuaHangBanLeLaptop.Properties.Resources.clearheaderandfooter1;
            this.btnDong.Location = new System.Drawing.Point(522, 143);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 44);
            this.btnDong.StyleController = this.lcMain;
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDong;
            this.layoutControlItem2.Location = new System.Drawing.Point(505, 126);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(103, 58);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(12, 138);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(400, 54);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.layoutControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(404, 58);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 54);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 226);
            this.Controls.Add(this.lcMain);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmDoiMatKhau.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU [Change Passwoed]";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtComfirmPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraLayout.LayoutControlItem lbPassOld;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lbNewPass;
        private DevExpress.XtraLayout.LayoutControlItem lbConfirm;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}