using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    class StaticConstructor
    {
       static StaticConstructor()   //we cannot create parameterized constructor as a static constructor
        {
            Console.WriteLine("Hiii...!");

        }
        static void Main(string[] args)
        {
            StaticConstructor s = new StaticConstructor();
        }
    }
}
