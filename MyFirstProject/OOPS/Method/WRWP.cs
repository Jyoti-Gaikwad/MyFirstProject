using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class WRWP
    {
        public float AreaOfCircle(int r)
        {
            float pi = 3.14f;
            return (pi * r * r);
        }
        static void Main(string[] args)
        {
            WRWP w = new WRWP();
            float Area = w.AreaOfCircle(4);
            Console.WriteLine("Area of circle=" + Area);
        }
    }

}
