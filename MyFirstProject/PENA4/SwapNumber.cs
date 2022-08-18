using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class SwapNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Before swap a= " + num + " b= " + num1);
            num = num * num1;       
            num1 = num / num1;    
            num = num / num1;  
            Console.Write("After swap a= " + num + " b= " + num1);
        }
    }
}
