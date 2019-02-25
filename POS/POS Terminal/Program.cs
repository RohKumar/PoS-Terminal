using System;

namespace POS_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Product A,B,C,D to scan,After scanning all the product presse enter to see the TotalPrice");
            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            
            ProductOrder productOrder = new ProductOrder();
            productOrder=terminal.Scan(Console.ReadLine(), productOrder); 
            productOrder = terminal.SetPricing(productOrder);


            double result = terminal.CalculateTotal(productOrder);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Total Price is $" + result);
            Console.ReadLine();
        }
    }
}
