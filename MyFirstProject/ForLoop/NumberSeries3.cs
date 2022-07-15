using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class NumberSeries3
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i + " ");
                }
                else
                {
                    Console.WriteLine(i + "");
                }
            }
        }
    }
}
