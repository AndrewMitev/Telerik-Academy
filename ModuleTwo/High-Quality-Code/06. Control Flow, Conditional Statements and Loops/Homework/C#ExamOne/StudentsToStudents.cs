namespace StudentsToStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsToStudents
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            StringBuilder sequence = new StringBuilder(string.Empty);

            int lenghtZero = 0, lenghtOne = 0;
            int bestLenghtOfZeros = 0, bestLenghtOfOnes = 0;

            if (inputNumber < 0)
            {
                inputNumber *= -1;
            }

            for (int i = 0; i < inputNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string binary = Convert.ToString(number, 2).PadLeft(30, '0');
                sequence.Append(binary);
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '0')
                {
                    lenghtZero++;

                    if (lenghtOne > bestLenghtOfOnes)
                    {
                        bestLenghtOfOnes = lenghtOne;
                    }

                    lenghtOne = 0;
                }
                else if (sequence[i] == '1')
                {
                    lenghtOne++;

                    if (lenghtZero > bestLenghtOfZeros)
                    {
                        bestLenghtOfZeros = lenghtZero;
                    }

                    lenghtZero = 0;
                }
            }

            if (lenghtOne > bestLenghtOfOnes)
            {
                bestLenghtOfOnes = lenghtOne;
            }

            if (lenghtZero > bestLenghtOfZeros)
            {
                bestLenghtOfZeros = lenghtZero;
            }

            Console.WriteLine(bestLenghtOfZeros);
            Console.WriteLine(bestLenghtOfOnes);
        }
    }
}
