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
        public List<DTOPhieuXuatKhachHang> lstPhieuXuat_KH_ByMaNV(string pMaNV)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.getPhieuXuat_KH_NV_SP().Where(t => t.employee_id == pMaNV).ToList();
        }
        public List<DTOPhieuXuatKhachHang> lstPhieuXuat_KH_BetweenDate(DateTime pStartDate,DateTime pEndDate)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.getPhieuXuat_KH_NV_SP().Where(t => t.date_ >= pStartDate && t.date_ <= pEndDate).ToList();
        }
        public List<DTOPhieuXuatKhachHang> getPhieuXuat_KH_NV_SP()
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.getPhieuXuat_KH_NV_SP();
        }
        public List<DTOPhieuXuatKhachHang> getPhieuXuat_KH_NV_SP_ByMaHD(string pMaHD)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.getPhieuXuat_KH_NV_SP().Where(t=>t.id == pMaHD).ToList();
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


        //
        public List<DTOPhieuXuatKhachHang> GetChiTietPhieuXuats_Prod_KH_ByID(string pMaDH)
        {
            dalHDBH = new DALHoaDonBanHang();
            return dalHDBH.GetChiTietPhieuXuats_Prod_KH_ByID(pMaDH);
        }
    }
}
