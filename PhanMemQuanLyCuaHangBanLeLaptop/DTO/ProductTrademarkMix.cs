using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductTrademarkMix
    {
        private string productID, productName, tradeMark, productImage;
        private int? quanlity, bought;
        private decimal? price;
        private string strPrice;

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string TradeMark { get => tradeMark; set => tradeMark = value; }
        public string ProductImage { get => productImage; set => productImage = value; }
        public int? Quanlity { get => quanlity; set => quanlity = value; }
        public int? Bought { get => bought; set => bought = value; }
        public decimal? Price { get => price; set => price = value; }
        public string StrPrice { get => strPrice; set => strPrice = value; }
    }
}
