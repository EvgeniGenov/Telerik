using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        private static int LargerNeighbours(int[] numbersSequance)

        {
            int largerNumbersCount = 0;
            for (int i = 0; i < numbersSequance.Length; i++)
            {
                if (i != 0 && i != numbersSequance.Length - 1)
                {
                    if (numbersSequance[i] > numbersSequance[i - 1] && numbersSequance[i] > numbersSequance[i + 1])
                    {
                        largerNumbersCount++;
                    }
                    else
                    {
                        continue;
                    }

                }
                return largerNumbersCount;
                
            }
        }
        static void Main(string[] args)

        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(LargerNeighbours(numbers));
        }
    }
}



