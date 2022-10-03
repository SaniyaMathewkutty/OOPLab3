using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Method to return the sum of all even numbers between n1 and n2.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        static int Sum(int n1, int n2)
        {
            int total = 0, lowest = 0;

            // Determine that n1 (number 1) is the lowest number
            if (n2 < n1)
            {
                lowest = n2;
                n2 = n1;
                n1 = lowest;
            }

            for (int i = n1; i <= n2; i++)
            {
                if ( i % 2 == 0) // finding out which ones are even
            }



            
        }
    }
}
