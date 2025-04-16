using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    class AssignArrays4
    {
        static void Main()
        {
            int[] nums = { 23, 34, 65, 67, 56, 89, 76, 93 };
            Console.WriteLine("Given Array is: ");
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine(" \t");
            Console.WriteLine("--------\t");

            Console.WriteLine("Alternate values in Array are: ");
            for (int i = 0; i < nums.Length; i=i+2)
            {
                Console.Write(nums[i] + " ");
                
            }
            Console.WriteLine(" \t");
            Console.WriteLine("--------\t");

            Console.WriteLine("Number of elements in given array are: " + nums.Length);
            Console.WriteLine(" \t");
            Console.WriteLine("--------\t");

            int max = nums[0];
            int min = nums[0];
            foreach (var element in nums)
            {
                if (element>max)
                {
                    max = element;
                }
                if (element < min)
                {
                    min = element;
                }
            }
            Console.WriteLine("Largest value in array is: " + max);
            Console.WriteLine(" \t");
            Console.WriteLine("--------\t");
            Console.WriteLine("Smallest value in array is: "+min);
            Console.WriteLine();




        }
    }
}
