using System.Text.RegularExpressions;  // Ask about how this came up auto when I used Regex.Replace

namespace Tesating
{
    internal class Program
    {

        public static string Check(string x)
        {

            string newX = Regex.Replace(x, "[^0-9]", "");
            int stringLength = newX.Length;

            return (newX.StartsWith("0") == true && stringLength == 11) ? $"{newX}" : "Not a phone number";


            //if (newX.StartsWith("0") == true && stringLength == 11)
            //{
            //    return $"{newX}";
            //}
            //else
            //{
            //    return "Not a phone number";
            //}
        }





        static void Main(string[] args)
        {
            // FOR KATA FixMyPhoneNumbers!

            string a = "S:)0207ERGQREG88349F82!efRF)"; // 02078834982
            string b = "sjfniebienvr12312312312ehfWh"; // fail
            string c = "0192387415456";  // fail
            string d = "v   uf  f 0tt2eg qe0b 8rtyq4eyq564()(((((165";  // 02084564165
            string e = "stop calling me no I have never been in an accident";  // fail

            //create a way to remove everything besides numbers from string
            //new string must be 11 digits long and start with 0

            Console.WriteLine(Check(a));





        }
    }
}