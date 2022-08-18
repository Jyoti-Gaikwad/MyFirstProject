using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test6
{
    class Program5
    {
        static void SeparateZeros(int[] arr, int n)
        {
            
            int count = 0;

                for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                arr[count++] = arr[i];

                while (count < n)
                arr[count++] = 0;
        }
        public static void Main()
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int n = arr.Length;
            SeparateZeros(arr, n);
            Console.WriteLine("Array after Separating Zeros: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}

