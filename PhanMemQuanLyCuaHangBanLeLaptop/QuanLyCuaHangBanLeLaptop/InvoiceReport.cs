using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DTO;

namespace QuanLyCuaHangBanLeLaptop
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void InitData(List<DTOPhieuXuatKhachHang> pLstPXKH)
        {
            foreach (DTOPhieuXuatKhachHang p in pLstPXKH)
            {
                pMaHD.Value = p.id;
                pTenKH.Value = p.TenKH;
                pSDT.Value = p.phone;
                pNVBanHang.Value = p.employee_id + " - " + p.employee_name;
                pNgayHD.Value = p.date_;
                objectDataSource1.DataSource = pLstPXKH;
                break;
            }

        }

    }
}
