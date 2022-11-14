namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var evens = new List<int>();
            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    { 
            //        evens.Add(num);
            //    }
            //}

            // var evens = numbers.Where(x => (x % 2) == 0); // using LINQ 

            char[] charCount = { 'A', 'B', 'C', 'A'};
            char x = 'A';

            CountChar(charCount, x);



        }
        public static int CountChar(char[] chars, char charToCount)
        {
            var occurences = 0;

            occurences = chars.Where(x => x == charToCount).Count();
            Console.WriteLine(occurences);


            return occurences;
        }




    }
}