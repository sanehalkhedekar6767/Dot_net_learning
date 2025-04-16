using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Dynamic Polymorphism/ Runtime Polymorphism/ Late Binding/ Overriding
    //same method name, parameter also same but different classes and we follow parent child relationship

    //Base class - Parent class
    class Shape
    {
        //virtual keyword added to method to override in BASE CLASS
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

    }
    //Derived class
    class Circle : Shape
    {
        //override keyword added to method in DERIVED CLASS
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }

    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }




    internal class DynamicPolymorphism
    {
        static void Main()
        {
            Shape shape = new Shape();
            Shape circle = new Circle();
            Shape rect = new Rectangle();

            //calling method
            shape.Draw();
            circle.Draw();
            rect.Draw();

        }
    }
}
