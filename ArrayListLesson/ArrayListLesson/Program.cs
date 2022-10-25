// using System;
// using System.Collections.Generic; not needed in 6.0

using System.Globalization;

namespace ArrayListLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //Properties of Lists.  .Count lets you know the total number of objects in a list.  .Add lets you add an object to the list.  .Capacity tells you how many items that list can current hold.
            
        }
    }
}