using System;
using System.Collections.Generic;

namespace Basic13
{
    class Basic13
    {
        //Print 1-255

        public static void PrintTo255()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Print odd numbers between 1-255

        public static void PrintOddTo255()
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1) { Console.WriteLine(i); }

            }
        }

        //Print Sum 

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i < 256; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }

        //Iterating through an Array
        public static void PrintArray(params int[] vals)
        {
            foreach (var val in vals)
            {
                Console.WriteLine(val);
            }
        }

        //Find Max

        public static void FindMax(params int[] maxNums)
        {
            int max = maxNums[0];
            foreach (var maxNum in maxNums)
            {
                if (maxNum > max)
                {
                    max = maxNum;
                }
            }
            Console.WriteLine("Max: " + max);
        }

        //Get Average 

        public static void GetAvg(params int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            Console.WriteLine("avg: " + (sum / (nums.Length)));
        }

        //Array with Odd Numbers
        public static void OddArray()
        {
            var y = new List<int>();
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    y.Add(i);
                }
            }

            Console.WriteLine("array y: ");
            foreach (var i in y)
            {
                Console.Write( + i +", ");
            }
        }

        //Greater than Y

        public static void GtY(int y, params int[] compVals)
        {
            int count = 0;
            foreach (var compVal in compVals)
            {
                if (compVal > y)
                {
                    count++;
                }
                
            }
            Console.WriteLine($"Num on Ints greater than {y}: {count}");
        }

        //Square the Values 

        public static void SquareVals(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * x[i];
            }

            Console.Write("Squared Vals: ");
            foreach (var val in x)
            {
                Console.Write(val + ", ");
            }
            Console.WriteLine("");
        }
        
        

        //Eliminate Negative Numbers

        public static void NoNegs(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    x[i] = 0;
                }
            }

            Console.WriteLine("Array with no negs:");
            foreach (var i in x)
            {
                Console.Write(i + ", ");
            }
        }

        //Min, Max, and Average

        public static void MinMaxAvg(params int[] x)
        {
            FindMax(x);
            GetAvg(x);
            int min = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            Console.WriteLine("min: " + min);
        }

        //Shifting the values in an array

        public static void ShiftArray(List<int> shifties)
        {
            shifties.RemoveAt(0);
            shifties.Add(0);
            Console.Write("[ ");
            foreach (var shifty in shifties)
            {
                Console.Write(shifty + ", ");
            }
            Console.WriteLine("]");
        }

        //Number to String

        public static void NumToString(List<object> junk)
        {
            for (int i = 0; i < junk.Count; i++)
            {
                if ((int)junk[i] < 0)
                {
                    junk[i] = "Dojo";
                }
            }
            foreach (var item in junk)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}