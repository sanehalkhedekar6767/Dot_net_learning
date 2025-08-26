using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Delegate with parameters without return type
    public class DelegateToStoreParameters // Changed from internal to public
    {
        public delegate void MyDelegate2(string msg);

        public static void Main(string[] args)
        {
            MyDelegate2 del = MsgMethod;
            TestClass2.TestMethod2(del);
        }

        public static void MsgMethod(string message)
        {
            Console.WriteLine("Message is: " + message);
        }
    }
    public class TestClass2
    {
        public static void TestMethod2(DelegateToStoreParameters.MyDelegate2 del)
        {
            del("Hello");
        }
    }
}
