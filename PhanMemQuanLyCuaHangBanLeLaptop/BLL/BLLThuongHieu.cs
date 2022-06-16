using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLThuongHieu
    {
        DALThuongHieu dalThuongHieu;

        public List<Trademark> lstThuongHieus()
        {
            dalThuongHieu = new DALThuongHieu();
            return dalThuongHieu.getThuongHieu();
        }
    }
}
