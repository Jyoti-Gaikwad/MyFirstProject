using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class LadderIfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Alphabet");

            }
            else if (ch >= 'a' && ch <= 'z') 
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' && ch <= '9') 
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Symbol");
            }
        }
    }
}
