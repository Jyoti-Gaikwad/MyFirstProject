using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class Ternary3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());



            string ans = num % 2 == 0 ? "Number is Even" : "Number is odd";
            Console.WriteLine(ans);
        }
    }
}
