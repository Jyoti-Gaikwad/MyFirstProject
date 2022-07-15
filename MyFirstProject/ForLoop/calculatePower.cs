using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class calculatePower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter exponent");
            int expo = Convert.ToInt32(Console.ReadLine());

            int power = 1;

            for(int i=1;i<=expo;i++)
            {
                power = power * b;
            }
            Console.WriteLine(power);
        }
    }
}
