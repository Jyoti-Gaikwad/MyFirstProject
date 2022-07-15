using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Switch
{
    class Switch3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition \n2.Substraction \n3.Multiplication\n4.Division");

            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("Addition=" + (num1 + num2));
            break;
                case 2:
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }
}
