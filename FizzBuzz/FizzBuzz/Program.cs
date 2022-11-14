namespace FizzBuzz
{
    public class Program
    {
        static string? FizzBuzz(int x)
        {
            //if (x % 3 == 0 && x % 5 == 0)
            //{
            //    return "fizzbuzz";
            //}
            //else if (x % 5 == 0)
            //{
            //    return "buzz";
            //}
            //else if (x % 3 == 0)
            //{
            //    return "fizz";
            //}
            //else
            //{
            //    return null;
            //}

            return (x % 3 == 0 && x % 5 == 0) ? "fizbuzz" : (x % 5 == 0) ? "buzz" : (x % 3 == 0) ? "fizz" : null;


        }

        static void Main(string[] args)
        {

            Console.WriteLine(FizzBuzz(15));
            Console.WriteLine(FizzBuzz(10));
            Console.WriteLine(FizzBuzz(6));
            Console.WriteLine(FizzBuzz(7));
        }
    }
}