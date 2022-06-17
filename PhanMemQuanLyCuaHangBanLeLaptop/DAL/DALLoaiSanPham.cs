using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALLoaiSanPham
    {
        QL_LaptopDataContext db;
        public List<Category> getAll()
        {
            db = new QL_LaptopDataContext();
            return db.Categories.ToList();
        }
    }
}
