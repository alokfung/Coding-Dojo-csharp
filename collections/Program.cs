using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: 
            // Create an array to hold integer values 0 through 9
            int[] Array1 = new int[10];
            for (int i = 0; i<=9; i++)
            {
                Array1[i] = i;
            }

            foreach (int i in Array1)
            {
                Console.WriteLine("Value in position {0} of Array1: {1}",i,Array1[i]);
            }

            // Question 2
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] Array2 = new string[] {"Tim","Martin","Nikki","Sara"}; // Declre new array and values, Array 2
            foreach (string i in Array2)
            {
                Console.WriteLine(i);
            }

            // Question 3
            // Create an array of length 10 that alternates between true and false values, starting with true

            bool[] Array3 = new bool[10]; // Declare new array, Array3
            for (int i = 0 ; i < Array3.Length; i++)
            {
                if(i%2==0)
                {
                    Array3[i]=true;
                }
                else
                {
                    Array3[i]=false;
                }
            }

            // Print array
            foreach (bool b in Array3)
            {
                Console.WriteLine(b);
            }

            // Question 4
            // With the values 1-10, use code to generate a multiplication table like the one below.
            int [,] array_mult = new int[11,11];

            for (int i = 1; i<=10; i++)
            {
                for (int j = 1; j<=10; j++)
                {
                    array_mult[i,j] = i*j;
                }
            }

            for (int i = 1; i<=10; i++)
            {
                string print = "[ ";
                for (int j = 1; j<=10; j++)
                {
                    print += array_mult[i,j].ToString();
                    print += ",";
                    if(array_mult[i,j]<10 || (j==10 && i!=10))
                    {
                        print += " ";
                    }
                }
                print += "]";
                Console.WriteLine(print);
            }

            // Question 5
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)

            List<string> icecream = new List<string>();

            icecream.Add("Cookies and Cream");
            icecream.Add("Strawberry");
            icecream.Add("Chocolate");
            icecream.Add("Vanilla");
            icecream.Add("Snickers");
            icecream.Add("Pistachio");

            // Question 6
            // Output the length of this list after building it

            Console.WriteLine(icecream.Count);

            // Question 7
            // Output the third flavor in the list, then remove this value.

            Console.WriteLine(icecream[2]);
            icecream.RemoveAt(2);

            // Question 8
            // Output the new length of the list (Note it should just be one less~)

            Console.WriteLine(icecream.Count);

            // Question 9
            // Create a Dictionary that will store both string keys as well as string values

            Dictionary<string,string> dict = new Dictionary<string,string>();
            
            // Question 10
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null

            foreach (string i in Array2)
            {
                dict.Add(i,null);
            }

            // Question 11
            // For each name key, select a random flavor from the flavor list above and store it as the value

            Random rand = new Random();
            foreach (var x in dict)
            {
                dict[x.Key] = icecream[rand.Next(0,icecream.Count)];
            }

            // Question 12
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.

            foreach (var i in dict)
            {
                Console.WriteLine("User: {0}; Flavor: {1}",i.Key,i.Value);
            }
        }
    }
}



