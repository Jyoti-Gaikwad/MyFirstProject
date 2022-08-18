using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class Float
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            float[] f = new float[size];
            Console.WriteLine("Enter the array elements:");

            for(int i=0;i<=f.Length-1;i++)
                {
                f[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Display:");
            foreach(float F in f)
            {
                Console.WriteLine(F);
            }

            Console.WriteLine("Display:");
            for(int i=0;i<=f.Length-1;i++)
            {
                Console.WriteLine(f[i]);
            }
            Console.WriteLine("Display:");
            Console.WriteLine(string.Join("\n", f));
        }
    }
}
