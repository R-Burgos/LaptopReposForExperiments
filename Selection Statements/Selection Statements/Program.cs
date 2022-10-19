namespace Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Statements are control flow statements.  They guide the user. If statements tell the computer to make a choice by evaluating a boolean expression called condition(whats in here)
            int myAge = int.Parse(Console.ReadLine());
            if (myAge >=  21) //Use && or || to add more conditions
            {
                Console.WriteLine("Lets Drink!");
            }
            else
            {
                Console.WriteLine("No beer for you!");
            }

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

            Console.WriteLine("Please enter which folder to access:");
            Console.WriteLine("Options 1-4");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            { Console.WriteLine("File 1"); }
            if (userInput == 2)
            { Console.WriteLine("File 2"); }
            if (userInput == 3)
            { Console.WriteLine("File 3"); }
            if (userInput == 4)
            { Console.WriteLine("File 4"); }
            else
            { Console.WriteLine("Error."); }

            //switch statements
            // can use a Default keyword to be the catch all case.
            //cannot have duplicate cases.
            //type of variable of switch and case must be the same.
            //value of case must be a constant or literal. no variables in the case
            //use break keyword statement to terminate the sequence
            //default is optional and can be used anywhere but only one is allowed
         
            Console.WriteLine("What day is it: 1(Sunday)-7(Saturday)");
            var userDay = int.Parse(Console.ReadLine());
            switch (userDay)
            {
                case <=0:
                    Console.WriteLine("Wrong way Silly Billy");
                    break;
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                case >=8:
                    Console.WriteLine("You messed up dawg");
                    break;
            }

            Console.WriteLine("What is your favorite car?");
            string myFavCar = Console.ReadLine();  //if you add toLower here then myFavCar string would be permanently lowercasec

            switch (myFavCar.ToLower()) //to lower for case sensitivity
            {
                case "mustang":
                case "ford mustang":// you can add multi cases that each execute the code
                case "mustangs":
                    Console.WriteLine("Mustangs are cool.");
                    break;
                case "lambo":
                case "lamborghini":
                    Console.WriteLine("Lambos are sweet!");
                    break;
                case "tesla":
                case "tesla x":
                    Console.WriteLine("Teslas are awesome!");
                    break;
                case "corvette":
                case "vette":
                    Console.WriteLine("Corvettes rock!");
                    break;
                default: 
                    Console.WriteLine("Those are neat too!");
                    break;
            }

        }
    }
}