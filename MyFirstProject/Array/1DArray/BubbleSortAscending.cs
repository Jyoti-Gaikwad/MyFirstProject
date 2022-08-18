using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class BubbleSortAscending
    {
        public static int[] MySort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
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
        public static void Main(string[] ags)
        {
            int[] arr = { 13, 4, 23, 6, 7, 9, 5 };
            Console.WriteLine(String.Join(" ", arr));
            int[] sorted = BubbleSortAscending.MySort(arr);
            Console.WriteLine(String.Join(" ", sorted));
        }
    }
}

    

