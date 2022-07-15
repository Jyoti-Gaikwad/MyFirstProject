using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Datatype
    {
        static void Main(String[] args)
        {
            byte b = 56;
            sbyte sb = -45;
            Console.WriteLine(b + "\n" + sb);

            short sv = 234;
            short sv2 = -785;
            Console.WriteLine(sv+ "\n" + sv2);

            int n = 4566;
            int n1 = -6543;
            Console.WriteLine(n+ "\n" + n1);

            long l = 23847659074327;
            long l2 = -374632858935837;
            Console.WriteLine(l + "\n" + l2);

            double d = 87.56;
            Console.WriteLine(""+ d);

            float f = 67.56f;
            Console.WriteLine("" +f);

            char ch = 'J';
            char ch1 = '*';
            Console.WriteLine(ch + "\n" + ch1);

            bool isvalue = true;
            string name = "Jyoti";
            Console.WriteLine(isvalue + "\n" + name);


        }
    }
}
