using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace SecretNumeralSystem
{
    class StartUp
    {

        static string[] system = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
        static void Main()
        {
            char[] separators = new char[] { ',' };
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int digitValue = 0;
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + digitValue;
            }
            Console.WriteLine(result);
        }
    }
}