using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern
{
    class NestedLoop1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
