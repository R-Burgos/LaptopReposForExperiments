using Microsoft.VisualBasic;
using System;

namespace Testing_CodeWars
{
    internal class Program
    {
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static decimal Add(params decimal[] numbers)
        {
            var sum = 0m;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Add(1 , 2, 3, 4, 5);




            int[] arr1 = { 4, 3, 2, 5 }; // becomes 4 3 2 6
            int[] arr2 = { 1, 2, 3, 9 }; // becomes 1 2 4 0
            int[] arr3 = { 9, 9, 9, 9 }; // becomes 1 0 0 0 0  
            int[] arr4 = { 0, 1, 3, 8 }; // becomes 0 1 3 8

            /* Given an array of integers of any length, return an array that 
               has 1 added to the value represented by the array.

            *** the array can't be empty

            *** only non-negative, single digit integers are allowed

               Return nil(or your language's equivalent) for invalid inputs. */

            
            int position1 = arr1.Length - 1;
            Console.WriteLine(position1);


           






        }
    }
}
