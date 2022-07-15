using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BreakContinue
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int magic_number = 56;
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > magic_number)
                {
                    Console.WriteLine("The number is greater than the magic number...plz try again");

                    continue;
                }
                else if (num < magic_number)
                {
                    Console.WriteLine("The number is less than the magic number...plz try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("You guess Correct");
                    break;
                }
            }

        }
    }
}
