using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringbuilderExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sample = new StringBuilder("This is sample text.");

            Console.WriteLine(sample.Substring(18, 2));
        }
    }
}
