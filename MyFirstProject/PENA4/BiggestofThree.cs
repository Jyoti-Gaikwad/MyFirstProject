using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class BiggestofThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num > num1 && num > num2)
            {

                Console.WriteLine("Biggest Number:" + num);
            }
            else if(num1>num2)
            {
                Console.WriteLine("Biggest Number:" + num1);
            }
            
            else 
            {
                Console.WriteLine("Biggest Number:" + num2);
            }
            
        }
    }
}
