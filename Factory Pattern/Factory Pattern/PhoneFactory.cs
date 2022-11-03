using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public static class PhoneFactory
    {
        public static ICallable GetPhone(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "iphone":
                    return new iPhone();
                case "andriod":
                    return new Andriod();
                case "apple":
                    return new iPhone();
                default:
                    return new iPhone();
            }
        }
    }
}
