using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceTwoSidesAngle
{
    class TriangleSurfaceTwoSidesAngle
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double degrees = Math.PI * angle / 180.0;

            double surface = ((firstSide * secondSide) / 2) * Math.Sin(degrees);
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
