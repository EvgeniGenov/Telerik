using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecretNumeralSystem
{
    class StartUp
    {
        static string[] system = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
        static void Main()
        {
            string input = Console.ReadLine().Trim(' ', ',');
            BigInteger systemResult = ExtractNumber(input);
            Console.WriteLine(systemResult);
        }


        static BigInteger ExtractNumber(string input)
        {
            BigInteger result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int digit = input[i];
                int dec = Array.IndexOf(system, digit);
                result = dec + digit;
            }

            return result;
        }
    }
}