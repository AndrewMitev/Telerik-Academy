using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            Console.Write("Enter width:");
            int.TryParse(Console.ReadLine(),out width);
            Console.Write("Enter height:");
            int.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("perimeter:{0}, area:{1}", (2*width + 2*height), (width * height));
        }
    }
}
