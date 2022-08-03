using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program42
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for(int k=i;k<5; k++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j % 2);

                }

                Console.WriteLine();

            }
        }
    }
}
