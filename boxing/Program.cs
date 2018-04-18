using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list of type object
            List<object> alist = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair" 
            alist.Add(7);
            alist.Add(28);
            alist.Add(-1);
            alist.Add(true);
            alist.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (object i in alist)
            {
                Console.WriteLine(i);
            }

            // Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (object i in alist)
            {
                if(i is int)
                {   
                    int j = 0;
                    j = (int)i;
                    sum = sum + j;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
