using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Multicast Delegate
    public delegate void Notification();


    class MDelegate
    {
        public void StartingProcess()
        {
            Console.WriteLine("Process started.............");
        }
        public void EndingProcess()
        {
            Console.WriteLine("Process ended.............");
        }
    }
    internal class MultiCastDelegate
    {
        static void Main()
        {

            //class object
            MDelegate md = new MDelegate();
            md.StartingProcess(); 

            //create the delegate instance

            Notification notify = md.StartingProcess;
            notify += md.EndingProcess;
            notify += () => Console.WriteLine("All process started");
            notify();



        }
    }
}
