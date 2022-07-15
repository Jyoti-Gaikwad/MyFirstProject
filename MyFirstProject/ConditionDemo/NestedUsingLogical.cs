using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class NestedUsingLogical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Weight");
            int wt = Convert.ToInt32(Console.ReadLine());

            if(age>18 && wt>50)
            {
                Console.WriteLine("Person is valid for blood donation");
            }
            else
            {
                Console.WriteLine("Person is not valid for blood donation...Try next Time");
            }
        }
    }
}
