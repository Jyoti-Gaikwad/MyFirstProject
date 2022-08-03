using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Encapsulation
{
    class Employee
    {
        int id;
        private string name;
        private double salary;

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
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    } 

        class EmpInfo
        {
            static void Main(string[] args)
            {
                Employee e = new Employee();
                e.ID = 101;
                e.Name = "Jyoti";
                e.Salary = 80000;
                int eid = e.ID;
                Console.WriteLine("Employee Id:"+eid);
                string ename = e.Name;
                Console.WriteLine("Employee Name:"+ename);
                double esalary = e.Salary;
                Console.WriteLine("Employee Salary:"+esalary);
            }
        }
    
}
