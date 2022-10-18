using System;

namespace Method_Experimenting
{
    internal class Program
    {
        /* Access Modifiers: public is the access modifier. Defines the scope and visibility.
         * Return Type: int is the return type. This is what the method will produce. void is the absence of a return type
         * Name: Addition is the method name. Must use PascalCase
         * Parameters: (inside) are the parameter-list/ list of parameters passed into the method (optional)
         * Scope / Body: block of code to be executed when the method is called.
         * 5 things that make a method:
         * Access Modifier, Return Type, Name, Parameters, Scope
         * void would be the absence of a return type.
         */

        /*Access Modifier types:
         * Public: this element can be accessed from every class, no matter from the current project.
         * Private: cannot be accessed from any other class except the class in which it is defined in.
         * Internal: used to limit the access to the elements of the class only to files from the same assembly.
         * Protected: the type or member can be accessed only by code in the same class or in a class that is derived from that class.
         */

        /* return Keyword returns the return type and ends the execution of the method.
         * return keyword ends the method.
         * void return types do not need a return keyword.
         */
        public static int Max(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }

        public static int Addition(int num1, int num2)
            { return num1 + num2; }

        static void Main(string[] args)
        {
            int answer1 = Addition(500, 439);
            int answer2 = Addition(2, 6);
         
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }
    }
}
        
        
