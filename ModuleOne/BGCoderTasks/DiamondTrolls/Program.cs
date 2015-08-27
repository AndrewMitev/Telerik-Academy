using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int row = (6 + ((N - 3) / 2) * 3); //height
            int column = N * 2 + 1; //width

            int middleHorizontal = (N / 2 + 1);
            int middleVertical = (column / 2);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                }
            }
        }
    }
}
