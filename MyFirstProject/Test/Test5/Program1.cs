using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test5
{
    class Program1
    {
        public Program1()
        {
            Console.WriteLine("Default Constructor");
        }
        public Program1(int x)
        {
            
            Console.WriteLine("X=" + x);
            
        }
        public Program1(int x,int y) : this(20)
        {
            
         
            Console.WriteLine("Multiplication:"+(x * y));
        }
        static void Main(string[] args)
        {
            Program1 p = new Program1(10);
            Program1 p1 = new Program1();
            Program1 p2 = new Program1(10, 20);
        }
    }
}

