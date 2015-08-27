namespace CohesionAndCoupling
{
    using System;

    internal class Parallelepiped
    {
        private double width;
        private double height;
        private double depth;

        internal Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        internal double Width
        {
            get 
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Figure's width cannot be negative.");
                }

                this.width = value;
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Figure's height cannot be negative number!");
                }

                this.height = value;
            }
        }

        internal double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Figure's depth cannot be negative number!");
                }

                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = GeometryUtils.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
