using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{

    class A //Base class
    {
        public void start()
        {
            Console.WriteLine("Vehicle Started");

        }

    }

    class B : A //Derived class and Base class
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }

    }   

    class C : B //Derived class
    {
        public void TroubleShoot()
        {
            Console.WriteLine("The sport is in another mode");
        }

    }

    internal class MultilevelInheritance
    {
        static void Main()
        {

            C c = new C(); //Creating object of derived class
            c.start(); //Calling method of base class
            c.Drive(); //Calling method of derived class
            c.TroubleShoot(); //Calling method of derived class
        }
    }
}
