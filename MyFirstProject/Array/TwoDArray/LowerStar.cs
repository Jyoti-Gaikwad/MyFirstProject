using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class LowerStar
    {
        static void Main(string[] args)
        {
            char[,] a = new char[5, 5];
            //Console.WriteLine("Enter Element:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i >= j)
                    {

                        a[i, j] = '*';
                    }
                    else
                    {
                        a[i, j] = ' ';
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Display Array");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
