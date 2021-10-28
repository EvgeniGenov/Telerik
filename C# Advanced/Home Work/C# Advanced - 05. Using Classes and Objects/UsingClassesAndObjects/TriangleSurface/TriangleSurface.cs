using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main(string[] args)
        {

            double sideLength = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double surface = (sideLength * altitude) / 2;
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
