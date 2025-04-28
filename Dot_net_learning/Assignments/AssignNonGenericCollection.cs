using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignNonGenericCollection
    {
        static void Main()
        {
            Console.WriteLine("--------Assignment 1------------");
            ArrayList lst = new ArrayList();
            lst.Add("Samsung");
            lst.Add("OnePlus");
            lst.Add("Realme");
            lst.Add("OPPO");
            lst.Add("Motorola");
            lst.Add("Honor");
            lst.Add("Vivo");
            lst.Add("Xiaomi");
            lst.Add("Nokia");
            lst.Add("Infinix");

            Console.WriteLine("Array List Elements--->");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\t");
            Console.WriteLine("After Removing Element of index 5 and 8--->");
            lst.RemoveAt(5);
            lst.RemoveAt(8);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\t");
            Console.WriteLine("After Deleting Elements--->");
            lst.Clear();
            Console.WriteLine($"Count: {lst.Count}");
            Console.WriteLine("\t");
            Console.WriteLine("\t");

            Console.WriteLine("--------Assignment 2------------");
            Hashtable MyHashTable = new Hashtable();
            MyHashTable.Add(101, "CS");
            MyHashTable.Add(102, "AIDS");
            MyHashTable.Add(103, "Civil");
            MyHashTable.Add(104, "ENTC");
            MyHashTable.Add(105, "Mech");

            Console.WriteLine("Accessing elements from Hashtable--->");
            //object firstelement = (string)MyHashTable[101];
            //object secondelement = (string)MyHashTable[102];
            //object thirdelement = (string)MyHashTable[103];
            //object fourthelement = (string)MyHashTable[104];
            //object fifthelement = (string)MyHashTable[105];
            //Console.WriteLine(firstelement);
            //Console.WriteLine(secondelement);
            //Console.WriteLine(thirdelement);
            //Console.WriteLine(fourthelement);
            //Console.WriteLine(fifthelement);
            foreach(DictionaryEntry elemt in MyHashTable)
            {
                Console.WriteLine($"Key: {elemt.Key}, Value: {elemt.Value}");
            }

            Console.WriteLine("\t");

            Console.WriteLine("After Modifying Hashtable--->");
            MyHashTable[103] = "ELectrical";
            MyHashTable[105] = "Civil";
            foreach (DictionaryEntry elemt in MyHashTable)
            {
                Console.WriteLine($"Key: {elemt.Key}, Value: {elemt.Value}");
            }
            Console.WriteLine("\t");

            Console.WriteLine("After Removing element from Hashtable--->");
            MyHashTable.Remove(104);
            MyHashTable.Remove(102);
            foreach (DictionaryEntry elemt in MyHashTable)
            {
                Console.WriteLine($"Key: {elemt.Key}, Value: {elemt.Value}");
            }
            Console.WriteLine("\t");

            Console.WriteLine("After Deleting Hashtable--->");
            MyHashTable.Clear();
            Console.WriteLine($"Count: {MyHashTable.Count}");





        }
    }
}
