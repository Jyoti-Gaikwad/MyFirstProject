using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class TwoD1
    {
        private static int[,][,] sum;

        public static int[,][,] Addition(int[,]a2,int[,]a3)
        {
         
           
            for ( int i = 0; i < a2.GetLength(0); i++)
            {
                
                for ( int j = 0; j < a2.GetLength(1); j++)
                {
                     int sum = a2[i, j] + a3[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter the element of first array:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display Array:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] a1 = new int[2, 2];
            Console.WriteLine("Enter the element of second array:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display Array:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Display Sum:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    TwoD1.Addition(a, a1);
                }
                    Console.WriteLine();
            }
            
        }
    }
}
