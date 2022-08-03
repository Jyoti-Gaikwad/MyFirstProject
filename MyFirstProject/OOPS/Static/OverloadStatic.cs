using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    class OverloadStatic
    {
        static float area(float r)
        {
            return (float)3.14 * r * r;
        }

        static int area(int l,int b)
        {
            return l * b;
        }
          static float area(int b, float h)
        {
            return (float)0.5 * b * h;
        }
        static int area(int s)
        {
            return s * s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Area of circle: "+area(2.5f));
            Console.WriteLine("Area of Reactangle:"+area(6, 8));
            Console.WriteLine("Area of rectangle:"+area(2, 3f));
            Console.WriteLine("Area of Square:"+area(4));
        }

    }
}
