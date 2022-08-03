using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PracticePattern
{
    class Pattern11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i==4||j==1||i==j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
