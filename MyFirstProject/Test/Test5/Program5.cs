using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.India\n2.China\n3.Bangladesh\n4.Itly\n5.United State\n6.Exit");
            Console.WriteLine("\nInput your choice:");
        
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
             case 1:Console.WriteLine("Hocky");
             break;
                case 2:
                    Console.WriteLine("Table Tennis");
                    break;
                case 3:
                    Console.WriteLine("Kabbadi");
                    break;
                case 4:
                    Console.WriteLine("Football");
                    break;
                case 5:
                    Console.WriteLine("Baseball");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        }
    }
}
