using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        private static string LastDigitWord(int number)

        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int lastDigit = number % 10;
            return digits[lastDigit];
        }

        static void Main(string[] args)

        {
            int givenNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitWord(givenNumber));
        }
    }
}

