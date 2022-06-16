using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALAutoCodeGeneration
    {
        QL_LaptopDataContext db;

        //Taọ mã sản phẩm
        public string createIDProducts()
        {
            db = new QL_LaptopDataContext();
            string prodIDLast;
            try
            {
                //Lấy mã cuối cùng
                prodIDLast = db.Products.OrderByDescending(p => p.id).Select(p => p.id).First().ToString();
            }
            catch (Exception)
            {
                return "LAP000000";
            }
            //Convert to Int
            int IDInt = int.Parse(prodIDLast.Substring(3, 6));
            //Thực hiện tăng dần
            string ID = "LAP";
            if (IDInt >= 0 && IDInt < 9)
                ID += "00000" + (IDInt + 1);
            else if (IDInt >= 9 && IDInt < 99)
                ID += "0000" + (IDInt + 1);
            else if (IDInt >= 99 && IDInt < 999)
                ID += "000" + (IDInt + 1);
            else if (IDInt >= 999 && IDInt < 9999)
                ID += "00" + (IDInt + 1);
            else if (IDInt >= 9999 && IDInt < 99999)
                ID += "0" + (IDInt + 1);

            return ID;
        }
        //Tạo mã Phiếu xuất
        public string createIDPhieuXuat()
        {
            db = new QL_LaptopDataContext();
            string PXIDLast;
            string dateNow = DateTime.Now.ToShortDateString(); //lấy theo định dạng DD/MM/YYYY
            dateNow = dateNow.Replace("/", "");
            string ID = "";
            try
            {
                //Lấy mã cuối cùng
                PXIDLast = db.PhieuXuats.OrderByDescending(p => p.id.Substring(11, 6)).Select(p => p.id).First().ToString();
                //Ép thành Int
                int IDInt = int.Parse(PXIDLast);
                //Thực hiện tăng dần
                ID = dateNow + "HD";
                if (IDInt >= 0 && IDInt < 9)
                    ID += "00000" + (IDInt + 1);
                else if (IDInt >= 9 && IDInt < 99)
                    ID += "0000" + (IDInt + 1);
                else if (IDInt >= 99 && IDInt < 999)
                    ID += "000" + (IDInt + 1);
                else if (IDInt >= 999 && IDInt < 9999)
                    ID += "00" + (IDInt + 1);
                else if (IDInt >= 9999 && IDInt < 99999)
                    ID += "0" + (IDInt + 1);

            }
            catch (Exception)
            {
                return dateNow + "HD000000";
            }

            return ID;
        }
        //Tạo mã Khách hàng
        public string createIDKH()
        {
            db = new QL_LaptopDataContext();
            string IDLast;
            string ID = "";
            try
            {
                //Lấy mã cuối cùng
                IDLast = db.Customers.OrderByDescending(p => p.id.Substring(2, 10)).Select(p => p.id).First().ToString();
                //Ép thành Int
                int IDInt = int.Parse(IDLast.Substring(2, 10));
                //Thực hiện tăng dần
                ID = "KH";
                if (IDInt >= 0 && IDInt < 9)
                    ID += "000000000" + (IDInt + 1);
                else if (IDInt >= 9 && IDInt < 99)
                    ID += "00000000" + (IDInt + 1);
                else if (IDInt >= 99 && IDInt < 999)
                    ID += "0000000" + (IDInt + 1);
                else if (IDInt >= 999 && IDInt < 9999)
                    ID += "000000" + (IDInt + 1);
                else if (IDInt >= 9999 && IDInt < 99999)
                    ID += "00000" + (IDInt + 1);
                else if (IDInt >= 99999 && IDInt < 999999)
                    ID += "0000" + (IDInt + 1);
                else if (IDInt >= 99999 && IDInt < 999999)
                    ID += "000" + (IDInt + 1);
                else if (IDInt >= 99999 && IDInt < 999999)
                    ID += "00" + (IDInt + 1);
                else if (IDInt >= 99999 && IDInt < 999999)
                    ID += "0" + (IDInt + 1);

            }
            catch (Exception)
            {
                return "KH0000000000";
            }
            return ID;
        }
    }
}
