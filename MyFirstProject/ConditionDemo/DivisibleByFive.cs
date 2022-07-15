using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class DivisibleByFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 5 == 0)
            {
                Console.WriteLine(n + "\t The number is divisible by 5");
            }
            else
            {
                Console.WriteLine(n + "\t The number is not divisible by 5");
            }
        }

    }
}
