using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program1
    {
        static void Main(string[] args)
        {
            float a, area;
            a = 5;
            area = (float)(1.73 * a * a / 4);
            Console.WriteLine("Area of equilateral triangle is:" + area);
        }
    }
}
