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

            Console.WriteLine("Stock at hand = {0}", stock);
        }
        
        static bool UpdateStock(ref int stock, int sales) // passing variable stock by reference
        {

        }
    }
}
