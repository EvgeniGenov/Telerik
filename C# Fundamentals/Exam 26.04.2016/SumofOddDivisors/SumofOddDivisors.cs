using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOddDivisors
{
    class SumofOddDivisors
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sumDevisor = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if ( j % 2 == 1)
                        {
                            sumDevisor += j;
                        }

                    }
                }
                
            }
            Console.WriteLine(sumDevisor);
        }
    }
}
