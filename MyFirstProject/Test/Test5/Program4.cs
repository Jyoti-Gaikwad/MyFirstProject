using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test5
{
    class Program4
    {
        static void Main(string[] args)
        {
            int i, j, k, l=1;
            for(i=1; i<=4;i++)
            {
                for(j=4;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(k=1;k<=l;k++)
                {
                    Console.Write(k);
                }
                l = l + 2;
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
