using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class GenericCollections
    {

        //Generic Collections

        static void Main()
        {

            //List

            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            Console.WriteLine(num.Count);
            Console.WriteLine(num[1]);

            //Dictionary
            Dictionary<String, int> name = new Dictionary<String, int>();

            //add key - value pairs to the dictionary
            name.Add("Kris", 2);
            name.Add("Junoon", 1);
            name.Add("Coco", 5);
            name.Add("Boba", 4);
            Console.WriteLine("All elements added in the dictionary");
            foreach (KeyValuePair<String, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");
            }

            //Modify Dictionary
            name["Junoon"] = 3;
            Console.WriteLine("Updated elements in dictionary");

            foreach(KeyValuePair<String, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");

            }

            //Remove element from dictionary
            name.Remove("Boba");
            Console.WriteLine("After removing elements from dictionary");

            foreach (KeyValuePair<String, int> KVP in name)
            {
                Console.WriteLine($"{KVP.Value}: {KVP.Key}");

            }

            if (name.ContainsKey("Coco"))
            {
                Console.WriteLine("Exist in dictionary");
            }
            else
            {
                Console.WriteLine("Does not Exist in dictionary");

            }

            //QUEUE  ---  FIFO
            Queue qu = new Queue();

            //Adding elements in queue
            qu.Enqueue("Junoon");
            qu.Enqueue(8767519187);
            qu.Enqueue(true);

            //Removing elements from queue
            object firstelement = qu.Dequeue();
            object secondelement = qu.Dequeue();

            Console.WriteLine("Dequed elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);

            //STACK  ---  LIFO
            Stack st = new Stack();

            //Adding elements to the stack
            st.Push("Top");
            st.Push(21);
            st.Push(true);
            st.Push(2345678901);

            //Display stack
            Console.WriteLine(st);
            
            //Removing element from stack
            object topelement = st.Pop();
            object secondelements = st.Pop();
            object thirdelemen = st.Pop();

            Console.WriteLine(topelement);
            Console.WriteLine(secondelements);
            Console.WriteLine(thirdelemen);













        }
    }
}
