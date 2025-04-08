using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignLooping
    {
        static void Main()
        {
            
            Console.WriteLine("Welcome to Food Court---->");
            Console.WriteLine("1. Pizza - Rs 100");
            Console.WriteLine("2. Burger - Rs 80");
            Console.WriteLine("3. Sandwitch - Rs 60");
            Console.WriteLine("4. Salad - Rs 100");
            Console.WriteLine("5. Brownie  - Rs 70");
            Console.WriteLine("6. Exit");
            Console.Write("Please select the food item by entering corrresponding number: ");

            int item = Convert.ToInt32(Console.ReadLine());
            switch (item)
            {
                case 1:
                    Console.WriteLine("You choose PIZZA - Rs 100");
                    break;
                case 2:
                    Console.WriteLine("You choose BURGER - Rs 80");
                    break;
                case 3:
                    Console.WriteLine("You choose SANDWITCH - Rs 60");
                    break;
                case 4:
                    Console.WriteLine("You choose SALAD - Rs 100");
                    break;
                case 5:
                    Console.WriteLine("You choose BROWNIE - Rs 70");
                    break;
                case 6:
                    Console.WriteLine("Thank You! Visit Again");
                    break;
                default: 
                    Console.WriteLine("Sorry! Item not available");
                    break;

            }
            Console.WriteLine("");
            Console.WriteLine("FOR LOOP------->");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Checking Student: {i}");
            }
            Console.WriteLine("");

            Console.WriteLine("WHILE LOOP------->");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine($"Checking Student: {j}");
                j++;
            }
            Console.WriteLine("");

            Console.WriteLine("DO WHILE LOOP------->");
            int k = 1;
            do
            {
                Console.WriteLine($"Checking Student: {k}");
                k++;
            }while(k <= 10);












        }
    }
}
