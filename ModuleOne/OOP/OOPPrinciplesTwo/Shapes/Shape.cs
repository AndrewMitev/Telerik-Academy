using System;

namespace Shapes
{
    abstract class Shape
    {
        private double width;

        private double heigth;

        public Shape(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                this.heigth = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
