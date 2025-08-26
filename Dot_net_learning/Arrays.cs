using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class Arrays
    {
        static void Main()
        {
            //Array declaration----->
            string[] mobile = new string[5];//also denotes the size of the array

            //assigning values in arrays----->

            //1. First approach
            mobile[0] = "Apple";
            mobile[1] = "Xiaomi";
            mobile[2] = "Realme";
            mobile[3] = "Oneplus";
            mobile[4] = "Motorola";

            //Declaration and assignment together----->
            //2. Second approach
            //string[] fruits = { "Apple", "Mango", "Pear", "Grapes", "Kiwi" };

            //Accessing values from array
            for (int i = 0; i < mobile.Length; i++)
            {
                Console.Write(mobile[i] + ", ");
            }
            Console.WriteLine();


            //initialize multidimentional array
            int[,] Matrix = new int[,]//int number 
            {  //0  1  2
                {1, 2, 3}, //0     //index: row, column  0,1 = 2;  2,
                {4, 5, 6}, //1
                {8, 9, 10},//2
            };
            Console.WriteLine("Element at (0,0): "+ Matrix[0,0]); //1
            Console.WriteLine("Element at (1,2): " + Matrix[1, 2]);  //6

            Console.WriteLine("Given matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //reverse string
            string rev = "Welcome To";  //Output: emocleW

            char[] chArray = rev.ToCharArray();
            char[] revArray = new char[chArray.Length];

            for (int i = 0; i<chArray.Length; i++)
            {
                revArray[i] = chArray[chArray.Length - 1 - i];
            }
            string originalStr = new string(chArray);
            string revStr = new string(revArray);
            Console.WriteLine("Original String: " + originalStr);

            Console.WriteLine("Reverse String: "+revStr);

            foreach (var item in revArray)
            {
                
            }


        }
    }
}
