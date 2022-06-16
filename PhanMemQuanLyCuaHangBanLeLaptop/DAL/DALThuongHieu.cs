using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALThuongHieu
    {
        QL_LaptopDataContext db;

        public List<Trademark> getThuongHieu()
        {
            db = new QL_LaptopDataContext();
            return db.Trademarks.ToList();
        }
    }
}
