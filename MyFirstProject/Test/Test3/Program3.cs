﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }
}
