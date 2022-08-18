using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class MaxColumn
    {
        public static void ColMax(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[0, i];
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(max<a[j,i])
                    {
                        max = a[j, i];
                    }
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("Column Max=" + max);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)

        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            MaxColumn.ColMax(arr);
        }
    }
}
