using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class FrequencyArray
    {
        public static void FindOccurance(int[]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Frequency of element:");
                    Console.WriteLine(a[i] + " " + count);
                }
            }
        }

         static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array element:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            FrequencyArray.FindOccurance(arr);
        }
    }
}
