
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class CountOdd
    {
        static void Main(string[] args)
        {
            int Count = 0;
            int i;

            for(i=1;i<=10;i++)
            {
                if(i%2!=0)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
    }
}
