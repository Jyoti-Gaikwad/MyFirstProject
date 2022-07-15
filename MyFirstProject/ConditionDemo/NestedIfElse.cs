using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class NestedIfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Weight");
            int wt = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                if (wt > 50)
                {
                    Console.WriteLine("Person is valid for blood donation");
                }
                else
                {
                    Console.WriteLine("Person age is valid for blood donation but not weight, Try next time...");
                }
            }
            else
            {
                Console.WriteLine("Person is not valid for blood donation, Try Next Time...");
            }
            }
        }
    }

