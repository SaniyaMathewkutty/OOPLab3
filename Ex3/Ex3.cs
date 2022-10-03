/*
    Name: Saniya Mathewkutty  
    Date: 03/10/2022
    Description: Lab3 Ex3 - 

   3.  Write a method named Zero that accepts an int array as an argument and 
       stores the value 0 in each element.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };

            // Display array elements before calling the method
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine("Element {0} = {1}", i, array[i]);

            // Method call
            Zero(array);

            // Display elements after method called
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine("Element {0} = {1}", i, array[i]);

            Console.ReadLine();
        }

        /// <summary>
        /// Method to change all elements in array to the value of 0.
        /// </summary>
        /// <param name="array"></param>
        static void Zero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
    }
}
