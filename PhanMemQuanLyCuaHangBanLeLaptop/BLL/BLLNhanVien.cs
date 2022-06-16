
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
    }
}
