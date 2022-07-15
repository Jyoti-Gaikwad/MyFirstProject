using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class NRWP
    {
        public void Addition(int x,float y)
        {
            float result = x + y;
            Console.WriteLine("Result=" + result);
        }
        static void Main(string[] args)
        {
            NRWP n1 = new NRWP();
            n1.Addition(5, 4.9f);
        }
    }
}
