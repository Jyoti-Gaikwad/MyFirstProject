using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class Sum1
    {
        public int Sum(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sum1 s = new Sum1();
            int sum = s.Sum(arr);
            Console.WriteLine("Sum of array elements:" + sum);
        }
    }
}
