using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbersExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = Console.ReadLine();

            double a = (double)char.GetNumericValue(abc[0]);
            double b = (double)char.GetNumericValue(abc[1]);
            double c = (double)char.GetNumericValue(abc[2]);


            if (c == 0)
            {
                Console.WriteLine("{0:F2}", a * b);
            }
            else if ((c > 0) && (c <= 5))
            {

                Console.WriteLine("{0:F2}", (a * b) / c);
            }
            else
            {

                Console.WriteLine("{0:F2}", (a + b) * c);
            }

        }
    }
}
