﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{
    class Sum2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n!=0)
            {
                if(n<0)
                {
                    sum = sum + n;
                }
                else
                {
                    Console.WriteLine(n);
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sum=" + sum);
        }
    }
}
