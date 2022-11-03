using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Piano : MusicalInstrument
    {
        public Piano()
        {
            PlaysNotes = true;
            PlaysRhytm = true;
            IsElectric = false;
            IsHandheld = false;
        }
        public bool Upright { get; set; }


    }
}
