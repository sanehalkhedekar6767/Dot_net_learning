using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignControlStatements
    {
        static void Main()
        {

            Console.WriteLine("----------Basic Conditions-------------");
            int num;
            Console.Write("Enter the value: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive");

            }
            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");

            }
            else
            {
                Console.WriteLine("Number is Zero");

            }
            Console.WriteLine();
            Console.WriteLine("----------Grade Calculator-------------");
            Console.Write("Enter the marks between 0 - 100: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade <= 100 && grade >= 90)
            {
                Console.WriteLine("Congratulations! You got Grade: A");
            }
            else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("Good! You got Grade: B");

            }
            else if (grade < 80 && grade >= 70)
            {
                Console.WriteLine("Need to improve. You got Grade: C");

            }
            else if (grade < 70 && grade >= 60)
            {
                Console.WriteLine("Need to improve. You got Grade: D");

            }
            else
            {
                Console.WriteLine("Failed! Work harder, You got Grade: F");

            }

        }
    }
}
