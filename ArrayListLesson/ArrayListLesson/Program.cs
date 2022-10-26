// using System;
// using System.Collections.Generic; not needed in 6.0

using System.Globalization;

namespace ArrayListLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lists
            // Array and List must have the same data types in them.
            // Arrays are more for a fixed number of objects.
            // Lists are more flexible, they can grow or shrink as needed.

            //A collection is a class.  You must declare an instance of the class before you can add elements to that collection.
            // using System.Collection.Generic;

            // Making a new list.
            // Explicit typing below.
            List<int> intList = new List<int>() { 8, 7, 4, 58, 131, 847 };

            // Inferred typing below.
            var myName = new List<string>() { "Ruben", "Javier", "Burgos" };
            // Add to list.
            myName.Add("Rodriguez");
            Console.WriteLine(myName.Count); //Total number of items in list displayed

            foreach (var name in myName)
            {
                Console.WriteLine(name);
            }
            
            // You can use a for loop to go through a List.
            //Add only even numbers to a list.
            var numbers = new List<int>();
            for (int i = 2; i < 100; i += 2)
            {
                numbers.Add(i);
            }


            for (var i = 0; i < myName.Count; i++)
            {
                Console.WriteLine(myName[i]);
            }
            //[] and index number to display an item at that location from the list
            //Lists capacity will change dynamically as list grow.
            //Properties of Lists.  .Count lets you know the total number of objects in a list.  .Add lets you add an object to the list.  .Capacity tells you how many items that list can current hold.
            #endregion

            #region Arrays
            // not considered a collection but are similar to lists.
            // use dot notation to access their properties.

            //declaring an array with explicit typing
            int[] myArray1 = new int[3];
            //arrays do not dynamicaly change size, must declare the size.
            //initializing each index of the array
            myArray1[0] = 1;
            myArray1[1] = 2;
            myArray1[2] = 3;

            //declaring and initializing at the same time
            int[] myArray2 = new int[3] { 4, 5, 6 };
            //or
            int[] myArray3 = new int[] { 7, 8, 9 };
            // Array you use .Length
            Console.WriteLine(myArray3.Length);

            //shorthand
            var myArray4 = new int[] { 10, 11, 12 }; //using inferred typing with var

            //shorthand syntax
            string[] cars = { "Tesla", "Civic", "Camry" };

            //Iterate through cars from beginning to end
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            //Iterate through cars from end to beginning
            for (var i = cars.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(cars[i]);
            }
            // can convert arrays and lists using the .ToList() or .ToArray() functions.  .ToList will need the using.System.Linq;
            #endregion
        }
    }
}