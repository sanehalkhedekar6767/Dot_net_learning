using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning
{
    internal class Enum
    {
         enum Days
        {
            //Enum Implementation
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
            
        }
        enum HttpsStatusCode
        {
            OK = 200,
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 500,
            NotFund = 400
        }

        static void Main()
        {

            //USING SWITCH CASE
            Days today = Days.Monday;
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                case Days.Monday:
                    //Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case Days.Thursday:
                    //Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today is Thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
                
            }

            //USING IF ELSE LOOP
            if(today == Days.Sunday || today == Days.Sunday)
            {
                Console.WriteLine("Hurray!!! It's weekend");
            }
            else
            {
                Console.WriteLine("Nope!!! It's week day");

            }



            HttpStatusCode code = HttpStatusCode.OK;
            Console.WriteLine("HTTP Status Code: " + code);

            int codeNumber = (int)code;
            Console.WriteLine("Http status code number: " + codeNumber);


            //testing public, private, protected, internal / default access modifiers
            PublicExampleTest obj = new PublicExampleTest();
            obj.pubicProperty = 1;
            obj.Display();
            obj.Show();

        }
    }
}
