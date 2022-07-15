using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter the first number:" );
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
             num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine(num1 + "\t is greater number");

            }
            else
            {
                Console.WriteLine(num2 + "\t is greater number");
            }


        }
    }
}
