using System;

namespace Methods_Jeremy_Way_Part_2
{
    internal class Program
    {
        public static int Add(int num1, int num2) 
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static double Div(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Mod(int num1, int num2)
        {
            return num1 % num2;
        }
        //PARAMS
        public static int AddParams(params int[] nums)
        {
            int sum = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 9));
            Console.WriteLine(Sub(4, 9));
            Console.WriteLine(Mult(4, 9));
            Console.WriteLine(Div(4, 9));
            Console.WriteLine(Mod(4, 9));

            Console.WriteLine(AddParams(1, 1, 1, 1, 1));
            Console.WriteLine(AddParams(7, 9, 15, 87, 34, 63, 42, 100));

        }
    }
}
