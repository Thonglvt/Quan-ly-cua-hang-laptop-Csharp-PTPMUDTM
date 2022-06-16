using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALNguoiDung
    {
        QL_LaptopDataContext db;

        public DALNguoiDung() { }

        
        public List<Account> getAccount()
        {
            db = new QL_LaptopDataContext();
            return db.Accounts.Select(l => l).ToList<Account>();
        }
        public List<Employee> getAccountEmployeeMix()
        {
            db = new QL_LaptopDataContext();
            var accEmpMix = from a in db.Accounts
                            join b in db.Employees
                            on a.username equals b.username
                            select b;
            return accEmpMix.ToList<Employee>();
        }
        public List<Employee> getNguoiDungByNhom(string maNhomND)
        {
            db = new QL_LaptopDataContext();
            var lst = from a in db.tblNguoiDungNhomNguoiDungs.Where(t => t.MaNhomNguoiDung == maNhomND)
                      join b in db.Employees
                      on a.username equals b.username
                      select b;

            return lst.ToList<Employee>();
        }
        public List<tblNguoiDungNhomNguoiDung> getTblNguoiDungNhomNguoiDung()
        {
            db = new QL_LaptopDataContext();
            return db.tblNguoiDungNhomNguoiDungs.Select(t => t).ToList();
        }
        public void addUserToGroup(string pUsernane, string pMaNhom)
        {
            db = new QL_LaptopDataContext();
            tblNguoiDungNhomNguoiDung ndnnd = new tblNguoiDungNhomNguoiDung();
            ndnnd.username = pUsernane;
            ndnnd.MaNhomNguoiDung = pMaNhom;
            ndnnd.GhiChu = "";
            db.tblNguoiDungNhomNguoiDungs.InsertOnSubmit(ndnnd);
            db.SubmitChanges();
        }
        public void removeUserFromGroup(string pUsernane, string pMaNhom)
        {
            db = new QL_LaptopDataContext();
            tblNguoiDungNhomNguoiDung ndnnd = db.tblNguoiDungNhomNguoiDungs.FirstOrDefault(t => t.username == pUsernane && t.MaNhomNguoiDung == pMaNhom);
            if (ndnnd != null)
                db.tblNguoiDungNhomNguoiDungs.DeleteOnSubmit(ndnnd);
            db.SubmitChanges();
        }


        //
        public string insert(Account pTaiKhoan)
        {
            try
            {
                db = new QL_LaptopDataContext();
                db.Accounts.InsertOnSubmit(pTaiKhoan);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
