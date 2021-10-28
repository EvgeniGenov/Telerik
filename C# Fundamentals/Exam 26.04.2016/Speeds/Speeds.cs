using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int allCarsCount = int.Parse(Console.ReadLine());
            int currentSpeed = 0;

            int longestGroupCarsCount = 0;
            int currentGroupCarsCount = 0;
            int speedsOfLongestCarsGroup = 0;
            int speedsOfCurrentCarsGroup = 0;

            for (int i = 0; i < allCarsCount; i++)
            {
                int currentCarSpeed = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    currentSpeed = currentCarSpeed;
                }

                if (currentCarSpeed > currentSpeed)
                {
                    currentGroupCarsCount++;
                    speedsOfCurrentCarsGroup += currentCarSpeed;
                }
                else
                {
                    currentGroupCarsCount = 1;
                    speedsOfCurrentCarsGroup = currentCarSpeed;
                    currentSpeed = currentCarSpeed;
                }

                if (currentGroupCarsCount > longestGroupCarsCount)
                {
                    longestGroupCarsCount = currentGroupCarsCount;
                    speedsOfLongestCarsGroup = speedsOfCurrentCarsGroup;
                }
                else if (currentGroupCarsCount == longestGroupCarsCount)
                {
                    if (speedsOfCurrentCarsGroup > speedsOfLongestCarsGroup)
                    {
                        longestGroupCarsCount = currentGroupCarsCount;
                        speedsOfLongestCarsGroup = speedsOfCurrentCarsGroup;
                    }
                }
            }

            Console.WriteLine(speedsOfLongestCarsGroup);
        }
    }
}
