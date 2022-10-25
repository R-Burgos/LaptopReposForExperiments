<<<<<<< HEAD
﻿using Microsoft.VisualBasic;
using System;
=======
﻿using System;
using System.Collections.Concurrent;
>>>>>>> 67cd0603729d5f560148e98cb7440e5c7ce4062e

namespace Testing_CodeWars
{
    internal class Program
    {
<<<<<<< HEAD
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


           
=======





        static void Main(string[] args)
        {
            Console.WriteLine("Enter either an H, Q, or 9");
            string code = Console.ReadLine();
            char newCode = Convert.ToChar(code);

            if (newCode == 'H')
            {
                Console.WriteLine("Hello World!");
            }
            if (newCode == 'Q')
            {
                Console.WriteLine(newCode);
            }
            if (newCode == '9')
            {
                for (int i = 99; i >= 1; i--)
                {
                    string beerSong1 = " bottles of beer on the wall, ";
                    string beerSong2 = " bottles of beer.\n";
                    string beerSong3 = "Take one down and pass it around, ";
                    string beerSong4 = " bottles of beer on the wall.";

                    Console.WriteLine($"{i + beerSong1 + 1 + beerSong2 + beerSong3 + (i - 1) + beerSong4}");

                }
                string beerLast = "Take one down and pass it around, no more bottles of beer on the wall.\r\nNo more bottles of beer on the wall, no more bottles of beer.\r\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                Console.WriteLine(beerLast);
            }
            else
            {
                string? n = null;
                Console.WriteLine(n);
            }
>>>>>>> 67cd0603729d5f560148e98cb7440e5c7ce4062e






<<<<<<< HEAD
        }
=======

        }   
>>>>>>> 67cd0603729d5f560148e98cb7440e5c7ce4062e
    }
}
