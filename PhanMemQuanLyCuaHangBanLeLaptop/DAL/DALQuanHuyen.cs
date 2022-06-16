using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALQuanHuyen
    {
        QL_LaptopDataContext db;

        public List<tblQuanHuyen> getQuanHuyen()
        {
            db = new QL_LaptopDataContext();
            return db.tblQuanHuyens.ToList();
        }
        public List<tblQuanHuyen> getQuanHuyenByTinhTP(string pMaTinhTP)
        {
            db = new QL_LaptopDataContext();
            return db.tblQuanHuyens.Where(t=>t.MaTinhThanhPho==pMaTinhTP).ToList();
        }
        public async Task<string> insertOrUpdate(tblQuanHuyen pQuanHuyen)
        {
            db = new QL_LaptopDataContext();
            try
            {
                //Kiểm tra mã QH: Nếu chưa tồn tại =>Thêm mới
                if (await checkKhoaChinh(pQuanHuyen.MaQuanHuyen) == false)
                {
                    db.tblQuanHuyens.InsertOnSubmit(pQuanHuyen);
                    db.SubmitChanges();
                    return "1";//Insert thành công
                }
                else//Tồn tại => Update
                {
                    tblQuanHuyen qh = db.tblQuanHuyens.FirstOrDefault(t => t.MaQuanHuyen == pQuanHuyen.MaQuanHuyen);
                    qh.TenQuanHuyen = pQuanHuyen.TenQuanHuyen;
                    qh.MaTinhThanhPho = pQuanHuyen.MaTinhThanhPho;
                    db.SubmitChanges();
                    return "1";//Update thành công
                }
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Return true(Đã tồn tại), false(Không tồn tại)
        /// </summary>
        /// <param name="pMaQH"></param>
        /// <returns></returns>
        public async Task<bool> checkKhoaChinh(string pMaQH)
        {
            db = new QL_LaptopDataContext();
            var kq = db.tblQuanHuyens.FirstOrDefault(t => t.MaQuanHuyen == pMaQH);
            return (kq != null) ? true : false;
        }
    }
}
