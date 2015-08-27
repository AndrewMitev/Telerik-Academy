namespace SaddyKopper
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input);
            BigInteger overallResult = new BigInteger(1);

            int transformation = 0;

            while(true)
            {

                overallResult = CalculateOverallResult(number, overallResult);

                transformation++;

                if (transformation == 10)
                {
                    Console.WriteLine(overallResult);
                    break;
                }

                if (overallResult < 10)
                {
                    Console.WriteLine(transformation);
                    Console.WriteLine(overallResult);
                    break;
                }

                number = overallResult;
                overallResult = 1;
            }
        }

        private static BigInteger CalculateOverallResult(BigInteger number, BigInteger overallResult)
        {
            do
            {
                int tempSum = 0;
                number /= 10;

                string numberAsString = number.ToString();

                for (int i = 0; i < numberAsString.Length; i++)
                {
                    if (i == 0 || i % 2 == 0)
                    {
                        tempSum += (int)Convert.ToInt64(numberAsString[i].ToString());
                    }
                }

                overallResult *= tempSum;

            } while (number >= 10);

            return overallResult;
        }
    }
}
