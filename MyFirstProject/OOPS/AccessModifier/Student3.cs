using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.AccessModifier
{
    class Student3
    {
        private int RollNo;
        internal string Name;
        protected string address;
        public double m1, m2, m3;

        internal void AcceptDetails(int r,string n,string a, double M1, double M2, double M3)
        {
            RollNo = r;
            Name = n;
            address = a;
            m1 = M1;
            m2 = M2;
            m3 = M3;
        }
        public void Display()
        {
            Console.WriteLine("RollNo:" + RollNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("address:" + address);
            Console.WriteLine("marks:" + m1);
            Console.WriteLine("marks:" + m2);
            Console.WriteLine("marks:" + m3);
        }
        public void Delete()
        {
            address="";
        }

        public float CalculatePercentage()
        {

            double per = (80 + 75 + 90) / 3;
            return (float)per;
        }

        static void Main(string[] args)
        {
            Student3 s = new Student3();
            s.AcceptDetails(1, "Jyoti", "Shirur", 80,75,90);
           
            s.Display();
            double per = s.CalculatePercentage();
            Console.WriteLine("Percentage=" + per+"\n");
            s.Delete();
            s.Display();
            per = s.CalculatePercentage();
            Console.WriteLine("Percentage=" + per);
        }
    }
}
