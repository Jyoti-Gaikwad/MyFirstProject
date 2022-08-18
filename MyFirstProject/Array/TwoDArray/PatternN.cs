using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class PatternN
    {
        public static void Patternn(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(j==0||j==a.GetUpperBound(1)||i==j)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Console.WriteLine("Enter the array element:");
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Display Array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            PatternN.Patternn(arr);
        }
    }
}
