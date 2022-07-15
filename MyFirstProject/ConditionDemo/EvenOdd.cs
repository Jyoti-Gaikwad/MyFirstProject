using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine(+num1+ "\tThe number is even");
            }
            else
            {
                Console.WriteLine(num1+ "\tThe number is odd");
            }

        }
    }
}
