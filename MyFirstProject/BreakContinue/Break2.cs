using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BreakContinue
{
    class Break2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
