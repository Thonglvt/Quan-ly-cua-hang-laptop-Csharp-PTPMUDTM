using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhomNguoiDung
    {
        QL_LaptopDataContext db;

        public DALNhomNguoiDung() { }
        public List<tblNhomNguoiDung> getNhomNguoiDung()
        {
            db = new QL_LaptopDataContext();
            return db.tblNhomNguoiDungs.Select(t => t).ToList<tblNhomNguoiDung>();
        }
        public void addNhomNguoiDung(string pMaNhom,string pTenNhom,string pGhiChu)
        {
            db = new QL_LaptopDataContext();
            tblNhomNguoiDung nhomND = new tblNhomNguoiDung();
            nhomND.MaNhom = pMaNhom;
            nhomND.TenNhom = pTenNhom;
            nhomND.GhiChu = pGhiChu;
            db.tblNhomNguoiDungs.InsertOnSubmit(nhomND);
            db.SubmitChanges();
        }
        public void updateNhomNguoiDung(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            db = new QL_LaptopDataContext();
            var nhomND = db.tblNhomNguoiDungs.FirstOrDefault(t=>t.MaNhom == pMaNhom);
            if(nhomND!=null)
            {
                nhomND.TenNhom = pTenNhom;
                nhomND.GhiChu = pGhiChu;
            }

            db.SubmitChanges();
        }
        public void deleteNhomNguoiDung(string pMaNhom)
        {
            db = new QL_LaptopDataContext();
            tblNhomNguoiDung nhomND = db.tblNhomNguoiDungs.FirstOrDefault(t => t.MaNhom == pMaNhom);

            if (nhomND != null)
            {
                db.tblNhomNguoiDungs.DeleteOnSubmit(nhomND);
            }
            db.SubmitChanges();
        }
    }
}
