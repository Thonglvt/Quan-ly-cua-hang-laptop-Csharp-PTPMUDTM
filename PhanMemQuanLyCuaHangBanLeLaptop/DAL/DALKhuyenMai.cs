using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALKhuyenMai
    {
        QL_LaptopDataContext db;
        public List<DTOSanPhamKhuyenMai> getSanPhamKMNotNull()
        {
            db = new QL_LaptopDataContext();
            var lstGroupJoin = from a in db.Products
                               join b in db.promotions
                               on a.id equals b.product_id
                               select new DTOSanPhamKhuyenMai
                               {
                                   MaSP = a.id,
                                   TenSP = a.Name,
                                   SoLuong = a.quanlity,
                                   GiaBan = Convert.ToInt32(a.price),
                                   GiaSauKhuyenMai = Convert.ToInt32(b.price_after),
                                   date_start = Convert.ToDateTime(b.date_start),
                                   date_end = Convert.ToDateTime(b.date_end),
                               };

            return lstGroupJoin.ToList();
        }
        public string insert(promotion pKhuyenMai)
        {
            try
            {
                db = new QL_LaptopDataContext();
                db.promotions.InsertOnSubmit(pKhuyenMai);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaSP, DateTime pNgayBD)
        {
            try
            {
                db = new QL_LaptopDataContext();
                var km = db.promotions.FirstOrDefault(t => t.product_id == pMaSP && t.date_start == pNgayBD);
                db.promotions.DeleteOnSubmit(km);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
