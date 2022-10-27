namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var myDrumKit = new Drums()  // Object Initializer Syntax used here
            {
                Type = "Acoustic", 
                Brand = "Sonor", 
                Color = "Sparkle White"
            };

            var my2ndDrumKit = new Drums();
            my2ndDrumKit.Brand = "Pearl";   // Dot Notation
            my2ndDrumKit.Color = "Sparkle Red";
            my2ndDrumKit.Sound = "Crack!!!";
            my2ndDrumKit.Type = "Acoustic";

            Console.WriteLine(my2ndDrumKit.Brand);
            Console.WriteLine(my2ndDrumKit.Color);
            Console.WriteLine(my2ndDrumKit.Sound);
            Console.WriteLine(my2ndDrumKit.Type);


            myDrumKit.HitDrum();

            //Custom Constructor
            var myOldKit = new Drums("Tama", "Orange", "Loud");

            Console.WriteLine($"My old kit was a {myOldKit.Brand} and it was {myOldKit.Color} and it was  {myOldKit.Sound}!");
           

        }
    }
}