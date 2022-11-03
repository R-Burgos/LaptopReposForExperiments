using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class iPhone : ICallable
    {
        public iPhone()
        {

        }

        public void Build()
        {
            Console.WriteLine("Building a new iPhone.");
        }
    }
}
