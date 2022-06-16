using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALPhuongXa
    {
        QL_LaptopDataContext db;

        public List<tblPhuongXa> getPhuongXaByQuanHuyen(string pMaQH)
        {
            db = new QL_LaptopDataContext();
            return db.tblPhuongXas.Where(t => t.MaQuanHuyen == pMaQH).ToList();
        }
        public async Task<string> insertOrUpdate(tblPhuongXa pPhuongXa)
        {
            db = new QL_LaptopDataContext();
            try
            {
                //Kiểm tra mã QH: Nếu chưa tồn tại =>Thêm mới
                if (await checkKhoaChinh(pPhuongXa.MaPhuongXa) == false)
                {
                    db.tblPhuongXas.InsertOnSubmit(pPhuongXa);
                    db.SubmitChanges();
                    return "1";//Insert thành công
                }
                else                //Tồn tại => Update
                {
                    tblPhuongXa px = db.tblPhuongXas.FirstOrDefault(t => t.MaPhuongXa == pPhuongXa.MaPhuongXa);
                    px.TenPhuongXa = pPhuongXa.TenPhuongXa;
                    px.MaQuanHuyen = pPhuongXa.MaQuanHuyen;
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
        public async Task<bool> checkKhoaChinh(string pMaPX)
        {
            db = new QL_LaptopDataContext();
            var kq = db.tblPhuongXas.FirstOrDefault(t => t.MaPhuongXa == pMaPX);
            return (kq != null) ? true : false;
        }
    }
}
