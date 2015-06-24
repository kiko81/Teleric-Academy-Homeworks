namespace Euclidian3DSpace
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static Path path = new Path();

        public static void Load(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    var readLine = reader.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                    double x = double.Parse(readLine[0]);
                    double y = double.Parse(readLine[1]);
                    double z = double.Parse(readLine[2]);

                    Point3D newPoint = new Point3D(x, y, z);

                    path.AddPoint(newPoint);

                    line = reader.ReadLine();
                }
            }
        }

        public static void Save(Path pointsList, string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Point3D point in pointsList.Points)
                {
                    writer.WriteLine(point);
                }
            }
        }
    }
}
