using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.AccessModifier
{
    class AccessModifier1
    {
        private int x = 10;
        internal int y = 30;
        protected string name = "Pune";
        public int z = 80;

        static void Main(string[] args)
        {
            AccessModifier1 d = new AccessModifier1();
            Console.WriteLine(d.x);
            Console.WriteLine(d.y);
            Console.WriteLine(d.name);
            Console.WriteLine(d.z);

        }

    }
}

