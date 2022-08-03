using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            int fact;
            while (temp!=0)
            {
                int r = temp % 10;
                fact = 1;
                for (int i = 1; i <= r; i++)
                {
                    
                    fact = i*fact;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
            if(sum==num)
            {
                Console.WriteLine("Krishnmurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnmurthy Number");
            }
        }
    }
}
