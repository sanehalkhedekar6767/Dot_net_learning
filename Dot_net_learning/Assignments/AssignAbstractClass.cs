using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{

    //abstract class
    public abstract class Shape
    {
        //abstract method
        public abstract double CalculateArea(double l, double w);

        //non-abstract method
        public void Display()
        {
            Console.WriteLine("Shape Type: ");
        }
    }

    //Derived class/ Concrete class
    class Rectangle : Shape
    {
        public override double CalculateArea(double l, double w)
        {
            Console.WriteLine($"Length: {l} \t Width: {w}");
            return l * w;
        }
        public void Display()
        {
            Console.WriteLine("Shape Type: Rectangle ");

        }
    }

    class Circle : Shape
    {
        public override double CalculateArea(double pi, double r)
        {
            Console.WriteLine($"Radius: {r}");

            return pi * r * r;
        }
        public void Display()
        {
            Console.WriteLine("Shape Type: Circle");
        }
    }

    internal class AssignAbstractClass
    {
        static void Main()
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();

            //calling mehtods
            rec.Display();
            double recArea = rec.CalculateArea(4,3);
            Console.WriteLine($"Area is: {recArea}");
            Console.WriteLine();

            circle.Display();
            double circleArea = circle.CalculateArea(3.14,2);
            Console.WriteLine($"Area is: {circleArea}");

        }

    }
}
