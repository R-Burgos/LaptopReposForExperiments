using System;

namespace Methods_Jeremy_Way2
{
    internal class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Color");
            string faveColor = Console.ReadLine();
            Console.WriteLine($"{firstName} and {faveColor}");
        }

        //Cleaner in the Main section. Everything has been moved to the MadLib Method.
        static void Main(string[] args)
        {
            MadLib();
        }
    }
}
