using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int digit;
            int sum = 0;
            int product = 1;
            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                product = product * digit;
                num = num / 10;
            }

            if (sum == product)
            {
                Console.WriteLine("\nNumber is spy");
            }
            else
            {
                Console.WriteLine("\nNumber is not spy");
            }
        }
    }
}
