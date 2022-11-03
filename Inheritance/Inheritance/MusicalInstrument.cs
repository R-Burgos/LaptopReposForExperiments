using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MusicalInstrument
    {

        public MusicalInstrument()
        {

        }

        public string Brand { get; set; }
        public bool PlaysNotes { get; set; }
        public bool PlaysRhytm { get; set; }
        public bool IsElectric { get; set; }
        public bool IsHandheld { get; set; }
        public string Sound { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Sound}");
        }










    }
}
