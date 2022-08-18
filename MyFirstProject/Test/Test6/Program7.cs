using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test6
{
    
        class SubEngine
        {
            string subenginetype;
            public SubEngine(string se)
            {
                this.subenginetype = se;
            }
            public void show2()
            {
                Console.WriteLine("Sub Engine Type: " + subenginetype);
            }
        }
        class Engine
        {
            int engineid;
            int lastenginecleandate;
            SubEngine SE;

            public Engine(int Eid,int date,SubEngine s)
            {
                this.engineid = Eid;
                this.lastenginecleandate = date;
                this.SE = s;
            }
            public void show()
            {
                Console.WriteLine("Engine Id: " + engineid);
                Console.WriteLine("Last Engine Date: " + lastenginecleandate);
                SE.show2();
            }
        }
        class Gear
        {
            string GearType;
            public Gear(string g)
            {
                this.GearType = g;
            }
            public void show1()
            {
                Console.WriteLine("Gear Type: " + GearType);
            }
        }
        class Car
        {
            int carid;
            string carcolor;
            
            Engine En;
            Gear g;

            public Car(int cid, string cc,Engine e,Gear g)
            {
                this.carid = cid;
                this.carcolor = cc;
                this.En = e;
                this.g= g;

            }
            public void display()
            {
                Console.WriteLine("Car Id:" + carid + "\nCar Color:" + carcolor);
                En.show();
                g.show1();
            }

            static void Main(string[] args)
            {
                SubEngine S = new SubEngine("Petrol");
                Engine E1 = new Engine(101,1-2-2022,S);
                Gear G = new Gear("Auto Manual");
                Car c = new Car(206, "White",E1,G);
                c.display();


            }



        }
    }



