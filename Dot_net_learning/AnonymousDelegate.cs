using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    public class AnonymousDelegate
    {
        public delegate void MyDelegate4(string s);

        public static void Main(String[] args)
        {
            MyDelegate4 del = delegate (string s)
            {
                Console.WriteLine(s);
            };
            del("Arbitary message");
        }
    }
}
