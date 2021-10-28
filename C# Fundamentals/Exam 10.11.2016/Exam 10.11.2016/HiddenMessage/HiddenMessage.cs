using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenMessage
{
    class HiddenMessage
    {
        static void Main(string[] args)
        {
            int index = 0;
            int number = 0;
            string subs = "";
            string result = "";

            string input = Console.ReadLine();
            while (input != "end")
            {
                index = int.Parse(input);
                number = int.Parse(Console.ReadLine());
                subs = Console.ReadLine();

                if (index < 0)
                {
                    index = (subs.Length + index);
                }

                if (number < 0)
                {
                    // go in subs backwards starting from index
                    //for (int i = MaxLenght; i >= 0; i--)
                    //{

                    //}

                    for (int i = index; i >= 0; i+= number)
                    {
                        result += subs[i];
                    }
                }
                else
                {
                    // go in subs forward starting from index
                    //for (int i = 0; i < MaxLenght-1; i++)
                    //{

                    //}

                    for (int i = index; i <= subs.Length - 1; i+=number)
                    {
                        result += subs[i];
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
