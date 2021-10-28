using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine("{0} {1}", secondNum, firstNum);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNum, secondNum);

            }
        }
    }
}
