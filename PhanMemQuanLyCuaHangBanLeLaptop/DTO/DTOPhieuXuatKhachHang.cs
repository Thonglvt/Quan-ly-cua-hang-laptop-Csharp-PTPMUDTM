using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuXuatKhachHang
    {
        public string id { get; set; }
        public string employee_id { get; set; }
        public string employee_name { get; set; }
        public string phone { get; set; }
        public string TenKH { get; set; }
        public DateTime? date_ { get; set; }
        public int total { get; set; }
        public string Address_ { get; set; }
        public string status { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }

    }
}
