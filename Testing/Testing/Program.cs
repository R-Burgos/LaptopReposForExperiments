


object x = 66;
object[] myArray = new object[] { 66, 101};

foreach (var num in myArray)
{
    if (num == x)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}
