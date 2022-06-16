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
namespace QuanLyCuaHangBanLeLaptop
{
    public partial class FrmImportExcelTinhThanh : DevExpress.XtraEditors.XtraForm
    {
        BLLXuLyTrenFile bllXuLyFile = new BLLXuLyTrenFile();
        DataTable dataTable = new DataTable();
        //BLL
        BLLTinhThanhPho bllTinhTP = new BLLTinhThanhPho();
        BLLQuanHuyen bllQuanHuyen = new BLLQuanHuyen();
        BLLPhuongXa bllPhuongXa = new BLLPhuongXa();
        //Database
        QL_LaptopDataContext db;

        public FrmImportExcelTinhThanh()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        async void loadData()
        {
            gridControlTinhThanh.DataSource = await bllTinhTP.GetTblTinhThanhPhos();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private async void btnChonFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx|*.xlsx|Excel 2003 (*.xls)|*.xls))";

            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    dataTable = bllXuLyFile.importExcel(openFileDialog.FileName);
                    gridControlTinhThanh.DataSource = dataTable;
                    //Insert xuống database
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        //Insert tỉnh thành phố
                        tblTinhThanhPho ttp = new tblTinhThanhPho();
                        ttp.MaTinhThanhPho = dr[1].ToString();
                        ttp.TenTinhThanhPho = dr[0].ToString();
                        ttp.GhiChu = "";
                        string kqInsertTP = await bllTinhTP.insertOrUpdate(ttp);
                        if (!kqInsertTP.Equals("1"))
                        {
                            XtraMessageBox.Show("Lỗi thêm Tỉnh/Thành phố: " + kqInsertTP, "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //Insert Quận/Huyện
                        tblQuanHuyen qh = new tblQuanHuyen();
                        qh.MaQuanHuyen = dr[3].ToString();
                        qh.TenQuanHuyen = dr[2].ToString();
                        qh.MaTinhThanhPho = dr[1].ToString();
                        string kqInsertQH = await bllQuanHuyen.insertOrUpdate(qh);
                        if (!kqInsertQH.Equals("1"))
                        {
                            XtraMessageBox.Show("Lỗi thêm Quận/Huyện: " + kqInsertQH, "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        //Add Phường xã
                        tblPhuongXa px = new tblPhuongXa();
                        px.MaPhuongXa = dr[5].ToString();
                        px.TenPhuongXa = dr[4].ToString();
                        px.MaQuanHuyen = dr[3].ToString();
                        string kqInsertPX = await bllPhuongXa.insertOrUpdate(px);
                        if (!kqInsertPX.Equals("1"))
                        {
                            XtraMessageBox.Show("Lỗi thêm Phường/Xã: " + kqInsertPX, "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    XtraMessageBox.Show("Load dữ liệu thành công!", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Nhập file không thành công: "+ex.Message, "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            XtraMessageBox.Show("Đã hủy thao tác", "Thông báo [Message]"
                       , MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlTinhThanh.RefreshDataSource();
        }
    }
}