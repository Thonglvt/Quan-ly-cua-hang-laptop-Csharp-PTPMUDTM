
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dalNhanVien;

        public List<DTONhanVienCustorm> lstMaTenNhanVien()
        {
            dalNhanVien = new DALNhanVien();
            return dalNhanVien.getMaTenNhanVien();
        }
        public Employee getNhanVienTheoUsername(string pUser)
        {
            dalNhanVien = new DALNhanVien();
            return dalNhanVien.getNhanVienTheoUsername(pUser);
        }
        public List<Employee> getAll_NV()
        {
            dalNhanVien = new DALNhanVien();
            return dalNhanVien.getAll_NV();
        }
        public string insert(Employee pNhanVien)
        {
            dalNhanVien = new DALNhanVien();
            return dalNhanVien.insert(pNhanVien);
        }
        public string update(Employee pNhanVien)
        {
            dalNhanVien = new DALNhanVien();
            return dalNhanVien.update(pNhanVien);
        }
    }
}
