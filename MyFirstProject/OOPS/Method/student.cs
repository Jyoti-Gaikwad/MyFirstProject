using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class Student
    {
        public int id;
        public string name;
        public double marks;

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 101;
            s1.name = "Jyoti";
            s1.marks = 89.67;
            Console.WriteLine(s1.id + "\n" + s1.name + "\n" + s1.marks);
        }
    }
}
