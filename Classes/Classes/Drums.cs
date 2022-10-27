using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Drums // make keyword public from internal so they interact easier.
    {
        //use ctor + tab + tab to auto make a basic constructor

        public Drums() // Defailt Constructor <----------- special method for creating objects
        {

        }


        public Drums(string name)
        {
            Brand = name;
        }

        public Drums(string name, string color, string sound)
        {
            Brand = name;
            Color = color;
            Sound = sound;  
        }

        public int numberOfDrums = 5; // Field <------- made default value of 5
        // if field is private use "_name" best practice
        // field us camelCase


        public string Brand { get; set; } // Property <-----------
        // get is the read function. set is the write function
        //properties use PascalCase

        public string Color { get; set; }
        public string Sound { get; set; } = "Boom!!!"; // assign default value for Sound property

        public string Type { get; set; }


        public void HitDrum() // Method <---------
        {
            Console.WriteLine($"{Sound}");
        }
    }
}
