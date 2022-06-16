using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLQLNNhomNguoiDung
    {
        DALQLPhanQuyenNhomNguoiDung dalQLNND;

        public BLLQLNNhomNguoiDung() { }

        public List<UserRights> lstRightsByGroup(string pMaNhom)
        {
            dalQLNND = new DALQLPhanQuyenNhomNguoiDung();
            return dalQLNND.getRightsByNhom(pMaNhom);
        }

        public bool kiemTraPhanQuyenForUser(string pMaNhomNguoiDung, string pMaMenu)
        {
            dalQLNND = new DALQLPhanQuyenNhomNguoiDung();
            var pq = dalQLNND.getPhanQuyen().FirstOrDefault(t=>t.MaNhomNguoiDung == pMaNhomNguoiDung && t.MaMenu == pMaMenu);
            return pq != null ? true : false;//True: Đã phân quyền cho nhóm này
        }
        public bool AddOrUpdateTblPhanQuyen(string pMaNhomND, string pMaMenu, bool pCoQuyen)
        {
            dalQLNND = new DALQLPhanQuyenNhomNguoiDung();
            return dalQLNND.AddOrUpdatePhanQuyen(pMaNhomND, pMaMenu, pCoQuyen);
        }
        public List<tblPhanQuyen> getRightsByNhomNoJoin(string pMaNhom)
        {
            dalQLNND = new DALQLPhanQuyenNhomNguoiDung();
            return dalQLNND.getRightsByNhomNoJoin(pMaNhom);
        }
    }
}
