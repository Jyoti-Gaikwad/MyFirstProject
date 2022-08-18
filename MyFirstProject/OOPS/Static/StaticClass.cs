using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    static class StaticClass //static class must contain static variable,static method,static constructor
    {
        // int x=10;   //Error
        static int x = 10;
        static StaticClass()
        {
            Console.WriteLine("Static class");

        }
        static void Main(string[] args)
        {
            //we Cannot create an instance of static class
            Console.WriteLine(x);
        }
    }
}
