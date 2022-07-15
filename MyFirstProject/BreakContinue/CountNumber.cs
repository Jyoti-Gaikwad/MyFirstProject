using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BreakContinue
{
    class CountNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int Count = 0;
            while (num>0)
            {
                num = num / 10;
                Count++;
            }
            Console.WriteLine("count:" + Count);
        }
    }
}
