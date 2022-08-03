using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.AccessModifier
{
    class AccessModifier2:AccessModifier1
    {
        static void Main(string[] args)
        {
            AccessModifier1 a = new AccessModifier1();
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);

            AccessModifier2 m = new AccessModifier2();
            Console.WriteLine(m.name);
            Console.WriteLine(m.y);
            Console.WriteLine(m.z);

        }
    }
}
