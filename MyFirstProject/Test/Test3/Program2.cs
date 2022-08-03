using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors:");

            for (int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    
                    Console.WriteLine(i);
                }
            }
        }
    }
}
