using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    class StaticVariable
    {
        static int x = 0;
         
        StaticVariable()
        {
            x++;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticVariable s = new StaticVariable();
            StaticVariable s1= new StaticVariable();
            StaticVariable s2= new StaticVariable();
        }
    }
}
