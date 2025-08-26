using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    public class DelegateExample
    {
        public delegate void MyDelegate();

        public static void Main(string[]args)
        {
            MyDelegate del = Method1;
            del += Method2;             //Multiple methods can be assigned to a delegate
            TestClass.TestMethod(del);
        }
        public static void Method1()
        {
            Console.WriteLine("Method1 called");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2 called");
        }
    }

    public class TestClass
    {
        public static void TestMethod(DelegateExample.MyDelegate del)
        {
            del();
        }
    }
}
