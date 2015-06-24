namespace Euclidian3DSpace
{
    using System;

    class Program
    {
        static void Main()
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(4, 5, 6);

            Console.WriteLine("Distance between ({0}) and ({1}) = {2}", p1, p2, Distance.Calculate(p1, p2));

            Path path = new Path();

            path.AddPoint(p1);
            path.AddPoint(p2);

            PathStorage.Save(path, @"../../pointList.txt");
            PathStorage.Load(@"../../pointList.txt");




        }
    }
}
