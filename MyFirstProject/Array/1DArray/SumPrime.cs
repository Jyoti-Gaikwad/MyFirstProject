using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class SumPrime
    {
        public bool isPrime(int num)
        {
            for (int i = 2; i * i <= num; i++)
                if (num % 2 == 0)
                    return false;
            return true;
        }
        public int primesum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (isPrime(a[i]))
                { 
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumPrime s = new SumPrime();
            int sum = s.primesum(arr);
            Console.WriteLine("Sum of prime elements:" + sum);

        }
    }
}
