using System;

namespace BMR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please state your name.");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}.");

            Console.WriteLine("This application will inform you of your BMR.");

            Console.WriteLine($"What is your age, {userName}?");
            var userAge = Console.ReadLine();

            Console.WriteLine("What is your current weight in lbs?");
            var userWeight = Console.ReadLine();

            Console.WriteLine("What is your height in total inches?");
            var userHeight = Console.ReadLine();

            Console.WriteLine("Last question, what is your assigned sex?");
            Console.WriteLine("Please enter M for Male or F for Female.");

            string male = "M";
            string female = "F";
            string userSex = Console.ReadLine();

            if (male == userSex)
            {

                var maleBMR = (66.5 + (13.75 * ((Convert.ToDouble(userWeight) * 0.453592))) + (5.003 * ((Convert.ToDouble(userHeight) * 2.54))) - (6.75 * Convert.ToDouble(userAge)));

                Console.WriteLine($"{userName}, your BMR is {Convert.ToInt32(maleBMR)}kcal.");
                Console.WriteLine("BMR stands for basal metabolic rate. This is how many calories your body needs to sustain itself.");

            }
            else if (female == userSex)
            {
                var femaleBMR = (655.1 + (9.563 * ((Convert.ToDouble(userWeight) * 0.453592))) + (1.850 * ((Convert.ToDouble(userHeight) * 2.54))) - (4.676 * Convert.ToDouble(userAge)));

                Console.WriteLine($"{userName}, your BMR is {Convert.ToInt32(femaleBMR)}kcal.");
                Console.WriteLine("BMR stands for basal metabolic rate. This is how many calories your body needs to sustain itself.");

            }
            else
            {
                Console.WriteLine("It seems an error has been made. Please restart the program.");
            }


            


        }
    }
}
