using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent:");
            int y = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            for(int i=1;i<=y;i++)
            {
                power = power * x;
            }
            Console.WriteLine("x^y: "+power);
        }
    }
}
