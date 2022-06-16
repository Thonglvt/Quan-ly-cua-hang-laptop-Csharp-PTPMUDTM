using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLQuanHuyen
    {
        DALQuanHuyen dalQH;
        public List<tblQuanHuyen> getQuanHuyenByTinhTP(string pMaTinhTP)
        {
            dalQH = new DALQuanHuyen();
            return dalQH.getQuanHuyenByTinhTP(pMaTinhTP);
        }
        public async Task<string> insertOrUpdate(tblQuanHuyen pQuanHuyen)
        {
            dalQH = new DALQuanHuyen();
            return await dalQH.insertOrUpdate(pQuanHuyen);
        }
    }
}
