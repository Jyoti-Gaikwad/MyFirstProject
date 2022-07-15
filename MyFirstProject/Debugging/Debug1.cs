using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Debugging
{
    class Debug1
    {
        static void Main(String[] args)
        {

            for(int i=0;i<=10;i++)
            {
                if (i == 7)
                    break;
                    Console.WriteLine(i);
            }
        }
    }
}
