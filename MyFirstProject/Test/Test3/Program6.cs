﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program6
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=100;i++)
            {
                if(3%i==0&&5%i==0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(3%i==0)
                {
                    Console.WriteLine("Red");
                }
                else if(5%i==0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
