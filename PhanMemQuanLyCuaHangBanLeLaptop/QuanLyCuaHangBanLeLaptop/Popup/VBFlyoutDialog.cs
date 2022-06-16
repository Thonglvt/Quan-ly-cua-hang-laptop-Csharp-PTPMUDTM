using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLeLaptop.Popup
{
    public class VBFlyoutDialog: FlyoutDialog
    {
        public VBFlyoutDialog(Form form, FlyoutAction action, Control userControl) : base(form, action)
        {
            this.Properties.HeaderOffset = 0;
            this.Properties.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Properties.Style = FlyoutStyle.Popup;
            this.FlyoutControl = userControl;
        }

        public static DialogResult ShowFormPopup(Form form, FlyoutAction action, Control userControl)
        {
            var vbFlyout = new VBFlyoutDialog(form, action, userControl);
            return vbFlyout.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VBFlyoutDialog
            // 
            this.ClientSize = new System.Drawing.Size(1918, 990);
            this.Name = "VBFlyoutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.VBFlyoutDialog_Load);
            this.ResumeLayout(false);

        }

        private void VBFlyoutDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
