using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4.999999;
            double b = 4.999998;
            double eps = 0.000001;
            bool flag = (Math.Abs((Math.Abs(a) - Math.Abs(b))) < eps) ? true : false;
            Console.WriteLine(flag);
        }
    }
}
