using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of Equilateral triangle");
            int a = Convert.ToInt32(Console.ReadLine());

            float area = (float)(1.73 * a * a / 4);
            Console.WriteLine("Area=" + area);
        }
    }
}
