using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program2
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }
}
