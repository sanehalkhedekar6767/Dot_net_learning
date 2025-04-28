using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignDictionary
    {
        static void Main()
        {
            Dictionary<int, String> dict = new Dictionary<int, String>();

            Console.WriteLine("Elements added in Dictionary---->");
            dict.Add(1, "Microsoft");
            dict.Add(2, "Alphabet");
            dict.Add(3, "Apple");
            dict.Add(4, "Amazon");
            dict.Add(5, "Oracle");
            dict.Add(6, "Accenture");
            dict.Add(7, "IBM");
            dict.Add(8, "SalesForce");
            dict.Add(9, "CISCO");
            dict.Add(10, "Adobe");

            Console.WriteLine("Displaying Dictionary elements---->");
            foreach (KeyValuePair<int, String> KVP in dict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }
            Console.WriteLine("\t");

            Console.WriteLine("After Modifying Dictionary elements---->");
            Console.WriteLine("Modifying key 6 and 8 ");

            dict[6] = "Tesla";
            dict[8] = "NVIDIA";
            //foreach (KeyValuePair<int, String> KVP in dict)
            //{
            //    Console.WriteLine($"Key: {KVP.Key}, Value:{KVP.Value}");
            //}
            Console.WriteLine($"Key: 6 , Value: {dict[6]}");
            Console.WriteLine($"Key: 8 , Value: {dict[8]}");

            Console.WriteLine("\t");

            Console.WriteLine("After Removing Specific element from Dictionary ---->");
            dict.Remove(9);
            dict.Remove(7);
            Console.WriteLine("Removed 2 key value pairs");
            Console.WriteLine($"Dictionary count: {dict.Count()}");

            Console.WriteLine("\t");

            Console.WriteLine("Filtering Dictionary using ContainsKey---->");
            if (dict.ContainsKey(6))
            {
                Console.WriteLine("Yes element EXIST");
            }
            else
            {
                Console.WriteLine("Nope! element does not EXIST");

            }
            Console.WriteLine("\t");

            dict.Clear();
            Console.WriteLine("Dictionary Cleared!");
            Console.WriteLine($"Dictionary count: {dict.Count()}");







        }
    }
}
