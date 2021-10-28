using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringConsole
{
    class Program
    {



        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";

            for (int i = text.Length; i >= 0; i--)
            {
                result += text[i];
            }

            Console.WriteLine(result);
        }
    }
}
