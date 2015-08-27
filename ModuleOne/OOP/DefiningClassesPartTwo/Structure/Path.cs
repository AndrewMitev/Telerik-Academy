using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Path
    {
        private List<Point3D> pointsPath;

        public List<Point3D> PointsPath
        {
            get { return this.pointsPath; }
        }

        public Path()
        {
            this.pointsPath = new List<Point3D>();
        }

        public Path(List<Point3D> list)
        {
            this.pointsPath = list;
        }

        public void AddPoint(Point3D p)
        {
            this.PointsPath.Add(p);
        }

        public void PrintPoints()
        {
            foreach (var point in pointsPath)
            {
                Console.WriteLine("x:{0} y:{1} z:{2}", point.XCoordinate, point.YCoordinate, point.ZCoordinate);
            }
        }
    }
}
