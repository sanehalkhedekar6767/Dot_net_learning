using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class RefExample
    {

        public static void swap(ref int a, ref int b)
        {

            int temp = a;
            a = b;
            b = temp;

        }





        static void Main()
        {
            //REF
            //intialization at same line is necessary
            int x = 10 , y = 20;

            Console.WriteLine($"Before swapping x: {x}, y: {y}");
            swap(ref x, ref y);
            Console.WriteLine($"After swapping x: {x}, y: {y}");

        }
    }
}
