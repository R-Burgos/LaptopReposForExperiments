namespace CodeWars_Worksheet
{
    internal class Program
    {

        public static string RepeatStr(int n, string s)
        {
            var i = 0;
            List<string> list = new List<string>();

            if (n == 0 || n == null)
            {
                return string.Empty;
            }
            else
            {
                do
                {
                    list.Add(s);

                    i++;
                } while (i < n);
            }

            return string.Join("", list);
        }


        public static ulong OddCount(ulong x)
        {

            ulong topRange = x;
            ulong bottomRange = 1;
            ulong numOdds;
            if (topRange % 2 != 0)
            {
                topRange++;
                
            }
            else
            {
                bottomRange--;
            }
            numOdds = (topRange - bottomRange) / 2;
            
            return numOdds;
        
        }


       





        static void Main(string[] args)
        {
            int n = 3;
            string s = "s";
            ulong x = 15;
            ulong y = 15023;

            //Console.WriteLine(RepeatStr(n, s));

            //Console.WriteLine(OddCount(y));


        }
    }
}