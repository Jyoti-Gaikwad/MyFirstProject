﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PracticePattern
{
    class Pattern12
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j==1||i==1||j==5||i==5)
                    {
                        Console.Write("*");
                    }
                    else 
                    { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
