using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class SubjectPercentage
    {
        static void Main()
        {
            float Total, Per;

            Console.WriteLine("Enter the marks of first subject");
            float first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of second subject");
            float second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of third subject");
            float third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of fourth subject");
            float fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of fifth subject");
            float fifth = Convert.ToInt32(Console.ReadLine());

            Total = first + second + third + fourth + fifth;
            Per = Total / 5;
            Console.WriteLine("Percentage:" + Per);

            if(Per>70)
            {
                Console.WriteLine("Distinction");
            }
            else if(Per>=60 && Per<=70)
            {
                Console.WriteLine("First Class");
            }
            else if(Per>=50 && Per<=60)
            {
                Console.WriteLine("Second Class");
            }
            else if(Per>=35 && Per<=50)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
