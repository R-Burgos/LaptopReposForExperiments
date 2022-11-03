using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DrumSet : MusicalInstrument
    {
        public DrumSet()
        {
            PlaysNotes = false;
            PlaysRhytm = true;
            IsElectric = false;
            IsHandheld = false;
        }

        public bool IsBig { get; set; }
        public bool IsLoud { get; set; }

    }
}
