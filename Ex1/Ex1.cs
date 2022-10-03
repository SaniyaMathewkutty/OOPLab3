/*
    Name: Saniya Mathewkutty  
    Date: 03/10/2022
    Description: Lab3 Ex1 - 

    1. A website only allows users in the age bracket 18 to 21 inclusive to access
    its content. Write a method that accepts the age as an int argument and decides
    whether it is possible to access the site. Your method shall return a boolean
    value
*/
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
