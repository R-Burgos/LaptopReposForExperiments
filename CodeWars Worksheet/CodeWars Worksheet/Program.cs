using System.Collections;
using System.Collections.Generic;

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


        public static string Likes(string[] name)
        {

            int nameCount = name.Length;

            switch (nameCount)
            { 
                case 0:
                    return "no one likes this";
                    break;
                case 1:
                    return $"{name[0]} likes this";
                    break;
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                case 4:
                    return $"{name[0]}, {name[1]} and {nameCount - 2} others like this";
                default:
                    return $"{name[0]}, {name[1]} and {nameCount - 2} others like this";
                    break;
            }      

        }

        public static int[] MoveZeroes(int[] arr)
        {
           
           

          
              

                





            











        }






        static void Main(string[] args)
        {
            //int n = 3;
            //string s = "s";
            //ulong x = 15;
            //ulong y = 15023;

            //Console.WriteLine(RepeatStr(n, s));

            //Console.WriteLine(OddCount(y));

            //string[] name  = Array.Empty<string>();
            //string[] name1 = { "John" };
            //string[] name2 = { "John", "Jimmy" };
            //string[] name3 = { "John", "Jimmy", "Jason" };
            //string[] name4 = { "John", "Jimmy", "Jason", "Jerry" };
            //string[] name5 = { "John", "Jimmy", "Jason", "Jerry", "Jeff", "Joseph", "Jake" };


            //Console.WriteLine(Likes(name));
            //Console.WriteLine(Likes(name1));
            //Console.WriteLine(Likes(name2));
            //Console.WriteLine(Likes(name3));
            //Console.WriteLine(Likes(name4));
            //Console.WriteLine(Likes(name5));

            int[] numz = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            MoveZeroes(numz);

        }
    }
}