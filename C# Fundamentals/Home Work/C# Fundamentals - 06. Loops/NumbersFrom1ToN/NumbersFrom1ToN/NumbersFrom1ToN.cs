using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int allNum = 1;

            while (allNum <= num)
            {
                Console.Write(allNum + " ");
                allNum++;
            }
        }
    }
}
