namespace Abstracts
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var grizzly = new Bear();
            grizzly.Name = "Smokey";
            Console.WriteLine(grizzly.Name);
            grizzly.MakeSound();
            grizzly.EatsFood();

            var redTail = new Hawk();
            redTail.Name = "Red Tail";
            Console.WriteLine(redTail.Name);
            redTail.MakeSound();
            redTail.EatsFood();

            // how to create an object of type animal with explicite typing

            Animal polarBear = new Bear(); // uses bear constructor but the polarBear is type Animal NOT bear.  Uses Animal type instead of var.

            var animalList = new List<Animal>(); // if you change to <Hawk> only the redTail will go in.

            animalList.Add(polarBear);
            animalList.Add(grizzly);
            animalList.Add(redTail);

            grizzly.Poops(grizzly);
            redTail.Poops(redTail);

        }
    }
}