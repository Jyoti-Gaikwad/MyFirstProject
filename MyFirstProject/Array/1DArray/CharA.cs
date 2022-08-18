using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class CharA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            char[] ch = new char[size];
            Console.WriteLine("Enter the character Elements:");

            for (int i = 0; i <= ch.Length-1; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Display:");
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }

        }
    }
}
