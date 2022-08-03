using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.AccessModifier
{
    class Student4
    {
        static void Main(string[] args)
        {
            Student3 s = new Student3();
            s.AcceptDetails(1, "Jyoti", "Shirur", 80, 75, 90);

            s.Display();
            double per = s.CalculatePercentage();
            Console.WriteLine("Percentage=" + per + "\n");
            s.Delete();
            s.Display();
            per = s.CalculatePercentage();
            Console.WriteLine("Percentage=" + per);
        }
    }
}
