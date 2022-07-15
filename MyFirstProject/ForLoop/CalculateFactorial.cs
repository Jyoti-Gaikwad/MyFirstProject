using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class CalculateFactorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
