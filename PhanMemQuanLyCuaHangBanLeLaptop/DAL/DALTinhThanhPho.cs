using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALTinhThanhPho
    {
        QL_LaptopDataContext db;

        public List<tblTinhThanhPho> GetTP()
        {
            db = new QL_LaptopDataContext();
            return db.tblTinhThanhPhos.ToList();
        }
        public async Task<List<tblTinhThanhPho>> GetTblTinhThanhPhos()
        {
            db = new QL_LaptopDataContext();
            return db.tblTinhThanhPhos.ToList();
        }
        public async Task<string> insertOrUpdate(tblTinhThanhPho pTinhTP)
        {
            db = new QL_LaptopDataContext();
            try
            {
                //Kiểm tra mã TP chưa tồn tại =>Thêm mới
                if (await checkKhoaChinh(pTinhTP.MaTinhThanhPho) == false)
                {
                    db.tblTinhThanhPhos.InsertOnSubmit(pTinhTP);
                    db.SubmitChanges();
                    return "1";//Insert thành công
                }
                else
                {
                    tblTinhThanhPho tp = db.tblTinhThanhPhos.FirstOrDefault(t => t.MaTinhThanhPho == pTinhTP.MaTinhThanhPho);
                    tp.TenTinhThanhPho = pTinhTP.TenTinhThanhPho;
                    db.SubmitChanges();
                    return "1";//Update thành công
                }    
                //Tồn tại => Update
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Return true(Đã tồn tại), false(Không tồn tại)
        /// </summary>
        /// <param name="pMaTP"></param>
        /// <returns></returns>
        public async Task<bool> checkKhoaChinh(string pMaTP)
        {
            db = new QL_LaptopDataContext();
            var kq = db.tblTinhThanhPhos.FirstOrDefault(t => t.MaTinhThanhPho == pMaTP);
            return (kq != null) ? true : false;
        }

    }
}
