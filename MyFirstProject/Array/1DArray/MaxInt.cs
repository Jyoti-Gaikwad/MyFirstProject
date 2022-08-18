using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MaxInt
    {
        public static int FindMax(int[] a)
        {
            int Max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (Max < a[i])
                {
                    Max = a[i];
                }
            }
            return Max;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5 };
            int maxValue = MaxInt.FindMax(arr);
            Console.WriteLine("Maximum character from array: " + maxValue);
        }
    }
}
