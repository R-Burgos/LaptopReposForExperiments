using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public class Bear : Animal
    {
        // Not forced to implement the EatsFood() because it was defined as optional in the absract class
        public Bear()
        {
            HasTail = true;
            HasTeeth = true;
            NumberOfEyes = 2;
            numberOfLegs = 4;
            Color = "brown";
        }



        public override void EatsFood()
        {
            Console.WriteLine("Chomp, chomp");
            //base.EatsFood();
        }
        // base.EatsFood(); relates to the default method in the abstract class
        public override void Hunt()
        {
            Console.WriteLine("Bear eats honey and fish.");
        }

        public override void MakeSound()  // Need this because in the abstract class this abstract method exist
        {
            Console.WriteLine("Grrrrrrrrrr!");
        }

        public override void Poops(Animal bear)
        {
            Console.WriteLine($"{bear.Name} poops.");
        }
    }
}
