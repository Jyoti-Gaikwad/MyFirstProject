using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    //Static variable can accessible anywhere
    class StaticVariable2
    {
        static int x = 0;

        StaticVariable2()
        {
            x++;
            Console.WriteLine(x);
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticVariable2 s = new StaticVariable2();
            StaticVariable2 s1 = new StaticVariable2();
            StaticVariable2 s2 = new StaticVariable2();

            s.display();
            
        }
    }
}
