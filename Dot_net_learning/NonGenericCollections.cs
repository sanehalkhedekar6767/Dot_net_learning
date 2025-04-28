using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class NonGenericCollections
    {
        static void Main()
        {
            //ARRAY LIST
            ArrayList lst = new ArrayList();

            //adding elements in array list
            lst.Add(1);
            lst.Add("Junu");
            lst.Add(true);

            //accessing elements from array list
            Console.WriteLine("Array List elements");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            //remove element from array list
            lst.RemoveAt(2);
            foreach (var item in lst)
            {
                Console.WriteLine(item + " ");
            }


            //HASHTABLE
            Hashtable ht = new Hashtable();

            //adding elements in hashtable
            ht.Add(101, "C#");
            ht.Add(102, "Java");
            ht.Add(103, 797575);
            ht.Add(104, true);

            //while accessing the hashtable type casting is required as it stores as object 
            string value1 = (string)ht[101];
            string value2 = (string)ht[102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4 = (bool)ht[104];


         


        }
    }
}
