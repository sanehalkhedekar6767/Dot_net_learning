using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class ExceptionHandling
    {
        static void Main()
        {

            //try :- it executes always, alone not allowed
            //catch :-it execute once error is occured, we can use multiple catch block, compulsory with try block
            //finally :-it executes always either error occurred or not, not compulsory

            int[] numbers = { 1, 2, 3 };
            int index = 3;
            try
            {
                int value = numbers[index];
                Console.WriteLine($"Value at index {index} is {value}");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"An error occured for index out of bound: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An erro occured: {ex.Message}");    
            }
            finally
            {
                Console.WriteLine("This code always execute");
            }


            //Divide by Zero
            int num = 10;
            int deno = 0;
            double result = 0;
            try
            {
                result = num / deno;
                Console.WriteLine($"Result of division is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message} cannot be divide by zero");
            } 

        }
    }
}
