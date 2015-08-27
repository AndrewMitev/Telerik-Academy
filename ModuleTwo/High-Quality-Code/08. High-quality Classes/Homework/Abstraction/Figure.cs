namespace Abstraction
{
    using System;

    internal abstract class Figure
    {
        public Figure() 
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();
    }
}
