
using System.Runtime.CompilerServices;

Console.WriteLine(Math.Max(5, 10));
//Find highest value of x and y

Console.WriteLine(Math.Min(5, 10));
//Find lowest value of x and y

Console.WriteLine(Math.Sqrt(64));
//Find square root of x

Console.WriteLine(Math.Abs(-4.7));
//Find absolute value of x

Console.WriteLine(Math.Round(9.99));
//Round number to nearest whole number

string txt1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: "+txt1.Length);
// Text length found using the Length property

string txt2 = "Hello World";
Console.WriteLine(txt2.ToUpper()); //Outputs all in uppercase
Console.WriteLine(txt2.ToLower()); //Outputs all in lowercase

// String Concatenation (+)
string firstName = "John";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
// the + is used to combine two strings, this is called concatenation
//or you can use string.Concat() method to combine two strings
string fullname = string.Concat(firstName, lastName);
Console.WriteLine(fullname);
//String interpolation is another option for string concatenation.
//You know how to use this. $$$

//Access Strings: access characters in a string by referring to its index number inside square brackets []
//String indexes start with 0: [0] is the first character. [1] is the second character, etc.
string myString = "Hello";
Console.WriteLine(myString[0]); // Outputs "H"
Console.WriteLine(myString[1]); // Outputs "e"

//You can find the position of a specific character in a string by using IndexOf() method
Console.WriteLine(myString.IndexOf("e")); //Outputs "1"

//Substring() method extracts the characters from a string, starting from the specified character position/index,
//and returns a new string.  Method is used with IndexOf() to get the specific character position

string fullname2 = "Marcus Aurelius"; //Full name
int charPosition = fullname2.IndexOf("A");  //Location of the letter A
string lastname2 = fullname2.Substring(charPosition);  //Gets the last name
Console.WriteLine(lastname2); //Prints Aurelius

//Because strings must be written within quotes in C#, this will generate an error:
/*
string txt = "We are the so-called "Vikings" from the north.";
*/
//Use the backslash escape character: turns special characters into string characters 
/*
 *  \' will display ' or single quote
 * \" will display " or double quotes
 * \\ will display \ or Backslash
 */
string txt = "We are the so-called \"Vikings\" from the north."; // FIXED
//Other useful escape characters are:
/* 
    \n New Line in a string
    \t Tab adds a tab space
    \b Backspace 
*/