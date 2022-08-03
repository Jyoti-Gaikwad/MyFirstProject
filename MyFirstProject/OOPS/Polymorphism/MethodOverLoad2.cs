using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class MethodOverLoad2
    {
        float area(float r)
        {
            return (float)(3.14 * r * r);
        }

        float area(int h,int b)
        {
            return (float)(0.5 * h * b);
        }

        float area(int l,float w)
        {
            return l * w;
        }

        int area(int a)
        {
            return a * a;
        }

        static void Main(string[] args)
        {
            MethodOverLoad2 m1 = new MethodOverLoad2();
            Console.WriteLine("Area of circle:" + m1.area(4.2f));
            Console.WriteLine("Area of Triangle:" + m1.area(4,2));
            Console.WriteLine("Area of Rectangle:" + m1.area(4,5f));
            Console.WriteLine("Area of Square:" + m1.area(9));

        }
    }
}
