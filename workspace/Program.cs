using System;
using System.Collections.Generic;

namespace workspace
{
    class Program
    {

// This an example of a static function. Define it within the class "Program", but outside of the "Main" function. We can freely call it in Main once defined here.
// public defines level of access. Where can I run this function?
// static defines ...?
// void defines the return. What is returned when I run this function?
        public static void newfunction(string name = "buddy") // If we pass the parameter an argument here, it becomes the default if no argument is provided on Run.
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        public static string secondfunction(string name = "buddy")
        {
            return $"Hello, {name}";
        }


// Main function
        static void Main(string[] args)
        {

// An array in C# needs a pre-defined length and data type. When you create the variable denoted by [], it defaults all zeroes (for ints) or nulls (for strings).
            int[] numArray = new int[5];
            numArray = new int[] {1,3,5,7,9};

            // Using for-loop method
            Console.WriteLine("----Using for-loop method----");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("I can count to {0}.",numArray[i]);
            }

            // Using foreach loop method
            Console.WriteLine("----Using foreach-loop method----");
            foreach (int i in numArray)
            {
                Console.WriteLine("I can count to {0}.", i);
            }

// A list on C# is like an array of other languages. You don't need to worry about the length of it. You can add or remove at will.
            // Declaring a list
            List<string> bikes = new List<string>();

            bikes.Add("Kawasaki");
            bikes.Add("Harley Davidson");
            bikes.Add("Yamaha");

            // Using foreach loop method on a list
            Console.WriteLine("----Using foreach-loop method on a list----");
            foreach (string i in bikes)
            {
                Console.WriteLine("{0} is a motorcycle brand.", i);
            }

// Dictionaries in C# are like lists. They just aren't indexed by number- rather, indexed by key-value pair.
            // Declaring a dictionary
            Dictionary<string,string> profile = new Dictionary<string,string>();

            profile.Add("Name", "Adrian Fung");
            profile.Add("Email", "alokfung@gmail.com");

            // Using foreach on a dictionary
            Console.WriteLine("----Using foreach on a dict----");
            foreach (var i in profile)
            {
                Console.WriteLine("Item with key: {0} contains the value: {1}", i.Key,i.Value);
            }
        
// Calling functions
            newfunction();
            newfunction("Adrian");
            string sndfunction = secondfunction();
            Console.WriteLine(sndfunction);
        }
    }
}
