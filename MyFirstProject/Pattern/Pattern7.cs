using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)

                    Console.Write(j.ToString());
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
