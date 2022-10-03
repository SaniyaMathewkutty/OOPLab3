using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static bool AgeRestriction (int age)
        {
            bool restrictAge = false; // initialise boolean variable to be returned

            if (age >= 18 && age <= 21)
                restrictAge = true;

            return restrictAge;
        }
    }
}
