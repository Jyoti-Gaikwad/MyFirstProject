using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern
{
    class Pattern8
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <=4 ; k++)
                {
                    Console.Write("");
                   
                }
                for(int j=4;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }
}

