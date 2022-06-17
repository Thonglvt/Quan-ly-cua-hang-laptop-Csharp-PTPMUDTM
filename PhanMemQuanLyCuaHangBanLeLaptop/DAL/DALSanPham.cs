using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALSanPham
    {
        public DALSanPham() { }
        QL_LaptopDataContext db;


        //Get data
        public List<ProductTrademarkMix> getProductsTradeMark()
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.Products
                      join b in db.Trademarks
                      on a.trademark_id equals b.id
                      select new ProductTrademarkMix
                      {
                          ProductID = a.id,
                          ProductName = a.Name,
                          Quanlity = a.quanlity,
                          Bought = a.purchase,
                          Price = a.price,
                          TradeMark = b.name,
                          ProductImage = a.avatar,
                          StrPrice = string.Format("{0:0,0}",(int)a.price)
                      };
            return lst.ToList<ProductTrademarkMix>();
        }
        public List<Product> getProducts()
        {
            db = new QL_LaptopDataContext();
            return db.Products.ToList();
        }
        public List<DTOSanPhamKhuyenMai> getSanPhamKhuyenMai()
        {
            db = new QL_LaptopDataContext();
            var lstGroupJoin = from a in db.Products
                               join b in db.promotions.Where(p=>p.date_end>=DateTime.Now)
                               on a.id equals b.product_id into prodGroup
                               from c in prodGroup.DefaultIfEmpty()
                               select new DTOSanPhamKhuyenMai
                               {
                                   MaSP = a.id,
                                   TenSP = a.Name,
                                   SoLuong = a.quanlity,
                                   GiaBan = Convert.ToInt32(a.price),
                                   GiaSauKhuyenMai = (c.price_after==null)? Convert.ToInt32(a.price): Convert.ToInt32(c.price_after),
                               };

            return lstGroupJoin.ToList();
        }
        public int getSoLuongSPByMaSP(string pMaSP)
        {
            db = new QL_LaptopDataContext();
            var prod = db.Products.FirstOrDefault(p => p.id == pMaSP);

            return (prod != null) ? Convert.ToInt32(prod.quanlity) : -1;
        }


        //Thao tác insert,update,delete
        public string insertProduct(Product pProduct)
        {
            db = new QL_LaptopDataContext();
            try
            {
                db.Products.InsertOnSubmit(pProduct);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool updateProduct(Product pProduct)
        {
            db = new QL_LaptopDataContext();
            try
            {
                var p = db.Products.FirstOrDefault(t => t.id == pProduct.id);
                if(p != null)
                {
                    p.Name = pProduct.Name;
                    p.quanlity = pProduct.quanlity;
                    p.price = pProduct.price;
                    p.trademark_id = pProduct.trademark_id;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool updateNameTrademartProduct(string pMaSP,string pTenSP,int pThuongHieu)
        {
            db = new QL_LaptopDataContext();
            try
            {
                var p = db.Products.FirstOrDefault(t => t.id == pMaSP);
                if (p != null)
                {
                    p.Name = pTenSP;
                    p.trademark_id = pThuongHieu;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string createIDProducts()
        {
            string prodIDLast;
            try
            {
                //Lấy mã cuối cùng
                prodIDLast = db.Products.OrderByDescending(p => p.id).Select(p => p.id).First().ToString();
            }
            catch (Exception)
            {
                return "LAP000000";
            }
            //Ép thành Int
            int IDInt = int.Parse(prodIDLast.Substring(3, 6));
            //Thực hiện tăng dần
            string ID = "LAP";
            if (IDInt >= 0 && IDInt < 9)
                ID += "00000" + (IDInt + 1);
            else if (IDInt >= 9 && IDInt < 99)
                ID += "0000" + (IDInt + 1);
            else if (IDInt >= 99 && IDInt < 999)
                ID += "000" + (IDInt + 1);
            else if (IDInt >= 999 && IDInt < 9999)
                ID += "00" + (IDInt + 1);
            else if (IDInt >= 9999 && IDInt < 99999)
                ID += "0" + (IDInt + 1);

            return ID;
        }
    }
}
