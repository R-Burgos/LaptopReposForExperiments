//Methods allow us to perform actions in our code.

/* Scope is everything inside of {}


/*
public interface Max (int x, int y)
   {
    if (x > y)
        return x;
    else
        return y;
   }
*/


    public static void AgeChecker ()
    {
        Console.WriteLine("How old are you?");
        int userAge = int.Parse(Console.ReadLine());

        if (userAge < 21)
        {
        Console.WriteLine("Sorry you are not old enough to drink!");
        }
        else
        {
        Console.WriteLine("Welcome to our brewery website!");
        }
    }

  AgeChecker ();
