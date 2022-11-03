namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inheritance

            //inheritance is one of the four pillars in OOP.
            //enables you to create new classes that reuse, extend, and modify the behavior that is defined in other classes.

            //the class whose members are inherited from is called the base class and the class that inherits those members is called the derived class
            // used colon after derived class name then the base class SYNTAX


            var prs = new ElectricGuitar();
            prs.Brand = "Paul Red Smith";
            prs.Color = "Translucent Green";

            var steinway = new Piano();
            steinway.Brand = "Steinway";
            steinway.Upright = false;

            prs.MakeSound();
            steinway.MakeSound();
            


        }
    }
}