namespace Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If statements
            bool condition = true;
            if (condition)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            int favNumber = 200;

            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess == favNumber)
            {
                Console.WriteLine("Correct!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Too Low!");
            }

            // You can do if statements on their own. You don't have to do else statments

            do 
            {
                
            } while
        }
    }
}