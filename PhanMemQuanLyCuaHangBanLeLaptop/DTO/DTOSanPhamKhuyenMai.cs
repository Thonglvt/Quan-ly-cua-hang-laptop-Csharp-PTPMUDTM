using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSanPhamKhuyenMai
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaBan { get; set; }
        public int? GiaSauKhuyenMai { get; set; }
        public int? ThanhTien { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }

    }
}
