using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLChiTIetSanPham
    {
        DALChiTietSanPham dalCTSP;
        public string insert(Detail pDetail)
        {
            dalCTSP = new DALChiTietSanPham();
            return dalCTSP.insert(pDetail);
        }
    }
}
