using System;
using System.Collections.Concurrent;

namespace Testing_CodeWars
{
    internal class Program
    {





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







        }   
    }
}
