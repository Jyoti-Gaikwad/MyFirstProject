using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Switch
{
    class switchDemo
    {
        static void Main(string[] args)
        {
            char ch = 't';
            switch(ch)
            {
                case 'a': Console.WriteLine("Vowel");
                break;

                case 'e': Console.WriteLine("Vowel");
                    break;

                case 'i':
                    Console.WriteLine("Vowel");
                    break;

                case 'o':
                    Console.WriteLine("Vowel");
                    break;

                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                case 'A':
                    Console.WriteLine("Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Vowel");
                    break;

                default:Console.WriteLine("Consonent");
                    break;
            }
        }
    }
}
