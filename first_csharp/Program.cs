using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a loop that prints all values from 1-255
            Console.WriteLine("---- Question 1 ----");
            for (int i = 1 ;i <=255; i++)
            {
                Console.WriteLine(i);
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            Console.WriteLine("---- Question 2 ----");
            for (int i = 1; i <=100; i++)
            {
                if ((i%3==0 || i%5==0) && i%15!=0)
                {
                    Console.WriteLine(i);
                }
            }

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            Console.WriteLine("---- Question 3 ----");
            for (int i = 1; i <=100; i++)
            {
                if (i%3==0 && i%15!=0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5==0 && i%15!=0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i%15==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
        }
    }
}
