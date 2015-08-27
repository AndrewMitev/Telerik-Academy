using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;

namespace TwoGirlsOnePath
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] array = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger mollyResult = 0;
            BigInteger dollyResult = 0;
            string resultName = string.Empty;


            int mollyPosition = 0;
            int dollyPosition = array.Length - 1;

            while (true)
            {
                if (array[mollyPosition] == 0 && array[dollyPosition] == 0)
                {
                    resultName = "Draw";
                    Console.WriteLine(resultName);
                    Console.WriteLine(mollyResult + " " + dollyResult);
                    return;
                }

                if (array[mollyPosition] == 0)
                {
                    resultName = "Dolly";

                    if (array[dollyPosition] != 0)
                    { 
                        dollyResult += array[dollyPosition];
                    }
                    Console.WriteLine(resultName);
                    Console.WriteLine(mollyResult + " " + dollyResult);
                    return;
                }

                if (array[dollyPosition] == 0)
                {
                    resultName = "Molly";

                    if (array[mollyPosition] != 0)
                    { 
                        mollyResult += array[mollyPosition];
                    }

                    Console.WriteLine(resultName);
                    Console.WriteLine(mollyResult + " " + dollyResult);
                    return;
                }

                if (mollyPosition == dollyPosition)
                {
                    mollyResult += array[mollyPosition] / 2;
                    dollyResult += array[dollyPosition] / 2;

                    mollyPosition = (int)((mollyPosition + array[mollyPosition]) % array.Length);

                    dollyPosition = (int)((dollyPosition - array[dollyPosition]) % array.Length);

                    if (dollyPosition < 0)
                    {
                        dollyPosition += array.Length;
                    }

                    if (array[mollyPosition] % 2 != 0)
                    {
                        array[mollyPosition] = 1;
                    }
                    else
                    {
                        array[mollyPosition] = 0;
                    }


                }
                else
                {
                    BigInteger stepsMolly = new BigInteger();
                    BigInteger stepsDolly = new BigInteger();

                    stepsMolly = array[mollyPosition];
                    stepsDolly = array[dollyPosition];

                    mollyResult += array[mollyPosition];
                    array[mollyPosition] = 0;
                    mollyPosition = (int)((mollyPosition + stepsMolly) % array.Length);

                    dollyResult += array[dollyPosition];
                    array[dollyPosition] = 0;
                    dollyPosition = (int)((dollyPosition - stepsDolly) % array.Length);

                    if (dollyPosition < 0)
                    {
                        dollyPosition += array.Length;
                    }
                }

            }
        }
    }
}
