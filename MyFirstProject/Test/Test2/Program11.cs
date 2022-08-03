using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program11
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.Write(2);
            for (int i=2;i<=num;i++)
            {
                result = (i * i) + (i * i * i);
                Console.Write("\t" + result);
            }
        }
    }
}
