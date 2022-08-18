using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Inheritance
{
    class Department
    {
        internal int id=101;
        internal string name="BCA Department";
        
    }
    class BCA:Department
    {
        public void show()
        {
            Console.WriteLine("Department Id: " + id + "\nDepartment Name: " + name);
        }
    }
    class SingleInheritance
    {
        static void Main(string[] args)
        {
        BCA b = new BCA();
        b.show();
       }
    }
}
