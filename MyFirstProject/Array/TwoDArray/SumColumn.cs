using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class SumColumn
    {
            public static void SumofColumn(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    
                    sum = sum + a[j, i];
                }
                    Console.WriteLine("Sum=" + sum);
                
                    Console.WriteLine();

                }
            }
            static void Main(string[] args)
            {
                int[,] arr = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
                SumColumn.SumofColumn(arr);
            }
        }
    }


