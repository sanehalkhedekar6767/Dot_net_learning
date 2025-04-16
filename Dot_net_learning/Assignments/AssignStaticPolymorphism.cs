using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    class Calculator
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is: {a + b}");
            Console.WriteLine($"Sub of {a} and {b} is: {a - b}");
            Console.WriteLine($"Mul of {a} and {b} is: {a * b}");
            Console.WriteLine($"Div of {a} and {b} is: {a / b}");
            Console.WriteLine();
        }
        public void calculate(double a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} is: {a + b}");
            Console.WriteLine($"Sub of {a} and {b} is: {a - b}");
            Console.WriteLine($"Mul of {a} and {b} is: {a * b}");
            Console.WriteLine($"Div of {a} and {b} is: {a / b}");
        }
    }
    internal class AssignStaticPolymorphism
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.calculate(4, 2);
            calc.calculate(6.2, 2);
        }
    }
}
