using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingNumbers
{
    class MixingNumbers
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            string[] numbers = new string[numbersCount];

            //List<String> numbers2 = new List<string>();

            for (int i = 0; i < numbersCount; i++)
            {
                string currentNumber = Console.ReadLine();
                numbers[i] = currentNumber;
                //numbers2.Add(currentNumber);
            }

            //int[] mixedResult = new int[numbersCount - 1];
            //int[] substractResult = new int[numbersCount - 1];


            List<int> mixedResult = new List<int>();
            List<int> substractResult = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                string firstElement = numbers[i];
                string secondElement = numbers[i + 1];

                int firstNumber = int.Parse(numbers[i]);
                int secondNumber = int.Parse(numbers[i + 1]);

                int lastDigitFirstNumber = int.Parse(firstElement[1].ToString());
                int firstDigitSecondNumber = int.Parse(secondElement[0].ToString());

                int mix = lastDigitFirstNumber * firstDigitSecondNumber;
                mixedResult.Add(mix);
                //mixedResult[i] = mix;

                int substract = Math.Abs(firstNumber - secondNumber);
                substractResult.Add(substract);
                //substractResult[i] = substract; 
            }

            Console.WriteLine(string.Join(" ", mixedResult));
            Console.WriteLine(string.Join(" ", substractResult));
        }
    }
}
