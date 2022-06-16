using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLKhachHang
    {
        DALKhachHang dalKhachHang;
        public List<Customer> GetCustomers()
        {
            dalKhachHang = new DALKhachHang();
            return dalKhachHang.GetCustomers();
        }
        //public List<string> GetKhachHangsCustorm()
        //{
        //    return dalKhachHang.GetKhachHangsCustorm();
        //}
        public string insert(Customer pKhachHang)
        {
            dalKhachHang = new DALKhachHang();
            return dalKhachHang.insert(pKhachHang);
        }
    }
}
