using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program4
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 5; i++)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    
    }
}
