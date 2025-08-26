using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }
    internal class AssignPositiveIntegerCheck
    {
        static void Main()
        {
            Console.WriteLine("--------------Assignment 2----------------");
            Console.Write("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new NegativeNumberException("Negative number entered.");
                }
                else
                {
                    Console.WriteLine($"You entered a positive integer: {num}");
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
