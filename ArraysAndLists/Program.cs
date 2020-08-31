using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-1

            int[] intArray = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            

            //Create two Lists of type int.
            // * Name one List "evens"

            var evens = new List<int>();

            //  Name the other List "odds"

            var odds = new List<int>();


            // Using either a foreach or for loop,
            // * nest an if statement to check to see
            // *  if a number is even or odd.
            // * Then add those numbers to either the evens List
            // * or the odds List
            // */

            foreach (var num in intArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }

                else
                {
                    odds.Add(num);
                }

            }
        


            //for (int i = 1; i % 0; i++)
            //{
            //    evens.Add(i);
            //}

            //foreach (var i in evens)
            //{
            //    Console.WriteLine(evens);
            //}


            //Now using foeach or for loops,
            // * display each List of even and odd numbers
            // *
            // * Try to be creative in your display
            // */

            foreach (var i in evens)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Our odd numbers:");
            foreach (var odd in odds)
            {
                Console.WriteLine(odd);
            }
           

           
        }
    }
}
