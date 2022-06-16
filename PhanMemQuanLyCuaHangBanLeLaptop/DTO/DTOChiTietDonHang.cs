using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietDonHang
    {
        private List<ChiTietPhieuXuat> lstChiTietDonHang;

        public List<ChiTietPhieuXuat> LstChiTietDonHang { get => lstChiTietDonHang; set => lstChiTietDonHang = value; }
        public DTOChiTietDonHang() { }
    }
}
