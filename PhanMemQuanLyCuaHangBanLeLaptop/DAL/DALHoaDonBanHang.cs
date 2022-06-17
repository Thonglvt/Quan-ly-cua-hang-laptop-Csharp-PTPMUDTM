using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALHoaDonBanHang
    {
        QL_LaptopDataContext db;
        public List<DTOPhieuXuatKhachHang> getPhieuXuat_KH()
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.PhieuXuats
                      join b in db.Customers on a.customer_id equals b.id
                      join c in db.Employees on a.employee_id equals c.id
                      select new DTOPhieuXuatKhachHang
                      {
                          id = a.id,
                          employee_id = a.employee_id,
                          phone = b.phone,
                          TenKH = b.name,
                          date_ = a.date_,
                          total = Convert.ToInt32(a.total),
                          Address_ = a.Address_,

                          status = (a.status == 0) ? "Chưa thanh toán" : "Đã thanh toán"
                      };
            return lst.ToList();
        }
        public List<DTOPhieuXuatKhachHang> getPhieuXuat_KH_NV_SP()
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.PhieuXuats
                      join b in db.Customers on a.customer_id equals b.id
                      join c in db.Employees on a.employee_id equals c.id
                      join d in db.ChiTietPhieuXuats on a.id equals d.phieuXuat_id
                      join e in db.Products on d.product_id equals e.id
                      select new DTOPhieuXuatKhachHang
                      {
                          id = a.id,
                          employee_id = a.employee_id,
                          phone = b.phone,
                          TenKH = b.name,
                          date_ = a.date_,
                          total = Convert.ToInt32(a.total),
                          Address_ = a.Address_,
                          status = (a.status == 0) ? "Chưa thanh toán" : "Đã thanh toán",
                          employee_name = c.name,
                          MaSP = e.id,
                          TenSP = e.Name,
                          SoLuong = Convert.ToInt32(d.quanlity),
                          DonGia = Convert.ToDouble(d.price),
                          ThanhTien = Convert.ToInt32(d.quanlity)* Convert.ToDouble(d.price),
                      };
            return lst.ToList();
        }
        public List<ChiTietPhieuXuat> GetChiTietPhieuXuatsByID(string pMaDH)
        {
            db = new QL_LaptopDataContext();
            var lst = db.ChiTietPhieuXuats.Where(t => t.phieuXuat_id == pMaDH);
            return lst.ToList();
        }
        public List<DTOPhieuXuatKhachHang> GetChiTietPhieuXuats_Prod_KH_ByID(string pMaDH)
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.ChiTietPhieuXuats.Where(t => t.phieuXuat_id == pMaDH)
                      join b in db.Products on a.product_id equals b.id
                      select new DTOPhieuXuatKhachHang
                      {
                          id = a.phieuXuat_id,
                          MaSP = a.product_id,
                          TenSP = b.Name,
                          DonGia = Convert.ToDouble(a.price),
                          SoLuong = Convert.ToInt32(a.quanlity),
                          ThanhTien = Convert.ToDouble(a.price) * Convert.ToInt32(a.quanlity),
                      };
            return lst.ToList();
        }
        public string insertPhieuXuat(PhieuXuat pPhieuXuat)
        {
            db = new QL_LaptopDataContext();
            try
            {
                db.PhieuXuats.InsertOnSubmit(pPhieuXuat);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string insertChiTietPhieuXuat(ChiTietPhieuXuat pCTPhieuXuat)
        {
            db = new QL_LaptopDataContext();
            try
            {
                db.ChiTietPhieuXuats.InsertOnSubmit(pCTPhieuXuat);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
