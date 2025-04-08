using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class StringBuilders
    {
        static void Main()
        {
            //String---------------->
            string str = "Hello World";
            Console.WriteLine(str);

            str = "Test";
            Console.WriteLine(str);

            string firstName = "Sanehal";
            string lastName = " Khedekar";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            //String Builder Implementation---------------->
            StringBuilder sb = new StringBuilder();
            sb.Append("My name "); //.Append(value) --> adds value
            sb.Append("is Sanehal");
            sb.Append(" Bharat");
            sb.Append(" Khedekar");
            Console.WriteLine(sb.ToString());

            //remove value from string builder in specific index
            sb.Remove(7, 3); //.Remove(start, length) --> removes value
            Console.WriteLine(sb.ToString());

            //insert value in psecific index of string builder
            sb.Insert(7, " is");  //.Insert(index, value) -->insert at given index
            Console.WriteLine(sb.ToString());

            //Replace 
            sb.Replace("is", "Miss.");  //.Replace(old value, new value)-->replace value
            Console.WriteLine(sb.ToString());

            //zeros the length
            sb.Clear();
            Console.WriteLine(sb.ToString());


        }
    }
}
