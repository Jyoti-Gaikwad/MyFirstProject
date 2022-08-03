using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program15
    {
       
        static void Main(string[] args)
        {
            int i, n, fact = 1;
            float sum = 0,term;

            Console.WriteLine("Enter the range");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact *= i;
                term = 1 / fact;
                sum += fact;
            }

            Console.WriteLine("" + sum);


        }
    }
}
