using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Switch
{
    class Switch6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Odd \n2.Even");


            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("Odd\t" + (num % 2 != 0));
                    break;
                case 2: Console.WriteLine("Even\t" + (num % 2 == 0));
                    break;
            }
        }
    }
}
