
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class Ternary4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            string ans = num > 0 ? "Positive Number" : num < 0 ? "Negative Number" : "Number is zero";
            Console.WriteLine(ans);
        }
    }
}
