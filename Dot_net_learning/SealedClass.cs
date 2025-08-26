using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    //Base Class
    class Employee
    {
        public virtual void Role()
        {
            Console.WriteLine("I am an employee");
        }
    }

    //sealed class that prevent inheritance
     sealed class Manager:Employee
    {
        public override void Role()
        {
            Console.WriteLine("I am a manager");
        }
    }

    //attempting to inherit from sealed class - will cause compiler error
    //class TeamLead : Manager
    //{

    //}


    internal class SealedClass
    {
        static void Main()
        {
            Manager mg = new Manager();
            mg.Role();
        }
    }
}
