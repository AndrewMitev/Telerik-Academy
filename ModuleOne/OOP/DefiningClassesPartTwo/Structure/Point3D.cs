using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Point3D
    {
        private double xCoordinate;

        private double yCoordinate;

        private double zCoordinate;

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z):this()
        {
            this.xCoordinate = x;

            this.yCoordinate = y;

            this.zCoordinate = z;
        }

        public Point3D PointO
        {
            get { return this.PointO; }
        }

        public double XCoordinate
        {
            get
            {
                return this.xCoordinate;
            }
            set
            {
                this.xCoordinate = value;
            }
        }

        public double YCoordinate
        {
            get
            {
                return this.yCoordinate;
            }
            set
            {
                this.yCoordinate = value;
            }
        }

        public double ZCoordinate
        {
            get
            {
                return this.zCoordinate;
            }
            set
            {
                this.zCoordinate = value;
            }
        }

        public override string ToString()
        {
            return String.Format("x coordinate: {0}; y coordinate: {1}; z coordinate: {2};", this.xCoordinate, this.yCoordinate, this.zCoordinate);
        }

    }
}
