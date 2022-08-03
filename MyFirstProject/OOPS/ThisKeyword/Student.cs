using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.ThisKeyword
{
    class Student
    {
        int Rollno;
        string Name;
        string Address;
        double Percentage;
        float CGPA;

        Student(int Rollno,string Name,string Address,double Percentage)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.Address = Address;
            this.Percentage = Percentage;
        }
        Student():this(1,"Jyoti","Shirur",83.55)
        {
            CGPA = (float)(Percentage / 9.5);
            this.Display();
        }
        void Display()
        {
            Console.WriteLine("Roll Number:" + Rollno);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("Percentage:" + Percentage);
            Console.WriteLine("CGPA:" + CGPA);
        }

        static void Main(string[] args)
        {
            Student s = new Student();
        }
    }


}
