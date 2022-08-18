using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MinInt
    {
        public static int FindMin(int[] a)
        {
            int Min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (Min > a[i])
                {
                    Min = a[i];
                }
            }
            return Min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int maxValue = MinInt.FindMin(arr);
            Console.WriteLine("Maximum character from array: " + maxValue);
        }
    }
}
