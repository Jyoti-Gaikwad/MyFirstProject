using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Abstraction
{
    interface Ifactorable
    {
        public int factor(int n);

    }
    class Factor : Ifactorable
    {
        public int factor(int n)
        {

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;

                }
            }
            return sum;
        }
    }
        class Interface
        {
            static void Main(string[] args)
            {
                Ifactorable f = new Factor();
                int ans=f.factor(5);
                Console.WriteLine("Sum of factors:" + ans);
            }
        }
    
}
