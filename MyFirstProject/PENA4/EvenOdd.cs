using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numberb:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
