using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLTinhThanhPho
    {
        DALTinhThanhPho dalTinhTP;

        public List<tblTinhThanhPho> GetTP()
        {
            dalTinhTP = new DALTinhThanhPho();
            return dalTinhTP.GetTP();
        }
        public async Task<string> insertOrUpdate(tblTinhThanhPho pTinhTP)
        {
            dalTinhTP = new DALTinhThanhPho();
            return await dalTinhTP.insertOrUpdate(pTinhTP);
        }
        public async Task<List<tblTinhThanhPho>> GetTblTinhThanhPhos()
        {
            dalTinhTP = new DALTinhThanhPho();
            return await dalTinhTP.GetTblTinhThanhPhos();
        }

    }
}
