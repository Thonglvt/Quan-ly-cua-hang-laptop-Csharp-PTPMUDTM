using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLKhuyenMai
    {
        DALKhuyenMai dalKM;
        public List<DTOSanPhamKhuyenMai> getSanPhamKMNotNull()
        {
            dalKM = new DALKhuyenMai();
            return dalKM.getSanPhamKMNotNull().OrderByDescending(t=>t.date_end).ToList();
        }
        public string insert(promotion pKhuyenMai)
        {
            dalKM = new DALKhuyenMai();
            return dalKM.insert(pKhuyenMai);
        }
        public string delete(string pMaSP, DateTime pNgayBD)
        {
            dalKM = new DALKhuyenMai();
            return dalKM.delete(pMaSP,pNgayBD);
        }
    }
}
