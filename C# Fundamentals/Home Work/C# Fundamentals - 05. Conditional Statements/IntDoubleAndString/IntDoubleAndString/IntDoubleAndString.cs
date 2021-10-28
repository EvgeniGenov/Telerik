using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //if (input == "integer")
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num + 1);
            //}
            //else if (input == "real")
            //{
            //    double dNum = double.Parse(Console.ReadLine());
            //    Console.WriteLine(dNum + 1);
            //}
            //else
            //{
            //    string text = Console.ReadLine();
            //    Console.WriteLine(text + "*");

            string input = Console.ReadLine();

            switch (input)
            {
                case "integer":
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                case "real":
                    double dNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", dNum + 1);
                    break;

                default:
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}

