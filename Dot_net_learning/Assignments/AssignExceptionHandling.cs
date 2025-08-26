using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignExceptionHandling
    {
        static void Main()
        { 
            try
            {
                Console.WriteLine("--------------Assignment 1----------------");
                Console.Write("Enter value of num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t");
                Console.Write("Enter value of num2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double sum, diff, mul, div;
                sum = num1 + num2;
                diff = num1 - num2;
                mul = num1 * num2;
                div = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }


  
}
