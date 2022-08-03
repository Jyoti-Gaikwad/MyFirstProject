using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopTest
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int check = 0;
            for(int i=2;i<num1;i++)
            {
                for(int j=2;j<num2;j++)
                {
                    if(num1%i==0||num2%j==0)
                    {
                        check = 1;
                    }
                }
            }
            if(check==0)
            {
                if(num1-num2==2||num2-num1==2)
                {
                    Console.WriteLine("Twin Prime");
                }
                else
                {
                    Console.WriteLine("Not Twin Prime");
                }
            }    
        }
    }
}
