using System;

namespace Methods_Jeremy_Way
{
    internal class Program
    {
        public static string MadLib(string name, string color, string animal, string band)
        {
            return $"{name} and {color} and {animal} and {band}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            string fullName = Console.ReadLine();
            Console.WriteLine("Color?");
            string faveColor = Console.ReadLine();
            Console.WriteLine("Animal?");
            string faveAnimal = Console.ReadLine();
            Console.WriteLine("Band");
            string faveBand = Console.ReadLine();
            
            //METHOD CALL
            string answer = MadLib(fullName, faveColor, faveAnimal, faveBand);
            Console.WriteLine($"{answer}");
        }
    }
}
