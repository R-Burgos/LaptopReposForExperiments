using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class Animal
        // No constructor for abstracts
    {
        public int numberOfLegs = 4;
        public bool HasTail { get; set; }
        public string Name { get; set; }
        public int NumberOfEyes { get; set; }
        public bool HasTeeth { get; set; }

        public string Color { get; set; }


        public abstract void MakeSound(); // stubbed out method No scope for abstract methods

        public abstract void Hunt();

        public virtual void EatsFood() // virtual methods have scope.... virtual methods define default implementation
        {
            Console.WriteLine("Munch, munch");
        }

        public abstract void Poops(Animal animal);




    }



    
}
