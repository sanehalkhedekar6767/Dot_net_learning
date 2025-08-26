using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignRef
    {
        public static void IncrementValue(ref int num)
        {
            num++;
        }
        static void Main()
        {
            int num = 10;
            Console.WriteLine($"Before incrementing: {num}");
            IncrementValue(ref num);
            Console.WriteLine($"After incrementing: {num}");


        }
    }
}
