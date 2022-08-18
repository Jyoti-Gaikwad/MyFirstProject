using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class EvenPosition
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even Position array elements are:");
            for (int i=0;i<arr.Length;i++)
            {
                if(i%2==0)
                {
                    
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
