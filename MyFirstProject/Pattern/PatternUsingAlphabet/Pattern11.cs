using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern
{
    class Pattern11
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                if(i%2!=0)
                {
                    int c = 1;
                    for(char j='A';c<=i;j++)
                    {
                        Console.Write(j);
                        c++;
                    }
                }
                else
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
