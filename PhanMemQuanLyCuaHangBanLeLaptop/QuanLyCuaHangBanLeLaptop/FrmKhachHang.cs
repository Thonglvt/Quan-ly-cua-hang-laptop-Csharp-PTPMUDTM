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
using BLL;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BLLKhachHang bllKhachHang = new BLLKhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            gridControlKhachHang.DataSource = bllKhachHang.GetCustomers();
        }
    }
}