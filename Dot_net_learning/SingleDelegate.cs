using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{

    //[Modifier] delegate returntype | void <name>([parameterList])
    //Delegate declaration

    public delegate void AddDelegate(int a, int b);
    public delegate string DisplayDelegate(string str);

    class MyDelegate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("Sum: ",a + b);
        }
        public static string Display(string str)
        {
            return "Addition Completed!!!!!";
        }


    }
    internal class SingleDelegate
    {
        static void Main()
        {
            //calling delegate....
            MyDelegate md = new MyDelegate();  //class object creation
            AddDelegate ad = new AddDelegate(md.AddNumbers);
            ad(10, 20);
            
            DisplayDelegate dp = new DisplayDelegate(MyDelegate.Display);
            string str = dp("Hello");
            Console.WriteLine(str);
            

        }
    }
}
