using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Class_And_Object
{
    class Vehicle2
    {
        
        int modelNo;
        string TypeOfVehicle;
        int NoOfWheels;
        int avg;



        public void AcceptDetails(int mn, string vt, int nw)
        {
            modelNo = mn;
            TypeOfVehicle = vt;
            NoOfWheels = nw;

        }
        public void SetAverage(string TypeOfVehicle)
        {
            if (TypeOfVehicle == "TwoWheeler")
            {
                avg = 15;
            }
            else if (TypeOfVehicle == "ThreeWheeler")
            {
                avg = 12;
            }
            else if (TypeOfVehicle == "FourWheeler")
            {
                avg = 17;
            }
            else 
            {
                avg = 20;
            }

        }
        public void Display()
        {
            Console.WriteLine(modelNo + "\t" + TypeOfVehicle + "\t" + NoOfWheels + "\t" + avg);
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.SetAverage(3);
            v.AcceptDetails(1, "Two Wheeler", 2);
            v.Display();


        }
    }
}
