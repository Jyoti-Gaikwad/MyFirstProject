using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BreakContinue
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int reverse = 0;
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);
            if(temp==reverse)
            {
                Console.WriteLine("\nNumber is Palindrome");
            }
            else
            {
                Console.WriteLine("\nNumber is not pallindrome");
            }
        }
    }
}
