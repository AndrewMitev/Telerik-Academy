using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Path path = PathStorage.LoadPath();

            PathStorage.SavePath(path);
            Console.WriteLine("done");
        }
    }
}
