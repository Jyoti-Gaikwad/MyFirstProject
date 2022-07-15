using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BreakContinue
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while(num>0)
            {
                int r = num%10;
                sum = sum + r;
                num = num / 10;
            }
            Console.WriteLine("Sum:" + sum);
        }
    }
}
