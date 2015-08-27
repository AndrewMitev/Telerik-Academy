using System;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(double x, double y)
            : base(x, y)
        { 
        
        }

        public override double CalculateSurface()
        {
            return (base.Width * base.Heigth) / 2;
        }
    }
}
