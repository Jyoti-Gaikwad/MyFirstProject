using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class MethodOverload
    {
         int calculate(int a, int b)
        {
            
          return a+b;
        }

        int calculate(int a,float b )
        {
            return a - (int)b;
        }

        int calculate(float a,int b)
        {
            return (int)a * b;
        }
        float calculate(float a,float b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            MethodOverload m = new MethodOverload();
            
            Console.WriteLine("Addition:" + m.calculate(2, 3));
            Console.WriteLine("Subtraction:"+m.calculate(4, 6f));
           Console.WriteLine("Multiplication:" +m.calculate(3f, 7));
            Console.WriteLine("Division:"+m.calculate(6f, 5f));
        }

    }
}
