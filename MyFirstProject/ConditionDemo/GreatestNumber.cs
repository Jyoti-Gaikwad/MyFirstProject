using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First Number is greater");
                }
                else
                {
                    Console.WriteLine("Third Number is greater");
                }
            }

            else if (num2 > num3)
            {
                Console.WriteLine("Second number is greater");
            }
            else
            {
                Console.WriteLine("Third Number is greater");
            }


           

            
        }
    }
}




