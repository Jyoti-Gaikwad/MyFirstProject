using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Contentment
{
    class Department
    {


        public int id;
        public string name;

        public Department(int id, string n)
        {
            this.id = id;
            this.name = n;
        }

        public void show()
        {
            Console.WriteLine(" " + id + " " + name);
        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department dept;

        public Employee(int id, string n, int s, Department d)
        {
            this.id = id;
            this.name = n;
            this.salary = s;
            this.dept = d;
        }
         void display()
        {
            Console.WriteLine(" " + id + " " + name + " " + salary);
            dept.show();
        }

        static void Main(string[] args)
        {
            Department d = new Department(301, "BCA department");
            Employee E = new Employee(1, "Jyoti", 18000, d);
            E.display();

        }
    }
}
