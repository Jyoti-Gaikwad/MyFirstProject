using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class Sorting
    {
        public static int[] Ascending(int[] a)
        {
            for (int i = 0; i < a.Length/2; i++)
            {
                for (int j = i + 1; j < a.Length/2; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;
        }
        public static int[] Descending(int[] a)
        {
            for (int i = a.Length/2; i < a.Length ; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            return a;
        }
        public static void Main(string[] ags)
        {
            int[] arr = { 13, 4, 23, 6, 7, 9, 5 };
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine("Sorted Array:");
            int[] sorted = Sorting.Ascending(arr);
            int[] Sorted = Sorting.Descending(arr);
            Console.WriteLine(String.Join(" ", sorted));
        }
    }
}

    


  