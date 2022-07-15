using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class Ternary2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            int num2 = Convert.ToInt32(Console.ReadLine());

           /* if(num1>num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }*/
            string ans = num1 > num2 ? num1+" is greater" : num2+" is greater";
            Console.WriteLine(ans);
        }
    }
}
