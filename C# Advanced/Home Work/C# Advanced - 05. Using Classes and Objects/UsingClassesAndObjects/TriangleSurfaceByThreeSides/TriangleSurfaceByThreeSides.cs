using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());
            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double surface = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));

            Console.WriteLine("{0:F2}", surface);

        }
    }
}
