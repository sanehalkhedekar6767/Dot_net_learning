using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    public class DefaultConstructorEx
    {
        public int value;

        //Constructor---> it invokes automatically on creating instance of class
        public DefaultConstructorEx()
        {
            value = 1;
        }
        //Normal Method
        public void Display()
        {
            Console.WriteLine("Test " + value);
        }
    }
    class DefaultConstructorExample
    {
        static void Main()
        {
            //Instance creation
            DefaultConstructorEx example = new DefaultConstructorEx();
            example.Display();
        }
        
    }
}
