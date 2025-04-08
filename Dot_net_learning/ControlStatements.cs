using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class ControlStatements
    {
        static void Main()
        {
            //1.Selection statements

            Console.WriteLine("-----------IF STATEMENT-------------");
            //if statement
            int num = 1;
            if (num > 0)
            {
                Console.WriteLine("Value is greater");
            }


            Console.WriteLine("-----------IF ELSE STATEMENT-------------");
            //if else statement
            string UserName = "Sanehal";
            if (UserName == "Sanehal")
            {
                Console.WriteLine("This is active user");
            }
            else
            {
                Console.WriteLine("This user name is not verified");
            }


            Console.WriteLine("-----------NESTED IF ELSE STATEMENT-------------");
            //nested if else statement
            int value = 16;
            if (value == 10)
            {
                Console.WriteLine("Number is valid");
            }
            else if (value > 100)
            {
                Console.WriteLine("Number is greater than 100");
            }
            else if (value < 100)
            {
                Console.WriteLine("Number is less than 100");
            }
            else
            {
                Console.WriteLine("Number is invalid");
            }


            Console.WriteLine("-----------SWITCH CASE STATEMENT-------------");
            //switch case
            int Day = 3;
            switch (Day) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


            //2.Looping Statement

            Console.WriteLine("-----------FOR LOOP-------------");
            //for loop
            int n = 5;   //varible declaration
            for (n = 0; n < 5; n++)    // 1) variable initialization, 2) iteration condition, 3) update expression
            {
                Console.WriteLine("Iteration: " +n); 
            }

            Console.WriteLine("-----------WHILE LOOP-------------");
            //while loop: condition checks at entry
            int i = 0;
            while (i<5)
            {
                //core logic
                Console.WriteLine("Iterations in while loop" +i);
                i++;

            }

            Console.WriteLine("-----------DO WHILE LOOP-------------");
            //do while loop: condition checks at end
            int j = 0;
            do
            {
                Console.WriteLine("iteration in do while loop: " + j);
                j++;
            }
            while (j<=5);

            Console.WriteLine("-----------FOR EACH LOOP-------------");
            string[] fruits = { "Apple", "Mango", "Banana", "Kiwi", "Watermelon" };
            foreach (var fruit in fruits)
            {
                Console.WriteLine("The Fruit is: " + fruit);
            }


            //3.Jumping Statement

            //CONTINUE
            for (int k = 0; k < 5; k++)
            {
                if (k == 2)
                {
                    continue;
                }
                Console.WriteLine("Iteration: " + k);
            }

            //GO TO
            int count = 0;
            startLoop:

            if (count < 5)
            {
                Console.WriteLine($"Count is: {count}");
                count++;
                goto startLoop;
                //Console.WriteLine($"Count after goto: {count}");
            }
            Console.WriteLine($"Loop with goto is finished");

            //BREAK


        }
    }
}
