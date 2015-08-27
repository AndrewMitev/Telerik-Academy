using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(3);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.InsertElementAt(7, 3);
            Console.WriteLine(list.Max());
            Console.WriteLine(list);
        }
    }
}
