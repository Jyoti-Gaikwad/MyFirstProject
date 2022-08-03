using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n    = num;

            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
          //  Console.WriteLine(sum);

                if (n % sum == 0)
                {
                    Console.WriteLine("Number is Harshad number");
                }

                else
                {
                    Console.WriteLine("Number is not Harshad Number");
                }
            
            
        }
    }
}
