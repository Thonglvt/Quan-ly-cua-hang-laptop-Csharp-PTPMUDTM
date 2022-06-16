using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLHoaDonBanHang
    {
        DALHoaDonBanHang dalHDBH;
        public List<DTOPhieuXuatKhachHang> lstPhieuXuat_KH()
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.getPhieuXuat_KH();
        }
        public List<ChiTietPhieuXuat> GetChiTietPhieuXuatsByID(string pMaDH)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.GetChiTietPhieuXuatsByID(pMaDH);
        }
        //
        public string insertPhieuXuat(PhieuXuat pPhieuXuat)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.insertPhieuXuat(pPhieuXuat);
        }
        public string insertChiTietPhieuXuat(ChiTietPhieuXuat pCTPhieuXuat)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.insertChiTietPhieuXuat(pCTPhieuXuat);
        }
    }
}
