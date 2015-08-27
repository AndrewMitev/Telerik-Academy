using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight;
            Console.Write("Enter weight:");
            float.TryParse(Console.ReadLine(), out weight);
            float moonWeight = 0.17f * weight;
            Console.WriteLine(moonWeight);
        }
    }
}
