using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int i = 3, sum = 0;
            while (true)
            {
                sum = sum * i;
                i--;
            }

            Console.WriteLine("hello");
        }
    }
}
