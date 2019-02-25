using System;

namespace POS_Terminal
{
    public class ProductOrder
    {
        //Intial product A,B,C,D is set to 0
        public int a = 0;
        public int b = 0;
        public int c = 0;
        public int d = 0;

        //Total Price after applying rule for each product.
        public double TotalPriceOfA { get; set; }
        public double TotalPriceOfB { get; set; }
        public double TotalPriceOfC { get; set; }
        public double TotalPriceOfD { get; set; }
        public ProductOrder()
        {
        }
      
    }
}