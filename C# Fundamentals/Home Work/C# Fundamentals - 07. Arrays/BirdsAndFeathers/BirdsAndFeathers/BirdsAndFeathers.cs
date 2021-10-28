using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main(string[] args)
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double avr = feathers / birds;

            if (birds == 0)
            {
                Console.WriteLine(0);
            }
            else if (birds % 2 == 0)
            {
                Console.WriteLine("{0:f4}", avr* 123123123123);
            }
            else
            {
                Console.WriteLine("{ 0:f4}", avr / 317);
            }

        }
    }
}
