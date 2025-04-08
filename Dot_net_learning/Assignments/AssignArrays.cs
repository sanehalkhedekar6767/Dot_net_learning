using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignArrays
    {
        static void Main()
        {

            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int sum = 0;
            Console.Write("Given array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum = sum + arr[i];
            }
            Console.WriteLine(" "); Console.WriteLine(" ");

            Console.WriteLine("Find sum of array elements------------->");
            Console.WriteLine("Sum of array elements is: " + sum);
            Console.WriteLine(" ");
            Console.WriteLine("Find average of array elements------------->");
            int avg = sum / arr.Length;
            Console.WriteLine("Average of array elements is: " + avg);


            Console.WriteLine();
            Console.WriteLine("------odd and even values from array-------------");
            int[] array = { 23, 34, 65, 67, 56, 89, 76, 93 };

            //even numbers
            Console.WriteLine("------even values from array-------------");

            foreach (var item in array)
            {
                if (item%2==0)
                {
                    Console.Write(item+ " ");

                }
            }
            Console.WriteLine();
            //odd numbers
            Console.WriteLine("------odd values from array-------------");

            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");

                }
            }
 
        }
    }
}
