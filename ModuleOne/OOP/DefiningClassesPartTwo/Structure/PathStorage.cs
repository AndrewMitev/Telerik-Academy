using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Structure
{
    static class PathStorage
    {
        public static void SavePath(Path path)
        {
            try
            {
                StreamWriter writer = new StreamWriter("../../Paths.txt", true);

                using (writer)
                {
                    int counter = 0;

                    foreach (Point3D point in path.PointsPath)
                    {
                        writer.WriteLine("Point {0} -> x - y - z: {1} {2} {3}", ++counter, point.XCoordinate, point.YCoordinate, point.ZCoordinate);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File \"Paths.txt\" was not found.");
            }
        }

        public static Path LoadPath()
        {
            Path loaded = new Path();
            try
            {
                StreamReader reader = new StreamReader("../../LoadPath.txt");

                using (reader)
                {
                    string line = reader.ReadLine();

                    if (line != null)
                    {
                        while (line != null)
                        {
                            int position = line.IndexOf(':');
                            string needed = line.Substring(position + 1);
                            double[] points = needed.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
                            loaded.AddPoint(new Point3D(points[0], points[1], points[2]));

                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("LoadPath.txt is missing from program's directory.");
            }

            return loaded;  
        }
    }
}
