using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignOperators
    {

        static void Main()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");


            //Arithmetic operators
            Console.WriteLine("-----------Arithmetic Operators----------");
            Console.WriteLine($"Addition of {x} and {y} is: {x+y}");
            Console.WriteLine($"Subtraction of {x} and {y} is: {x - y}");
            Console.WriteLine($"Multiplication of {x} and {y} is: {x * y}");
            Console.WriteLine($"Division of {x} and {y} is: {x / y}");
            Console.WriteLine($"Modulus of {x} and {y} is: {x % y}");
            Console.WriteLine();

            //Relational operators
            Console.WriteLine("-----------Relational Operators----------");
            Console.WriteLine($"x==y: {x == y}");
            Console.WriteLine($"x!=y: {x != y}");
            Console.WriteLine($"x>y: {x > y}");
            Console.WriteLine($"x<y: {x < y}");
            Console.WriteLine($"x>=y: {x >= y}");
            Console.WriteLine($"x<=y: {x <= y}");





        }
    }
}
