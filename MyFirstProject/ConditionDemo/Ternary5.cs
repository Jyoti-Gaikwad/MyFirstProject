using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class Ternary5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            string result = num1 > num2 && num1 > num3 ? "num1 is greater" : num2 > num1 && num2 > num3 ? "num2 is greater" : "num3 is greater";
            Console.WriteLine(result);

        }
    }
}
