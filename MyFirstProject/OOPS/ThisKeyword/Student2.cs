using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.ThisKeyword
{
    class Student2
    {
        int id;
        string name;
        float percentage;
        float grade;

        public void AcceptDetails(int sid, string Name, float per)
        {
            
                this.id = sid;
                this.name = Name;
                this.percentage = per;

                if(this.percentage<0)

            {
                Console.WriteLine("Error");
            }
            else
            {
                grade = this.FindGrade();
                this.display();
            }
            
        }
            public float FindGrade()
            {
            return (float)(percentage / 9.5);
            }
            public void display()
            {
            Console.WriteLine("Student Id:" + id);
            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student Percentage:" + percentage);
            Console.WriteLine("Grade:" + grade);

            }
        static void Main(string[] args)
        {
            Student2 s = new Student2();
            s.AcceptDetails(1, "Jyoti", 90);
        }
        
            
    }
}
