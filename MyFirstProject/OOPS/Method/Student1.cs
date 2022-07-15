using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class Student1
    {
        int id;
        string name;
        double m1, m2, m3;

        public void AcceptDetails(int sid,string sname,double M1,double M2,double M3)
        {
            id = sid;
            name = sname;
            m1 = M1;
            m2 = M2;
            m3 = M3;
        }

        public float CalculatePercentage()
        {
           
            double per=(80 + 75 + 90) / 3;
            return (float)per;
        }
        public void display()
        {
            Console.WriteLine(id + "\n" + name + "\n" + m1 + "\n" + m2 + "\n" + m3);
        }
        static void Main(string[] args)
        {
            Student1 s = new Student1();
            s.AcceptDetails(1, "Akash", 80, 75, 90);
            s.display();
            double per = s.CalculatePercentage();
            Console.WriteLine("Percentage=" + per);

        }
    }
}
