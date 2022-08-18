using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{
    class UserInput
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
               Console.WriteLine("Enter the input:");
                int n = Convert.ToInt32(Console.ReadLine());

               
                    if (n == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(n);
                }
               

            }
            }
            
        }
    }

