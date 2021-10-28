using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void GetMax()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maximum = numbers.Max();
            Console.WriteLine(maximum);
        }

        static void Main()
        {
            GetMax();
        }
    }
}
