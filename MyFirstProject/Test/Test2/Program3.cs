using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program3
    {
        static void Main(String[] args)
        {
            int i = 1;int K = 1;
            while(i++<=5)
            {
                K *= i;
            }
            Console.WriteLine("k=" + K + "\ni=" + i);
        }
    }
}
