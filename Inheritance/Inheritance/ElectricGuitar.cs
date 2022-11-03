using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ElectricGuitar : MusicalInstrument
    {
        public ElectricGuitar()
        {
            PlaysNotes = true;
            PlaysRhytm = true;
            IsElectric = true;
            IsHandheld = true;
        }

        public int NumberOfStrings { get; set; } = 6;
        public string Color { get; set; }







    }
}
