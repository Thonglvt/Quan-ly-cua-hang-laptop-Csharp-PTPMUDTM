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

        public string insert(Employee pNhanVien)
        {
            db = new QL_LaptopDataContext();
            try
            {
                db.Employees.InsertOnSubmit(pNhanVien);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string update(Employee pNhanVien)
        {
            db = new QL_LaptopDataContext();
            try
            {
                var nv = db.Employees.FirstOrDefault(t => t.id == pNhanVien.id);
                nv.name = pNhanVien.name;
                nv.gender = pNhanVien.gender;
                nv.birthday = pNhanVien.birthday;
                nv.phone = pNhanVien.phone;
                nv.email = pNhanVien.email;
                nv.cmnd = pNhanVien.cmnd;

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
