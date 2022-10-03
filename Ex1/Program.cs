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
            // Declare variables
            int age = 0;

            // Get input from user
            Console.WriteLine("Enter your age:  ");
            age = int.Parse(Console.ReadLine());

            if (AgeRestriction(age))
                Console.WriteLine("You have access to the site.");
            else
                Console.WriteLine("You do not have access to the site.");

            Console.ReadLine();
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
