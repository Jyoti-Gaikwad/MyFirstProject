using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.DoWhile
{
    class Area
    {
        static void Main(string[] args)
        {
            int choice, a, r, l, w, b, h;
            // double area = 0;
            char ch;
            do
            {
                Console.WriteLine("Enter the radius");
                r = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the length");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the width");
                w = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the breadth");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the height");
                h = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the side");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1.Area of Rectangle\n2.Area of Circle\n3.Area of Triangle\n4.Area of Square");

                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Area of Rectangle:" + (l * w));
                        break;

                    case 2:
                        Console.WriteLine("Area of Circle:" + (3.14 * r * r));
                        break;


                    case 3:
                        Console.WriteLine("Area of Triangle:" + (0.5 * b * h));
                        break;


                    case 4:
                        Console.WriteLine("Area of Square:" + (a * a));

                        break;
                }
                Console.WriteLine("Do you want to continue.....");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y' || ch == 'Y');


        }
        }
        }

    

