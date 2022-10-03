/*
    Name: Saniya Mathewkutty  
    Date: 03/10/2022
    Description: Lab3 Ex5 - 

    5.	Write a method that accepts a stock-on-hand figure and a sales figure as
int arguments.  It will update the stock-on-hand figure by deducting the sales 
figure if there is sufficient stock to fulfil the sale. The method shall return true
if the stock-on-hand figure has been updated, otherwise false.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables 
            int stock = 10, sales = 5;

            if (UpdateStock(ref stock, sales))
                Console.WriteLine("Sale successful. Sold {0}, stock remaining {1}", sales, stock);
            else
                Console.WriteLine("Inadequate amount of stock!");
        }
        
        static bool UpdateStock(ref int stock, int sales) // passing variable stock by reference
        {
            // Return the bool true if stock at hand figure has been updated 
            bool stockUpdated = false;

            // check if there is enough stock to update with sale amount
            if (stock >= sales)
            {
                stock -= sales; // decrease stock with the sales amount
                stockUpdated = true;
            }

            // don't need else statment to return stockUpdated as false because it's initialised to be false

            return stockUpdated;

        }
    }
}
