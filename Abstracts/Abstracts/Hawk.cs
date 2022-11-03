using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public class Hawk : Animal

    {
        public Hawk()
        {
            HasTail = true;
            HasTeeth = false;
            numberOfLegs = 2;
            NumberOfEyes = 2;
            Color = "brown and white";
        }

        public override void Hunt()
        {
            Console.WriteLine("Hawk soars in the sky looking for mice.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squawk!");
        }

        public override void Poops(Animal hawk)
        {
            Console.WriteLine($"{hawk.Name} poops.");
        }
    }
}
