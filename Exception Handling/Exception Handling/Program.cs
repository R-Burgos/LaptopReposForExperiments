namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int? answer = 0;
            Console.WriteLine("Please enter a number to divide:");
            var userDivide = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number:");
            int? userDivide2 = null;
            try
            {
                userDivide2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("No input");
            }

            try
            {
                answer = userDivide / userDivide2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This always occurs!");
            }

            Console.WriteLine($"The answer is {answer}");
        }

    }
}