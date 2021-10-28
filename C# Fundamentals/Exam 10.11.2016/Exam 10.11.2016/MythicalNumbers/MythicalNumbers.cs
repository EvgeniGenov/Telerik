using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbers
{
    class MythicalNumbers
    {

        static double Mythical(string input)
        {
            double num1 = double.Parse(input[0].ToString());
            double num2 = double.Parse(input[1].ToString());
            double num3 = double.Parse(input[2].ToString());

            if (num3 == 0)
            {
                return num1 * num2;
            }

            else if (num3 > 0 && num3 <= 5)
            {
                return (num1 * num2) / num3;
            }
            else
            {
                return (num1 + num2) * num3;
            }
        }

        static void MythVoid(string input)
        {
            double num1 = double.Parse(input[0].ToString());
            double num2 = double.Parse(input[1].ToString());
            double num3 = double.Parse(input[2].ToString());

            if (num3 == 0)
            {
                Console.WriteLine("{0:F2}", num1 * num2);
            }

            else if (num3 > 0 && num3 <= 5)
            {
                Console.WriteLine("{0:F2}", (num1 * num2) / num3);
            }
            else
            {
                Console.WriteLine("{0:F2}", (num1 + num2) * num3);
            }
        }


        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //double result = Mythical(input);

            //Console.WriteLine("{0:F2}", result);

            MythVoid(input);
            
            //int number = int.Parse(Console.ReadLine());
            //double num1 = number / 100;
            //double num2 = (number / 10) % 10;
            //double num3 = (number % 100) % 10;




        }
    }
}
