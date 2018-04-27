using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        // Print whole array
        public static void printarr(int[] arr)
        {
            string arrstring = null;
            for(int i=0;i<arr.Length;i++)
            {
                if(i!=0)
                {
                    arrstring = arrstring + ",";
                }
                arrstring = arrstring + arr[i];
            }
            Console.WriteLine($"[ {arrstring} ]");
        }
        public static void fn1()
        {
            Console.WriteLine("---Answer 1---");
            for (int i=1;i<=255;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void fn2()
        {
            Console.WriteLine("---Answer 2---");
            for (int i=1;i<=255;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void fn3()
        {
            Console.WriteLine("---Answer 3---");
            int sum = 0;
            for (int i=1;i<=255;i++)
            {
                sum = sum + i;
                Console.WriteLine("New number: {0} | Sum: {1}",i,sum);
            }
        }
        public static void fn4()
        {
            Console.WriteLine("---Answer 4---");
            int[] newArr = new int[] {1,3,5,7,9,13};
            
            for(int i=0;i<newArr.Length;i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }
        public static void fn5max(int[] arr)
        {
            int max = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Maximum value in array is {max}");
        }
        public static void fn5min(int[] arr)
        {
            int min = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Minimum value in array is {min}");
        }
        public static void fn6(int[] arr)
        {
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            float avg = (float)sum / arr.Length;
            Console.WriteLine($"Average value of array is {avg}");
        }
        public static int[] fn7()
        {
            Console.WriteLine("---Answer 7---");
            int count = 0; // count to hold number of odd values
            List<int> odds = new List<int>(); // List to hold odd values
            for (int i=1;i<=255;i++)
            {
                if(i%2!=0)
                {
                    odds.Add(i);
                    count = count + 1;
                }
            }
            
            int[] arr = new int[count]; // Create array "count" length
            for (int i=0;i<count;i++)
            {
                arr[i] = odds[i]; // Pull each number from stored list
            }

            return arr;
        }

        public static void fn8(int[] arr, int y)
        {
            Console.WriteLine("---Answer 8---");
            int count = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]>y)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine($"# greater than {y} = {count}.");
        }
        public static int[] fn9(int[] arr)
        {
            Console.WriteLine("---Answer 9---");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=arr[i]*arr[i];
            }

            return arr;
        }
        public static int[] fn10(int[] arr)
        {
            Console.WriteLine("---Answer 10---");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    arr[i]=0;  
                }
            }

            return arr;
        }
        public static void fn11(int[] arr)
        {
            Console.WriteLine("---Answer 11---");
            fn5max(arr); // MAX
            fn5min(arr); // MIN
            fn6(arr); // AVG
        }
        public static int[] fn12(int[] arr)
        {
            Console.WriteLine("---Answer 12---");
            for(int i=0;i<arr.Length;i++)
            {
                if(i!=arr.Length-1)
                {
                    arr[i]=arr[i+1];
                }
                else
                {
                    arr[i]=0;
                }
            }
            return arr;
        }
        public static object[] fn13(int[] arr)
        {
            Console.WriteLine("---Answer 13---");
            object[] newarr = new object[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    newarr[i] = "Dojo";
                }
                else
                {
                    newarr[i] = arr[i];    
                }
            }
            return newarr;
        }
        static void Main(string[] args)
        {
            // Print all ints between 1-255
            fn1();

            // Print all odd ints between 1-255
            fn2();

            // Write a program that would print the numbers from 0 to 255 but this time, it would also print the sum of the numbers that have been printed so far.
            fn3();

            // Given an array X, say [1,3,5,7,9,13], write a program that would iterate through each member of the array and print each value on the screen. Being able to loop through each member of the array is extremely important.
            fn4();

            // Write a program (sets of instructions) that takes any array and prints the maximum value in the array. Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), or even a mix of positive numbers, negative numbers and zero.
            fn5max(new int[] {-2,3,2});

            // Write a program that takes an array, and prints the AVERAGE of the values in the array. For example for an array [2, 10, 3], your program should print an average of 5. Again, make sure you come up with a simple base case and write instructions to solve that base case first, then test your instructions for other complicated cases. You can use a count function with this assignment.
            fn6(new int[] {0,2,9});

            // Write a program that creates an array 'y' that contains all the odd numbers between 1 to 255. When the program is done, 'y' should have the value of [1, 3, 5, 7, ... 255].
            int[] test = fn7();
            printarr(test);

            // Write a program that takes an array and returns the number of values in that array whose value is greater than a given value y. For example, if array = [1, 3, 5, 7] and y = 3. After your program is run it will print 2 (since there are two values in the array that are greater than 3).
            fn8(new int[] {1,3,5,6,7,8}, 3);

            // Given any array x, say [1, 5, 10, -2], create an algorithm (sets of instructions) that multiplies each value in the array by itself. When the program is done, the array x should have values that have been squared, say [1, 25, 100, 4].
            int[] test2 = fn9(new int[] {1,5,10,-2});
            printarr(test2);

            // Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any negative number with the value of 0. When the program is done, x should have no negative values, say [1, 5, 10, 0].
            int[] test3 = fn10(new int[] {1,5,10,-2});
            printarr(test3);

            // Given any array x, say [1, 5, 10, -2], create an algorithm that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
            fn11(new int[] {1,5,10,-2});

            // Given any array x, say [1, 5, 10, 7, -2], create an algorithm that shifts each number by one to the front and adds '0' to the end. For example, when the program is done,  if the array [1, 5, 10, 7, -2] is passed to the function, it should become [5, 10, 7, -2, 0].
            int[] test4 = fn12(new int[] {1,5,10,7,-2});
            printarr(test4);

            // Write a program that takes an array of numbers and replaces any negative number with the string 'Dojo'. For example, if array x is initially [-1, -3, 2] your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] test5 = fn13(new int[] {-1,-3,2});
        }
    }
}
