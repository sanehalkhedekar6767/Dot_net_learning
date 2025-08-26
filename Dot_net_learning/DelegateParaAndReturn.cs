using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Delegate with parameters and return type
    public class DelegateParaAndReturn
    {
        public delegate int MyDelegate3(int a, int b);

        public static void Main(string[] args)
        {
            MyDelegate3 del = AddMethod;
            TestClass3.TestMethod3(del);
        }
        public static int AddMethod(int x, int y)
        {
            return x + y;
        }
    }

    public class TestClass3
    {
        public static void TestMethod3(DelegateParaAndReturn.MyDelegate3 del)
        {
            Console.WriteLine("Sum is: " + del(5, 10)); 
        }
    }
}
