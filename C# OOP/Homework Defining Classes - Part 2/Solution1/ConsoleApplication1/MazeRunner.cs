using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MazeRunner
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i <= number; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j <= input.Length; j++)
                {
                    int num1 = (int)char.GetNumericValue(input[0]);
                    int num2 = (int)char.GetNumericValue(input[1]);
                    int num3 = (int)char.GetNumericValue(input[2]);
                    int num4 = (int)char.GetNumericValue(input[3]);


                    if (num1 % 2 == 0)
                    {
                        sumEven = num1 + sumEven;
                    }

                    else
                    {
                        sumOdd = num1 + sumOdd;
                    }

                    if (num2 % 2 == 0)
                    {
                        sumEven = num2 + sumEven;
                    }

                    else
                    {
                        sumOdd = num2 + sumOdd;
                    }

                    if (num3 % 2 == 0)
                    {
                        sumEven = num3 + sumEven;
                    }

                    else
                    {
                        sumOdd = num3 + sumOdd;
                    }

                    if (num4 % 2 == 0)
                    {
                        sumEven = num4 + sumEven;
                    }

                    else
                    {
                        sumOdd = num4 + sumOdd;
                    }
                }
                if (sumEven > sumOdd)
                {
                    Console.WriteLine("left");
                }
                else if (sumOdd > sumEven)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("straight");
                }

            }


        }
    }
}
