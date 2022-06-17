using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALChiTietSanPham
    {
        QL_LaptopDataContext db;
        public string insert(Detail pDetail)
        {
            db = new QL_LaptopDataContext();
            try
            {
                db.Details.InsertOnSubmit(pDetail);
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
