using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLNguoiDung
    {
        DALNguoiDung dalNguoiDung;

        public BLLNguoiDung() { }

        public bool kiemTraDangNhap(string user,string pass)
        {
            dalNguoiDung = new DALNguoiDung();
            List<Account> lstAcc = dalNguoiDung.getAccount();
            foreach (Account acc in lstAcc)
            {
                if (user.Equals(acc.username.Trim()) && pass.Equals(acc.password.Trim()))
                    return true;
            }
            return false;
        }
        public List<Account> lstUsers()
        {
            dalNguoiDung = new DALNguoiDung();
            return dalNguoiDung.getAccount();
        }
        public List<Employee> lstAccountEmployeeMix()
        {
            dalNguoiDung = new DALNguoiDung();
            return dalNguoiDung.getAccountEmployeeMix();
        }
        public List<Employee> lstEmpByGroup(string pMaNhom)
        {
            dalNguoiDung = new DALNguoiDung();
            return dalNguoiDung.getNguoiDungByNhom(pMaNhom);
        }
        public bool kiemTraNguoiDungTonTaiInNhomND(string pUsername,string pMaNhom)
        {
            dalNguoiDung = new DALNguoiDung();
            List<tblNguoiDungNhomNguoiDung> lstNDNND = dalNguoiDung.getTblNguoiDungNhomNguoiDung();
            tblNguoiDungNhomNguoiDung ndnnd = lstNDNND.FirstOrDefault(t => t.username == pUsername && t.MaNhomNguoiDung == pMaNhom);
            return (ndnnd != null) ? true : false; //True: đã tồn tại
        }
        public bool insertUserToGroup(string pUsername, string pMaNhom)
        {
            dalNguoiDung = new DALNguoiDung();
            bool kq = true;
            try
            {
                dalNguoiDung.addUserToGroup(pUsername, pMaNhom);
            }
            catch (Exception e)
            {
                
                kq = false;
            }
            return kq;
        }
        public bool removeUserFromGroup(string pUsername, string pMaNhom)
        {
            dalNguoiDung = new DALNguoiDung();
            bool kq = true;
            try
            {
                dalNguoiDung.removeUserFromGroup(pUsername, pMaNhom);
            }
            catch (Exception e)
            {

                kq = false;
            }
            return kq;
        }

        public string insert(Account pTaiKhoan)
        {
            dalNguoiDung = new DALNguoiDung();
            return dalNguoiDung.insert(pTaiKhoan);
        }
        public string updatePass(Account pTaiKhoan)
        {
            dalNguoiDung = new DALNguoiDung();
            return dalNguoiDung.updatePass(pTaiKhoan);
        }
    }
}
