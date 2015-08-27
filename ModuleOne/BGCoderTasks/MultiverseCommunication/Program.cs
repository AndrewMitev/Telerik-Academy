using System;
using System.Collections.Generic;

namespace MultiverseCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<int> list = new List<int>();
            long output = 0;

            int i = message.Length / 3;
            int start = -3;

            while (i != 0)
            {
                start += 3;
                
                switch (message.Substring(start, 3))
                {
                    case "CHU": list.Add(0); break;
                    case "TEL": list.Add(1); break;
                    case "OFT": list.Add(2); break;
                    case "IVA": list.Add(3); break;
                    case "EMY": list.Add(4); break;
                    case "VNB": list.Add(5); break;
                    case "POQ": list.Add(6); break;
                    case "ERI": list.Add(7); break;
                    case "CAD": list.Add(8); break;
                    case "K-A": list.Add(9); break;
                    case "IIA": list.Add(10); break;
                    case "YLO": list.Add(11); break;
                    case "PLA": list.Add(12); break;    
                }

                i--;
            }

            for (int k = list.Count - 1, j = 0; k >= 0; k--, j++)
            {
                output += list[k] * (long)Math.Pow(13, j);
            }

            Console.WriteLine(output);
        }
    }
}
