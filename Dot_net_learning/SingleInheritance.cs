using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{

    //Base Class or parent class or super class
    class Vehicle
    {
        public string Brand { get; set; }
        public void Drive()
        {

            Console.WriteLine($"{Brand} is driving");

        }
    }

        //child class or derived class or sub class
        class Car : Vehicle
        {
            public int NumberOfDoor { get; set; }

            public void ShowCarInfo()
            {
                Console.WriteLine($"Brand: {Brand} and Number of Doors: {NumberOfDoor}");
            }


        }



        internal class SingleInheritance
        {
            static void Main()
            {
                Car myCar = new Car();
            myCar.Brand = "BMW";
            myCar.NumberOfDoor = 4;
            myCar.Drive();
            myCar.ShowCarInfo();

        }
        }
    }
