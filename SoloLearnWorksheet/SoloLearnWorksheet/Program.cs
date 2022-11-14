namespace SoloLearnWorksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7");
            int number = 7;

            int[] numx = new int[number];

            for(int i = 0; i < numx.Length; i++)
            {
                numx[i] = i+1;
            }

            Console.WriteLine("--------------");
            foreach (var x in numx)
            {
                Console.WriteLine(x);
            }

            foreach (var x in numx)
            {
                if (x % 3 == 0)
                {
                    numx[x] = 0;
                }
            }

            Console.WriteLine("--------------");
            foreach (var x in numx)
            {
                Console.WriteLine(x);
            }

        }
    }
}