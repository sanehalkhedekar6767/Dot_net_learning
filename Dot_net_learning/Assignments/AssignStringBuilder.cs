using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dot_net_learning.Assignments
{
    internal class AssignStringBuilder
    {
        static void Main()
        {

            Console.WriteLine("\t");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Task 1: Append-------->");
            StringBuilder sb = new StringBuilder();
            sb.Append("If you");
            sb.Append(" can't say");
            sb.Append(" anything good, ");
            sb.Append(" don't say");
            sb.Append(" nothing ");
            sb.Append(" at all.");
            Console.WriteLine("Original string is---->");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Task 2: Repace------->");
            sb.Replace("anything good", "something nice");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Task 3: Remove-------->");
            sb.Remove(17, 9);
            Console.WriteLine(sb.ToString());



            Console.WriteLine("\t");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("To find min and max from array---->");

            int[] maxMinArray = { 50, 30, 80, 10, 40 };

            int max = maxMinArray[0];
            int min = maxMinArray[0];
            foreach (var item in maxMinArray)
            {
                if (item > max) max = item;
                if (item < min) min = item;

            }
            Console.WriteLine($"Max number is: {max}");
            Console.WriteLine($"Min number is: {min}");

            Console.WriteLine("\t");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("To find min and max from array---->");
            string[] nameArray = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.Write("Enter the name to find: ");

            string name = Console.ReadLine();
            if(nameArray.Contains(name))
            {
                Console.WriteLine($"Name: {name} is found");
            }
            else
            {
                Console.WriteLine($"OOPS!! name: {name} not found");

            }
        }
        }
}
