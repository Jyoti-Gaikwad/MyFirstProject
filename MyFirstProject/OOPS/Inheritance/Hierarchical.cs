using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Inheritance
{
    class Student
    {
        internal int Rollno=8401;
      
        
    }
    class FirstClass:Student
    {
        internal string name;
        internal float percentage;
        public void show(string n,float p)
        {
            percentage = p;
            name = n;
        }
    }
    class SecondClass:Student
    {
        
        internal string name;
        internal float percentage;
        public void Show(string n,float p)
        {
            Rollno = 8402;
            name = n;
            percentage = p;
        }
    }
    class Hierarchical
    {
        static void Main(string[] args)
        {
            FirstClass f = new FirstClass();
            f.show("Jyoti", 83.55f);
            Console.WriteLine("Roll Number: "+f.Rollno+"\nName: "+f.name+"\nPercentage: "+f.percentage);

            SecondClass s = new SecondClass();
            s.Show("Shreya", 84.20f);
            Console.WriteLine("\nRoll Number: " + s.Rollno + "\nName: " + s.name + "\nPercentage: " + s.percentage);
        }

    }
}
