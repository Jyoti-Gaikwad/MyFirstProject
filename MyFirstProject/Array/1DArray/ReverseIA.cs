using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class ReverseIA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("Enter the elements of array:");

            for(int i=0;i<=a.Length-1;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display Reverse Array:");
            for (int i= a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

        }
       

       

    }
}
