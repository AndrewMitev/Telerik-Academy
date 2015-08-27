using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(15);
            list.Add(4);

            list.Sort();

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
