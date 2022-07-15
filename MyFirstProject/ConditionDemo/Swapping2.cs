using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class Swapping2
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Swapping a=" + a + "\tb=" + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swapping a=" + a + "\tb=" + b);
        }
    }
}
