using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Andriod : ICallable
    {
        public Andriod()
        {

        }

        public void Build()
        {
            Console.WriteLine("Building new Andriod."); 
        }
    }
}
