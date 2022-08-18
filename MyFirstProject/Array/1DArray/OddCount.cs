using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class OddCount
    {
        public int Odd(int[] a)
        {
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
                
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] a1 = new int[5];
            Console.WriteLine("Enter array elements:");
            for(int i=0;i<a1.Length;i++)
            {
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }
            OddCount o = new OddCount();
            int odd = o.Odd(a1);
            Console.WriteLine("Odd Count:" + odd);
        }
    }
}
