using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program2
    {
        static void Main(string[] args)
        {
            float Total, Per;

            Console.WriteLine("Enter the marks of first subject");
            float first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of second subject");
            float second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of third subject");
            float third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of fourth subject");
            float fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of fifth subject");
            float fifth = Convert.ToInt32(Console.ReadLine());

            Total = first + second + third + fourth + fifth;
            Per = Total / 5;
            Console.WriteLine("Total:" + Total);
            Console.WriteLine("Percentage:" + Per);

        }
    }
}
