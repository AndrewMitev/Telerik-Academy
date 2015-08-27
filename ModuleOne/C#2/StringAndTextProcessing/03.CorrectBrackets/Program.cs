using System;

/*
 * @Task
 * Write a program to check if in a given expression the brackets are put correctly.
 * 
 */
namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "((a+b)/5-d)";
            Console.WriteLine(CheckExpression(expression));
        }

        private static bool CheckExpression(string exp)
        {
            int counterOne = 0, counterTwo = 0;

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    counterOne++;
                }

                if (exp[i] == ')')
                {
                    counterTwo++;
                }

                if (counterTwo > counterOne)
                {
                    return false;
                }
            }

            if (counterOne == counterTwo)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
