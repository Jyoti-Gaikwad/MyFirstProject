using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c=0;
          
            Console.WriteLine("Before swap a=" + a +"\t b=" + b);

            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swap a=" + a+"\t b=" + b);
        }
    }
}
