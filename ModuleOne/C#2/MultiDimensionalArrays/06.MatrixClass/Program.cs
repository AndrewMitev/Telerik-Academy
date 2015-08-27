using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ma = { 
                       {2,3,4,5},
                       {3,4,7,8,}
                       
                       };
            Matrix m = new Matrix(ma);
            Console.WriteLine(m.ToString());

        }
    }
}
