using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp

    {
        public static void Main()
        {
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(2, 2, 3);
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);


            Console.WriteLine("Distance between points: {0}", Distance.CalculateDistance(firstPoint, secondPoint));


            var path = new Path();

            for (int i = 0; i < 5; i++)
            {
                path.AddPoints(new Point3D(i + 2, i + 2, i + 2));
            }

            PathStorage.SavePath(path, "pathstorage.txt");

            var print = PathStorage.LoadPath("pathstorage.txt");

            foreach (var item in print)
            {
                Console.WriteLine(item);
            }

            var list = new GenericList<int>(3);

            list.AddElement(5);
            list.AddElement(18);
            list.AddElement(100);

            list.RemoveElement(1);

            list.AddElement(90);

            list.InsertElement(1, 10000);

            list.AddElement(123);

            Console.WriteLine(list);

            Console.WriteLine(list.GetElement(1));

            Console.WriteLine(list.GetMinEl());

            Console.WriteLine(list.GetMaxEl());

            list.ClearElements();

            Console.WriteLine(list);
        }
    }
}
