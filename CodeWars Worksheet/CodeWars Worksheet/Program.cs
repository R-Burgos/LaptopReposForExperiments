namespace CodeWars_Worksheet
{
    internal class Program
    {
        public static double FindAverage(double[] array)
        {
            double sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
                return sum;
            }
            var average = sum / (array.Length);

            return average;
        }
        static void Main(string[] args)
        {
           
        }
    }
}