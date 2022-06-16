using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalSanPham;

        public List<Product> lstProducts()
        {
            dalSanPham = new DALSanPham();
            return dalSanPham.getProducts();
        }
        public List<DTOSanPhamKhuyenMai> lstSanPhamKhuyenMai()
        {
            dalSanPham = new DALSanPham();
            return dalSanPham.getSanPhamKhuyenMai();
        }
        public int getSoLuongSPByMaSP(string pMaSP)
        {
            dalSanPham = new DALSanPham();
            return dalSanPham.getSoLuongSPByMaSP(pMaSP);
        }

        public bool insertProduct(string pMaSP, string pTenSP, int pSoLuong, decimal pGia, int pThuongHieu)
        {
            dalSanPham = new DALSanPham();
            Product p = new Product();
            p.id = pMaSP;
            p.Name = pTenSP;
            p.quanlity = pSoLuong;
            p.trademark_id = pThuongHieu;
            p.price = pGia;
            p.purchase = 0;
            p.avatar = "";
            p.view_ = 0;
            
            return dalSanPham.insertProduct(p);
        }
        public bool updateNameTrademarkProduct(string pMaSP, string pTenSP, int pThuongHieu)
        {
            dalSanPham = new DALSanPham();
            bool kq = true;
            if(pMaSP != string.Empty && pTenSP != string.Empty && pThuongHieu>=0)
            {
                kq = dalSanPham.updateNameTrademartProduct(pMaSP, pTenSP, pThuongHieu);
            }
            return kq;
        }
    }
}
