using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Encapsulation
{
    class Student4
    {
        private int id;
        private string name;
        private float percentage;
        private bool placement;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public bool Placement
        {
            get { return placement; }
            set { placement = value; }
        }
    }
        class StudentInfo
        {
            static void Main(string[] args)
            {
                Student4 s = new Student4();
                s.ID = 101;
                s.Name = "Jyoti";
                s.Percentage = 50000;
                s.Placement = true;
                Console.WriteLine("Student id:"+s.ID + "\n" +"Student Name:"+ s.Name + "\n"+"Student Percentage:" + s.Percentage + "\n"+"Placement:" + s.Placement);
            }
        }
    
}
