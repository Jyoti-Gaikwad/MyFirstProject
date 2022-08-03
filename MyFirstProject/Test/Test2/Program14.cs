using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program14
    {
        static void Main(string[] args)
        {
            int i = 0, Next, first = 0, second = 1;
            Console.WriteLine("Enter the range");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                if (i <= 1)
                {
                    Next = i;
                }
                else
                {
                    Next = first + second;
                    first = second;
                    second = Next;
                }
                Console.WriteLine("\t" + Next);
                i++;
            }
        }
    }
}
