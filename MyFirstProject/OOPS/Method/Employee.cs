using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void AcceptDetails(int eid,string ename,int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }
        public void display()
        {
            Console.WriteLine(id + "\n" + name + "\n" + salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.AcceptDetails(1, "Jyoti", 80000);
            e.display();
        }
    }
}
