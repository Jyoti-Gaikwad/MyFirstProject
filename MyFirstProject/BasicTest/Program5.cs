using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0)
            {
                if (num % 11 == 0)
                {
                    Console.WriteLine("Number is divisible by 5 and 11");
                }
                else
                {
                    Console.WriteLine("Number is divisible by 5 but not by 11");
                }
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 and 11");
            }
            
        }
    }
}
