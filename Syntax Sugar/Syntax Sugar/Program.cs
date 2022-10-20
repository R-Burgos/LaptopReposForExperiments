namespace Syntax_Sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SYNTAX AND SYNTAX SUGAR
            //Code must be readable in order to be understood by others.
            //CCR- CLEAR CONCISE AND READABLE
            //C# developed by Microsoft within .NET framework. Object-oriented based.

            //Syntax is grammar for programming
            //Clear: code should have a clear purpose and meaning
            //Concise: should not be unnecessarily long or verbose
            //Readable: easy to read and understand

            //Best Practices: best thing to do, decided by the coding community

            //Syntax Sugar: not required or necessarily best practice, but makes coding more convenient or conise.

            //Code Smell: any indicator in a program that a deep-seated issue is present in.

            //Type inference vs explicit typing. C# is Strongly(value types cannot be changed) and Statically(every variable must have a type) typed language.

            //Explicit Typing
            string firstName = "John"; //firstName has a type b/c it was intentionally given a string type by author

            //Inferred Typing
            var lastName = "Smith"; //when the compiler runs it will assign a type depending on the lastName's value.

            //inline if/Ternary Operator
            // (conditional) ? true-scope : false-scope;
            //Option 1
            var i = 1;
            string positiveMessage;
            if (i > 0)
            { 
                positiveMessage = "Your are positive"; 
            }
            else 
            {
                positiveMessage = "You are not positive!"; 
            }
            //OR.  Below is syntax sugar
            var meesage = (i > 0) ? "You are positive!" : "You are not positive!";


        }
    }
}