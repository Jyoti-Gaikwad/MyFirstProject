using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PracticePattern
{
    class Pattern19
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    if (i == 2 || i == 4)
                    {
                        Console.Write("A");
                    }
                }
                Console.WriteLine();
            }    
        }
    }
}
