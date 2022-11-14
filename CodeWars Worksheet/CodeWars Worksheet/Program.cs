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


        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];

            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine($"{z[i]} before");
                z[i] = x * (i+1);
                Console.WriteLine($"{z[i]} after");
            }

            return z;
        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int sum = YourPoints;
            int totalArr = ClassPoints.Length + 1;

            for (int i = 0; i < ClassPoints.Length; i++)
            {
                sum += ClassPoints[i];
            }

            int average = sum / totalArr;

            if (average >= YourPoints)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }

        public static int Sum(int[] numbers)
        {
            var arrSize = numbers.Length;

            if (arrSize <= 1)
            {
                return 0;
            }
            else
            {
                Array.Sort(numbers);
                Array.
            
            
            
            }

            return 0;
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            foreach (var x in names)
            {
                foreach (char c in x)
                { 
                    
                
                }




            
            }
        
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

            //int x = 2;
            //int n = 5;

            //CountBy(x, n);

            //int[] classPoints1 = new int[] { 2, 3};
            //int myPoints1 = 5;

            //int[] classPoints2 = new int[] { 100, 40, 34, 57, 29, 72, 57, 88 };
            //int myPoints2 = 19;

            //Console.WriteLine(BetterThanAverage(classPoints1, myPoints1));
            //Console.WriteLine(BetterThanAverage(classPoints2, myPoints2));

            //int[] numbers = new int[] { 6, 2, 1, 8, 10 };


        }
    }
}