using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhanVien
    {
        QL_LaptopDataContext db;

        public List<DTONhanVienCustorm> getMaTenNhanVien()
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.Employees
                      select new DTONhanVienCustorm 
                      { id = a.id, name = a.name };
            return lst.ToList();
        }
        public List<Employee> getAll_NV()
        {
            db = new QL_LaptopDataContext();
            return db.Employees.ToList();
        }
        public Employee getNhanVienTheoUsername(string pUser)
        {
            db = new QL_LaptopDataContext();
            var empl = db.Employees.FirstOrDefault(e => e.username.Trim() == pUser);
            var emplDefault = db.Employees.FirstOrDefault(e => e.username.Trim() == "admin");
            if (empl != null)
                return empl;
            return emplDefault;
        }

    }
}
