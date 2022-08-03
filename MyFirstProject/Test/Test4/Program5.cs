using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n th term:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * (i + 2) + "");
            }
        }
    }
}
