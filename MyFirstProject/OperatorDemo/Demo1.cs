using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OperatorDemo
{
    class Demo1
    {
        static void Main(String[] args)
        {
            int a = 2;
            int b = 2;

            int x = b++ + ++a - --a;
            Console.WriteLine(x + "" + a + "" + b);

            x = --b - ++a + b++;
            Console.WriteLine(x + "" + a + "" + b);

            x = a-- + b - ++a - --b;
            Console.WriteLine(x + "" + a + "" + b);

        }
    }
}
