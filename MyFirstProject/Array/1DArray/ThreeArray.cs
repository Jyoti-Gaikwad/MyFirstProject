using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class ThreeArray
    {
       static void Main(string[] args)
        {
            int[] b=new int[5];
            int []c=new int[5];
            
            int[] a = { 1,2,3,4,5};
            Console.WriteLine("First Array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                    
                        b[i]=a[i];

                    }
                    else
                    {
                    
                        c[i]=a[i];
                    }
                }

            Console.WriteLine("Second Array:");

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.WriteLine("Third Array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);

            }


        }
    }
}
