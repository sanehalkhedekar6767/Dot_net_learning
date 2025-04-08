using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_learning.Assignments
{
    internal class AssignEnum
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main()
        {
            Console.WriteLine("Entered month is: December");
            Months monthName = Months.December;
            switch (monthName)
            {
                case Months.January:
                    Console.WriteLine("It's starting month of the year");
                    break;
                case Months.February:
                    Console.WriteLine("It's 2nd month");
                    break;
                case Months.March:
                    Console.WriteLine("It's 3rd month");
                    break;
                case Months.April:
                    Console.WriteLine("It's 4th month");
                    break;
                case Months.May:
                    Console.WriteLine("It's 5th month");
                    break;
                case Months.June:
                    Console.WriteLine("It's 6th month");
                    break;
                case Months.July:
                    Console.WriteLine("It's 7th month");
                    break;
                case Months.August:
                    Console.WriteLine("It's 8th month");
                    break;
                case Months.September:
                    Console.WriteLine("It's 9th month");
                    break;
                case Months.October:
                    Console.WriteLine("It's 10th month");
                    break;
                case Months.November:
                    Console.WriteLine("It's 11th month");
                    break;
                case Months.December:
                    Console.WriteLine("It's ending month of the year");
                    break;
                
            }

        }
    }
}
