using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    class ReadOnlyEx
    {
        //Readonly properties
        public readonly int initialValue;
        public static readonly double pi;
        public static string test = "Test";

        //constructor
        public ReadOnlyEx(int initialVal)
        {
            initialValue = initialVal;
            initialValue = 20;

        }
        static ReadOnlyEx()
        {
            pi = 3.14;
        }

        //out of constructor modifying  value not allowed
        public void PrintValues()
        {
            Console.WriteLine($"InitialValue: {initialValue}, PI: {pi}");
        }
    }
    class ReadOnlyExample
    {
        static void Main()
        {
            ReadOnlyEx re = new ReadOnlyEx(5);
            re.PrintValues();
        }
    }
}
