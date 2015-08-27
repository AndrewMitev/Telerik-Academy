using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> array = new List<int> { 3,4,5,6,7,8};

            Console.WriteLine(array.Sum<int>());

            IEnumerable<double> arr = new List<double> { 1.23, 2.22, 3.786667};

            Console.WriteLine(arr.Sum<double>());
        }
    }
}
