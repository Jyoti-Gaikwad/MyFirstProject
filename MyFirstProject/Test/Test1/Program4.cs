using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year%4==0)
            {
                Console.WriteLine("Year is leap year");
            }
            else
            {
                Console.WriteLine("Year is not leap year");
            }
        }
    }
}
