using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Class_And_Object
{
    class Animal
    {
        public int leg_number;
        public string animal_name;
        public string food_type;

        static void Main(string[] args)
        {
            Animal tiger = new Animal();
            tiger.animal_name = "Lion";
            tiger.leg_number = 4;
            tiger.food_type = "Carnivores";

            Console.WriteLine("Animal Name: "+tiger.animal_name + "\nFood Type: " + tiger.food_type
                + "\nNumber of legs: " + tiger.leg_number+"\n");

            Animal cow = new Animal();
            cow.animal_name = "cow";
            cow.leg_number = 4;
            cow.food_type = "Herbivores";

            Console.WriteLine("Animal Name: " + cow.animal_name + "\nFood Type: " + cow.food_type
               + "\nNumber of legs: " + cow.leg_number);



        }
    }
       
}
