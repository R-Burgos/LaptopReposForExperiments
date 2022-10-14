using System;

namespace W3_CSharp_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("W3 C# Operators");
            // + operator to add two vaules
            int a = 100 + 50;
            Console.WriteLine(a);

            // + operator can also be used to add together a variable and a vaule, or a variable and another variable:

            int sum1 = 100 + 50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            /* Arithmetic Operators:
             *  (+) Addition x+y
             *  (-) Subtraction x-y
             *  (*) Multiplication x*y
             *  (/) Division x/y
             *  (%) Modulus(Returns the division remainder) x%y
             *  (++) Increment(Increases by 1) x++
             *  (--) Decrement(Decreases by 1) x--
             */



        }
    }
}
