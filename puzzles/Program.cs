using System;
using System.Collections.Generic;

namespace puzzles
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
        // Print whole array
        public static void printarrstr(string[] arr)
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
        // RandomArray
        // Create an array of length 10 and populate with random values between 5 and 25.
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] temp = new int[10];
            int max = 0;
            int min = 0;
            int sum = 0;

            for(int i=0;i<temp.Length;i++)
            {
                temp[i] = rand.Next(5,25);
                sum = sum + temp[i];
                if(i>0)
                {
                    if(temp[i]>max)
                    {
                        max = temp[i];
                    }
                    else if(temp[i]<min)
                    {
                        min = temp[i];
                    }
                }
                else
                {
                    max = temp[i];
                    min = temp[i];
                }
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {max} | Min: {min}");

            return temp;
        }
        // Coin Flip
        public static int CoinToss(Random rand)
        {
            Console.WriteLine("Tossing a Coin...");
            int flip = rand.Next(0,2);
            if(flip==1)
            {
                Console.WriteLine("It came up heads!");
            }
            else
            {
                Console.WriteLine("It came up tails!");
            }
            return flip;
        }
        public static double TossMultipleCoins(int num, Random rand)
        {
            int[] arr = new int[num];
            int sum = 0;
            double ratio = 0;
            for(int i=0;i<num;i++)
            {
                arr[i] = CoinToss(rand);
                sum = sum + arr[i];
            }

            ratio = (double)sum / arr.Length;

            return ratio;
        }
        public static string[] Names()
        {
            Random rand = new Random();
            string[] arr = new string[] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            
            // Determine an array of random indexes
            int[] temparr = new int[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                if(i==0) // First value of arr
                {
                    temparr[i] = rand.Next(0,arr.Length); // Set random number for first temparr position
                }
                else
                {
                    int temp_rand = rand.Next(0,arr.Length);
                    for(int j=0;j<i;j++) // Cycle though already set positions
                    {
                        if(temparr[j] == temp_rand) // Determine if the new random number has already been set
                        {
                            j = -1;
                            temp_rand = rand.Next(0,arr.Length);
                        }
                    }
                    temparr[i] = temp_rand;
                }
            }

            // Use random indexes to create new array with names shuffled
            string[] newarr = new string[arr.Length];
            for(int x=0;x<arr.Length;x++)
            {
                newarr[x] = arr[temparr[x]];
            }

            return newarr;
        }
        public static string[] NameLength()
        {
            string[] arr = new string[] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            List<string> templist = new List<string>();
            int size = 0;

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i].Length>5)
                {
                    size = size + 1;
                    templist.Add(arr[i]);
                }
            }

            string[] newarr = new string[size];
            for(int i=0;i<newarr.Length;i++)
            {
                newarr[i] = templist[i];
            }
            return newarr;
        }
        static void Main(string[] args)
        {
            printarr(RandomArray());
            Random rand = new Random();
            Console.WriteLine($"Heads %: {TossMultipleCoins(5,rand)}");

            printarrstr(Names());

            printarrstr(NameLength());
        }
    }
}
