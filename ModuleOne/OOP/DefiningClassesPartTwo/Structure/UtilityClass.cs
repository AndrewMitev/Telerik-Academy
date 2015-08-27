using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    static class UtilityClass
    {
        internal static double CalculateDistance(Point3D one, Point3D two)
        {
            return Math.Sqrt( Math.Pow((one.XCoordinate - two.XCoordinate), 2) + Math.Pow((one.YCoordinate - two.YCoordinate), 2) + Math.Pow((one.ZCoordinate - two.ZCoordinate), 2) );
        }
    }
}
