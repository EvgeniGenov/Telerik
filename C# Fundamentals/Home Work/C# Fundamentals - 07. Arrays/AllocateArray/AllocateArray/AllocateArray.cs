using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] index = new int[n];


            for (int i = 0; i < index.Length; i++)
            {
                index[i] = i * 5;

            }

            foreach (int number in index)
            {
                Console.WriteLine(number);
            }


        }
    }
}
