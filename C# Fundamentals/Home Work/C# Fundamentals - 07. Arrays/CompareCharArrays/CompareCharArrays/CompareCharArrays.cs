using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();

            if (string.Compare(firstChar, secondChar) > 0)
            {
                Console.WriteLine(">");
            }
            else if (string.Compare(firstChar, secondChar) < 0)
            {
                Console.WriteLine("<");

            }
            else if (string.Compare(firstChar, secondChar) == 0)
            {
                Console.WriteLine("=");
            }
        }
    }
}
