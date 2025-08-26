using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignOut
    {

        static void Main()
        {
            string name;
            int age;

            InitializeValues(out name, out age);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

        }
        public static void InitializeValues(out string name, out int age)
        {
            name = "Kris";
            age = 20;
        }


    }
}
