using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern
{
    class Pattern9
    {
        static void Main(string[] args)
        {
            int i, j, k = 0;
            for (i = 4; i >= 1; i--)
            {
                for (j = 4 ; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }
}
