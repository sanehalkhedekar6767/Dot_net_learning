using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{

    //Base class
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started");
        }
    }

    //Derived class
    class Car: Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }

    class Truck: Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started");
        }
    }




    internal class AssignDynamicPolymorphism
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle truck = new Truck();

            //calling methods
            vehicle.StartEngine();
            car.StartEngine();
            truck.StartEngine();


        }
    }
}
