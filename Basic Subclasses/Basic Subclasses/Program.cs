using System;

namespace Basic_Subclasses
{
    public class Program
    {
        //public static int[] UpArray(int[] num)
        //{ 
        //    // 1. Take in int[] num through the method
        //    // 2. Take initial array length as initialA variable or something similar
        //    // 3. Convert int[] to a list or concatinate and convert to string or int.
        //    // 4. Add 1 to the new number
        //    // 5. Convert back to single integers 
        //    // 6. Convert back to array with correct number of index.
        //    // May have to look up split commands for this

        //    var intialArrayLength = num.Length;
        //    var listNum = num.ToList();
            
           



            




        
        //}

        static void Main(string[] args)
        {
            var num1 = new int[] { 2, 3, 9 };
            var num2 = new int[] { 4, 3, 2, 5 };
            var num3 = new int[] { 0, 4, 2 };
            var num4 = new int[] { 9, 9 };
            var num5 = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1 };

            // UpArray(num1);

            string num1String = string.Join("", num1);
            Console.WriteLine($"{num1String}");
            var num1Int = Convert.ToInt32(num1String);
            var newNum1Int = num1Int + 1;
            Console.WriteLine(newNum1Int);
            num1String = Convert.ToString(newNum1Int);
            var newNum1Arr = num1String.Split("");

            Console.WriteLine(newNum1Arr.Length);

            foreach (var num in newNum1Arr)
            {
                Console.WriteLine($"{num}");
            }



        }
    }
}