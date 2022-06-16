using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLPhuongXa
    {
        DALPhuongXa dalPXa;
        public List<tblPhuongXa> getPhuongXaByQuanHuyen(string pMaQH)
        {
            dalPXa = new DALPhuongXa();
            return dalPXa.getPhuongXaByQuanHuyen(pMaQH);
        }
        public async Task<string> insertOrUpdate(tblPhuongXa pPhuongXa)
        {
            dalPXa = new DALPhuongXa();
            return await dalPXa.insertOrUpdate(pPhuongXa);
        }
    }
}
