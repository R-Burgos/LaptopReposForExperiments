using System;

namespace W3_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is for W3 C# User Input Section.");

            /* Console.ReadLine() is used to get user inputs. */

            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);
            Console.WriteLine("Hello, " + userName);

            //Console.ReadLine() method returns a string.  It cannot get information from another data type like int.  It will return an error
            /* 
             * The following will return an error:
             * Console.WriteLine("Enter your age:");
             * int age = Convert.ToInt32(Console.ReadLine());
             * Console.WriteLine("Your age is: " + age);
             * The error message: Cannot implicitly convert type 'string' to 'int'
             */

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            // By using the Convert.To the program will run

        }

    }
}
