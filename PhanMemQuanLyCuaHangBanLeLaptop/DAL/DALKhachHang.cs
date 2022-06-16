using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALKhachHang
    {
        QL_LaptopDataContext db;
        public List<Customer> GetCustomers()
        {
            db = new QL_LaptopDataContext();
            return db.Customers.ToList();
        }
        //public List<string> GetKhachHangsCustorm()
        //{
        //    var lst = from a in db.Customers
        //              select new { a.id, a.name,a.phone,a.email,a.cmnd };
        //    return db.Customers.Select(t=>t.id).ToList();
        //}

        public string insert(Customer pKhachHang)
        {
            try
            {
                db = new QL_LaptopDataContext();
                db.Customers.InsertOnSubmit(pKhachHang);
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
