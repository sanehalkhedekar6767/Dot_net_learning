using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class InternalExample
    {
        //internal member
        internal string sound = "lalalala";

        //internal method
        internal void MakingSound()
        {
            Console.WriteLine($"Animal makes sound: {sound}");
        }
        
    }
}
