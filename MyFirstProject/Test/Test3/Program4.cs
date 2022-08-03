using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program4
    {
        static void Main(string[] args)
        {
            int Next, first = 0, second = 1;
            for(int i=1;i<=20;i++)
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
               
            }
        }
    }
}
