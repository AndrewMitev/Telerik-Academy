using System;
using System.Text;
using System.Collections.Generic;

/*
 * @Task
 * Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */
namespace _13.SolveTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;

            Console.WriteLine("Choose from the menu:");
            Console.WriteLine("1.Reverse Number.");
            Console.WriteLine("2.Calculate Sequence.");
            Console.WriteLine("3.Reverse Equation a*x + b = 0");

            Console.Write("Enter your choice:");
            byte.TryParse(Console.ReadLine(), out choice);

            switch(choice)
            {
                case 1:
                    {
                        decimal num = ReverseNumber();

                        if (num == decimal.MinValue)
                        {
                            break;
                        }

                        Console.WriteLine("Reverted Number: " + num);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter numbers. Press Enter to stop.");
                        List<int> numbers = new List<int>();

                        while (true)
                        {
                            string key = Console.ReadLine();

                            if (key == "")
                            {
                                break;
                            }


                            numbers.Add(int.Parse(key));
                        }

                        CalculateSequence(numbers);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter A: ");
                        int a = int.Parse(Console.ReadLine());
                    
                        Console.Write("Enter B: ");
                        int b = int.Parse(Console.ReadLine());

                        CalculateEquation(a, b);
                        break;
                    }
                default: Console.WriteLine("Invalid input."); break;
            }

        }

        private static decimal ReverseNumber()
        {
            Console.Write("Enter decimal:");
            decimal num = decimal.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Number should be positive");
                return decimal.MinValue;
            }

            StringBuilder builder = new StringBuilder();

            int length = num.ToString().Length;
            string sNum = num.ToString();

            for (int i = length - 1; i >= 0; i--)
            {
                builder.Append(sNum[i]);
            }

            return decimal.Parse(builder.ToString());
        }

        private static void CalculateSequence(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Sequence cannot be empty");
                return;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Average is " + (sum / numbers.Count));
        }

        private static void CalculateEquation(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("A cannot be 0");
                return;
            }

            int result = (b * (-1)) / a;

            Console.WriteLine("x = " + result);
        }


    }
}
