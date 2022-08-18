using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class EvenSum
    {
        public int Evensum(int[] a)
        {
            int Sum = 0;
          for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Sum = Sum + a[i];
                }
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            int []arr = new int[5];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            EvenSum e = new EvenSum();
            int Sum = e.Evensum(arr);
            Console.Write("Sum of Even elements=" + Sum);
          
        }
    }
}
