using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class TableOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int table = 1;
            for(int i=1;i<=10;i++)
            {
                table = i * num;
                Console.WriteLine(table);
            }
            
        }
    }
}
