using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    class AssignArrays3
    {
       static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine("Given Array is: ");
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine(" \t");

            Console.WriteLine("Prime numbers are: ");
            foreach (var element in nums)
            {
                if (isPrime(element))
                {
                    Console.Write(element + ", ");
                }
            }

        }
        public static bool isPrime(int num)
        {
            if (num<2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            return true;

        }

    }
}


