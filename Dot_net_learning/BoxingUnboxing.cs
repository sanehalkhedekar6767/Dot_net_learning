using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class BoxingUnboxing
    {
        static void Main()
        {
            //Boxing -> process of converting values type to object type
            int x = 10; //value type
            object y = x;//boxing

            //Unboxing -> process of converting object type to value type
            object o = 10;  //object type
            int i = (int)o;//unboxing
        }
    }
}
