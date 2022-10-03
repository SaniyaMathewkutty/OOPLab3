/*
    Name: Saniya Mathewkutty  
    Date: 03/10/2022
    Description: Lab3 Ex2 - 

   2.	Write a method that uses a switch statement to return the cost of a product,
        where the method receives a product description as a string argument. (Costs given)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductCost("Jeans"));
            Console.WriteLine(ProductCost("Jacket"));
            Console.WriteLine(ProductCost("Boots"));
            Console.WriteLine(ProductCost("Scarves"));
            Console.WriteLine(ProductCost("Belts"));
            Console.WriteLine(ProductCost("Socks"));
            Console.WriteLine(ProductCost("Shoes"));

        }

        static decimal ProductCost (string productDescription)
        {
            decimal price;

            switch (productDescription)
            {
                case "Jeans":
                    price = 67.99m; // "m" to convert decimal (float type) to literal
                    break;
                case "Jacket":
                    price = 68.99m; 
                    break;
                case "Boots":
                    price = 34.99m;
                    break;
                case "Scarves":
                case "Belts":
                case "Socks":
                    price = 10m;
                    break;

                default:
                    price = -999m;   // None of the above, signalling error.
                    break;

            }
            return price;
        }
    }
}
