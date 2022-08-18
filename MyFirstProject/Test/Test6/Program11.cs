using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test6
{
    class Program11
    {
       
        public static void Main(string[] args)
        {
            int [] arr = { 26,0,67,45,0,78,54,34,10,9,34};
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\nAfter Replacing:");
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
                Console.Write(arr[i] + " ");
            }

        }
    }

}

