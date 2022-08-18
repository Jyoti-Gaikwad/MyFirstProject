using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test6
{
    class Program9
    {
        static void perfectSquares(int[]a)
        {

            
            for (int i = 0; i <= a.Length-1; i++)
            {

                
                if (Math.Sqrt(a[i]) == (int)Math.Sqrt(a[i])&&a[i]!=0)
                    Console.Write(a[i] + " ");
            }
        }

        
        public static void Main(String[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };

            Console.WriteLine("Perfect Square Numbers:");
            perfectSquares(arr);
        }
    }
}

