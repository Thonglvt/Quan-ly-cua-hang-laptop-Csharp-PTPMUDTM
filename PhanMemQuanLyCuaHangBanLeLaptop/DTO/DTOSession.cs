using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSession
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string MaNhanVien { get; set; }
        public static string TenNhanVien{ get; set; }
        public static DateTime NgaySinh { get; set; }
        public static string GioiTinh { get; set; }
        public static string SoDienThoai { get; set; }
        public static string Email { get; set; }
        public static string CCCD { get; set; }
        public static int Luong { get; set; }
        public static string Hinh { get; set; }
        public static DateTime NgayVaoLam { get; set; }

        public DTOSession()
        {
            DTOSession.Username = "admin";
            DTOSession.Password = "123";
            DTOSession.MaNhanVien = "30102021NV000000";
            DTOSession.TenNhanVien = "Lê Văn Thông";
            DTOSession.NgaySinh = new DateTime(2001, 2, 10);
            DTOSession.GioiTinh = "Nam";
            DTOSession.SoDienThoai = "0396210106";
            DTOSession.Email = "levanthongqn35@gmail.com";
            DTOSession.CCCD = "051201012625";
            DTOSession.Luong = 12000000;
            DTOSession.Hinh = "";
            DTOSession.NgayVaoLam = new DateTime(2021, 10, 30);
        }
    }
}
