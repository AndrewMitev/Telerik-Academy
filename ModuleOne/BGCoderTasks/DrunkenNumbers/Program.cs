using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long sumM = 0, sumV = 0; 

            for (int i = 0; i < N; i++)
            {
                long num = long.Parse(Console.ReadLine());
                if (num < 0)
                {
                    num *= -1;
                }

                string number = num.ToString();

                if (number.Length % 2 != 0)
                {
                    sumM += Convert.ToInt32(number[number.Length / 2].ToString());
                }

                for (int j = 0; j < number.Length; j++)
                {
                        if (j < number.Length / 2)
                        {
                            sumM += Convert.ToInt32(number[j].ToString());
                        }
                        else
                        {
                            sumV += Convert.ToInt32(number[j].ToString());
                        }
                }
            }

            if (sumM > sumV)
            {
                Console.WriteLine("M " + (sumM - sumV));
            }
            else if (sumM < sumV)
            {
                Console.WriteLine("V " + (sumV - sumM));
            }
            else
            {
                Console.WriteLine("No " + 2*sumM);
            }
        }
    }
}
