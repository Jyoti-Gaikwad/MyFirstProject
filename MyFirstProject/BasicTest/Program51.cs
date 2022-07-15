using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicTest
{
    class Program51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("The number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5 and 11");
            }
        }
    }
}
