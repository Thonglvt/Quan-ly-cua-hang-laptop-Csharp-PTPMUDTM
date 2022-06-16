using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALQLPhanQuyenNhomNguoiDung
    {
        QL_LaptopDataContext db;

        public DALQLPhanQuyenNhomNguoiDung() { }
        public List<tblPhanQuyen> getPhanQuyen()
        {
            db = new QL_LaptopDataContext();
            return db.tblPhanQuyens.Select(t => t).ToList<tblPhanQuyen>();
        }

        public List<UserRights> getRightsByNhom(string pMaNhom)
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.tblMenus
                      join b in db.tblPhanQuyens.Where(x => x.MaNhomNguoiDung.Trim() == pMaNhom.Trim())
                      on a.MaMenu equals b.MaMenu
                      into ab
                      from aa in ab.DefaultIfEmpty()
                      select new UserRights
                      {
                          MaMenu = a.MaMenu,
                          TenMenu = a.TenMenu,
                          CoQuyen = (aa.CoQuyen == null) ? false : aa.CoQuyen,
                          ParentMenu = a.ParentMenu
                      };
            return lst.ToList<UserRights>();
        }
        public List<tblPhanQuyen> getRightsByNhomNoJoin(string pUsername)
        {
            db = new QL_LaptopDataContext();
            var maNhom = (from a in db.tblNguoiDungNhomNguoiDungs
                          where a.username == pUsername
                          select a.MaNhomNguoiDung).SingleOrDefault();
            string pMaNhom = "GROUPNHANVIEN";
            if (maNhom != null)
            {
                pMaNhom = maNhom.ToString();
            }
            var lst = from b in db.tblPhanQuyens
                      where b.MaNhomNguoiDung == pMaNhom
                      select b;
            return lst.ToList<tblPhanQuyen>();
        }
        public bool AddOrUpdatePhanQuyen(string pMaNhomND, string pMaMenu, bool pCoQuyen)
        {
            db = new QL_LaptopDataContext();
            bool kq = true;
            try
            {
                var pq = db.tblPhanQuyens.FirstOrDefault(t => t.MaNhomNguoiDung.Trim() == pMaNhomND && t.MaMenu.Trim() == pMaMenu);
                if (pq != null)
                    pq.CoQuyen = pCoQuyen;
                else
                {
                    tblPhanQuyen tblPQ = new tblPhanQuyen();
                    tblPQ.MaNhomNguoiDung = pMaNhomND;
                    tblPQ.MaMenu = pMaMenu;
                    tblPQ.CoQuyen = pCoQuyen;
                    db.tblPhanQuyens.InsertOnSubmit(tblPQ);
                }
                db.SubmitChanges();
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }

        //Thêm xóa sửa
    }
}
