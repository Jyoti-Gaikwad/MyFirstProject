using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test5
{
    class Program6
    {
      
        public void DoTransaction(string a)
        {
            Console.WriteLine("You got 15% discount on bill on credit transaction.");
        }
        public void DoTransaction(char d)
        {
            Console.WriteLine("No discount on bill on debit card");
        }

    }
    class credit
    {
        static void Main(string[] args)
        {
            Program6 p = new Program6();
            p.DoTransaction("Credit card");
            p.DoTransaction('D');
        }
    }
}
