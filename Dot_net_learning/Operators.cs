using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class Operators
    {
        static void Main()
        {
            //Console.WriteLine("Test");       //first line
            //Console.WriteLine("Test1");     //second line
            //Console.Write("Test2");         //third line
            //Console.Write("Test3");         //third line

            Console.WriteLine("------Operators-------");
            //variable declation
            int a = 10;
            int b = 20;


            //Arithmetic operators
            Console.WriteLine("-----Arithmetic operators------------>");
            Console.WriteLine($"Addition: {a+b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a%b}");

            //Comparioson / Relational operators
            Console.WriteLine("-----Comparisons / Relational operators------------>");
            Console.WriteLine($"a==b: {a==b}");
            Console.WriteLine($"a!=b: {a!=b}");
            Console.WriteLine($"a>b: {a>b}");
            Console.WriteLine($"a<b: {a<b}");
            Console.WriteLine($"a>=b: {a>=b}");
            Console.WriteLine($"a<=b: {a<=b}");

            //Logical operators
            Console.WriteLine("-----Logical operators------------>");
            bool x = true;
            bool y = false;
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}, !y: {!y}");

        }
    }
}
