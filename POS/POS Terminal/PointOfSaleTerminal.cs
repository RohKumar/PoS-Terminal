using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace POS_Terminal
{
    public  class PointOfSaleTerminal
    {
        public ProductOrder Scan(string productCode, ProductOrder productOrder)
        {
             // Check to See the scanned product is Only A,B,C,D
            if (!Regex.IsMatch(productCode, @"^[A-D]+$"))
            {
                Console.WriteLine("Invalid Product Code");
                Console.ReadLine();
                System.Environment.Exit(-1);
            }

            if (productCode.Contains("A"))
            {   //Count No of Product A
                int count = productCode.Count(f => f == 'A');
                productOrder.a = productOrder.a + count;
            }
            if (productCode.Contains("B"))
            {    //Count No of Product B
                int count = productCode.Count(f => f == 'B');
                productOrder.b = productOrder.b + count;
            }
            if (productCode.Contains("C"))
            {    //Count No of Product C
                int count = productCode.Count(f => f == 'C');
                productOrder.c = productOrder.c + count;

            }
            if (productCode.Contains("D"))
            {   //Count No of Product D
                int count = productCode.Count(f => f == 'D');
                productOrder.d = productOrder.d + count;

            }
            return productOrder;
        }
        //Calculate Total of Scanned Product
        public double CalculateTotal(ProductOrder productOrder)
        {
            double TotalPrice = productOrder.TotalPriceOfA + productOrder.TotalPriceOfB
                               + productOrder.TotalPriceOfC + productOrder.TotalPriceOfD;
           return TotalPrice;
        }

        //Set Pricing for single or volume discount per product 
        public ProductOrder SetPricing(ProductOrder productOrder)
        {
            if (productOrder.a >= 3)
            {
                //getting quotient by '/'  & Reminder by '%'    
                productOrder.TotalPriceOfA = productOrder.a / 3 * 3 + productOrder.a % 3 * 1.25;
            }
            else
            {
                productOrder.TotalPriceOfA = productOrder.a * 1.25;
            }
            productOrder.TotalPriceOfB = productOrder.b * 4.25;
            if (productOrder.c >= 6)
            {
                //getting quotient by '/'  & Reminder by '%'    
                productOrder.TotalPriceOfC = productOrder.c / 6*5 + productOrder.c % 6 * 1;
            }
            else
            {
                productOrder.TotalPriceOfC = productOrder.c * 1;
            }
                productOrder.TotalPriceOfD = productOrder.d * 0.75;
            return productOrder;
        }
    }
}