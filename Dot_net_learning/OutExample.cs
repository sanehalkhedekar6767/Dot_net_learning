using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class OutExample
    {
        static void Main()
        {
            //OUT
            //not necessary to initialize parameters
            //declare variable in out
            int result1 = 10;
            int result2, result3, result4;
            int x = 50, y = 10;

            //call method with out parameter
            BasicOperations(x, y, out result1, out result2, out result3, out result4);

            //display information
            Console.WriteLine("Addition is: " + result1);
            Console.WriteLine("Subtraction is: " + result2);
            Console.WriteLine("Multiplication is: " + result3);
            Console.WriteLine("Division is: " + result4);

    }
        private static void BasicOperations(int x, int y, out int Addition, out int Subtraction, out int Multiplication, out int Division)
        {
            //Addition = x + y;
            //Addition = 25;
            Addition = y + x;
            Subtraction = x - y;
            Multiplication = x * y;
            Division = x / y;
        }
    }
}
