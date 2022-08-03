using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Numbers1_100
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
