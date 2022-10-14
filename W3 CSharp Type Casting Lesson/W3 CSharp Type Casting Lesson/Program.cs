// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);


// Explicit Casting
//Must be done manually by placing the type in parentheses in front of the value
double myD2 = 9.78;
int myI2 = (int)myD2;
Console.WriteLine(myD2);
Console.WriteLine(myI2);

//Type Conversion Methods
/* Convert data types with the following:
 * Convert.ToBoolean
 * Convert.ToDouble
 * Convert.ToString
 * Convert.ToInt32 (int)
 * Convert.ToInt64 (long)
 */

int myI3 = 10;
double myD3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myI3));
Console.WriteLine(Convert.ToDouble(myI3));
Console.WriteLine(Convert.ToInt32(myD3));
Console.WriteLine(Convert.ToString(myBool));

