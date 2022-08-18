using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class ReverseArray
    {
        public static int Reverse(int[] a)
        {
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join("", arr));

            //int[] r = Reverse(arr);
            Console.WriteLine("--------Reverse Array-------");
            Console.WriteLine(string.Join("", arr));

        }









    }
}
