using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignJumpingStatements
    {
        static void Main()
        {
            //forEach loop
            Console.WriteLine("--------For each loop------------>");
            string[] mobileBrand = { "Samsung", "Apple", "Vivo", "Oppo", "Motorola", "Nokia", "Realme", "Toyota", "Xiaomi", "Oneplus" };
            foreach (var brandName in mobileBrand)
            {
                Console.WriteLine($"Mobile brand is: {brandName}");
            }
            Console.WriteLine();

            //break statement
            Console.WriteLine("--------Break Statement------------>");
            int sum = 0;
            while (true)
            {
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;

                if (num < 0)
                    break;

            }
            Console.WriteLine($"Sum of entered number is: {sum}");
            Console.WriteLine();

            //continue statement
            Console.WriteLine("--------Continue Statement------------>");
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Number is: {i}");
            }
            Console.WriteLine();

            //go to statement
            Console.WriteLine("--------GO TO Statement------------>");
            int age;
            Repeat:
            Console.Write("Enter the age between 0 - 120 : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>=120)
            {
                Console.WriteLine("OOPS! Invalid age");
                goto Repeat;
            }
            Console.WriteLine($"Age is: {age}");





        }
    }
}
