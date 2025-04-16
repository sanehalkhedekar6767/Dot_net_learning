using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Static polymorphism/ compile time polymorphism/ early binding/ method overloading
    //method name same and class name also same but different parameters/ arguments.
    class BasicOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

    }
    internal class StaticPolymorphism
    {

        static void Main()
        {
            BasicOperations basic = new BasicOperations();
            //calling the overload method
            int sum1 = basic.Add(1, 2);
            Console.WriteLine("Sum of integer value is: "+sum1);
            double sum2 = basic.Add(3.2, 4.6);
            Console.WriteLine("Sum of double value is: " + sum2);


        }
    }
}
