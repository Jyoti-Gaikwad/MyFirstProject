
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array.TwoDArray
{
    class SparseMatrix
    {
        public static void Sparse(int[,]a)
        {
            int Count = 0;
            int Count1 = 0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(a[i,j]!=0)
                    {
                        Count++;
                    }
                    else
                    {
                        Count1++;
                    }
                }
            }
            if(Count1>Count)
            {
                Console.WriteLine("Sparse matrix");
            }
            else
            {
                Console.WriteLine("Not Sparse matrix");
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                   
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Sparse(arr);
        }
    }
}
