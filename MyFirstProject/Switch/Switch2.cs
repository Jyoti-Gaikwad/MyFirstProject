using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Switch
{
    class Switch2
    {
        static void Main(string[] args)
        {
            char ch = 'a';
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;
            }
        }
    }
}
