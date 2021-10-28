using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesAndObjects
{
    class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            int daysInFeb = DateTime.DaysInMonth(year, 2);
            if (daysInFeb < 29)
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap = IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
