using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLLoaiSanPham
    {
        DALLoaiSanPham dalLSP;

        public List<Category> getAll()
        {
            dalLSP = new DALLoaiSanPham();
            return dalLSP.getAll();
        }
    }
}
