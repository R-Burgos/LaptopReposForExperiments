using System;

namespace Testing_CodeWars
{
    internal class Program
    {
        public static string GetDrinkByProfession(string p)
        {

            switch (p)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politican":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    return "Beer";
                    break;
            }
            
        }
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            GetDrinkByProfession(profession);
        }
    }
}
