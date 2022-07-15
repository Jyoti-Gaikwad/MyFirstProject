using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Pattern.PatternUsingAlphabet
{
    class PatternA2
    {
        static void Main(string[] args)
        {
            char i, j;
            for(i='A';i<='D';i++)
            {
                for(j='D';j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
}
