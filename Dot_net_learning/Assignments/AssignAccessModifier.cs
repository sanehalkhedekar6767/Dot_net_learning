using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void DisplayFullName()
        {
            Console.WriteLine($"Full name: {firstName} {lastName}");
        }
    }

    class AssignAccessModifier
    {
        static void Main()
        {
            Person obj = new Person();
            obj.firstName = "Sanehal";
            obj.lastName = "Khedekar";
            obj.DisplayFullName();
        }
    }
}
