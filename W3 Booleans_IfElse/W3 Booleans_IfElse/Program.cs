// booleans -> yes/no on/off true/false
//boolean expression is an expression that returns a bollean value: true or false
//comparison operators can be used to generate a boolean expression

int x = 10;
int y = 9;
Console.WriteLine(x > y); //returns true, b/c 10 is higher than 9
//or easier:
Console.WriteLine(10 > 9); // returns true
Console.WriteLine(x == 10); //returns true
Console.WriteLine(10 == 15); //returns false

//the boolean value of an expression is the basis for all c# comparisons and conditions

static void SayHello(string firstName, string lastName)
{
    Console.WriteLine($"Hello, {firstName} {lastName}. Nice to meet you.");
}

SayHello("Jeremy", "Huddleston");


