using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program6
    {

        static void Main(string[] args)
        {
            int n = 1;
            for (int i=1;i<=4;i++)
            {
                for(int k=5;k>i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=n;j++)
                {
                    Console.Write(i);
                }
                n = n + 2;
                Console.WriteLine();
            }
        }
    }
}
