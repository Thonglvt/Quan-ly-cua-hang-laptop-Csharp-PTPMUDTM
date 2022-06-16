using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLHamXuLyChung
    {
        public BLLHamXuLyChung() { }
        public string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }


        //KIỂM TRA PHONE
        public static bool CheckPhone(string phone)
        {
            //Chuỗi định dạng email
            String reg = "^(0|\\+84)(\\s|\\.)?((3[2-9])|(5[689])"
                        + "|(7[06-9])|(8[1-689])|(9[0-46-9]))"
                        + "(\\d)(\\s|\\.)?(\\d{3})(\\s|\\.)?(\\d{3})$";
            Regex re = new Regex(reg);
            return re.IsMatch(phone);
        }
        //KIỂM TRA EMAIL
        public static bool CheckEmail(string Email)
        {
            //Chuỗi định dạng email
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            //String strRegex = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@((\\[[0-9]{1,3}"
            //            +"\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|"
            //            +"(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$";
            Regex re = new Regex(strRegex);
            return re.IsMatch(Email);
        }
    }
}
