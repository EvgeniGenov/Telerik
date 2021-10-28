using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Busses
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupSpeed = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                int speedBus = int.Parse(Console.ReadLine());

                if (speedBus <= groupSpeed)
                {
                    groups++;
                    groupSpeed = speedBus;
                }
                
            }
            Console.WriteLine(groups);

        }
    }
}
