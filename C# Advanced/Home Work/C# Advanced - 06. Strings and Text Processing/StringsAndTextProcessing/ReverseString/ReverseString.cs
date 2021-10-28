using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseString
{
    static class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string result = "";
            int index = int.Parse(text);
            index = (text.Length + index);

            for (int i = index; i >= 0; i--)
            {
                result += text[i];
            }

            Console.WriteLine(result);
        }
    }
}
