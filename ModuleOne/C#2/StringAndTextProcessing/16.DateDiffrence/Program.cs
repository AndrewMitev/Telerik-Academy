using System;

/*
 * @ Task
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */
namespace _16.DateDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Date(DD-MM-YY): ");
            string firstDate = Console.ReadLine();
            string[] dataOne = firstDate.Split('.');
            
            Console.Write("Enter Second Date(DD-MM-YY): ");
            string secondDate = Console.ReadLine();
            string[] dataTwo = secondDate.Split('.');


            DateTime timeOne = new DateTime(int.Parse(dataOne[2]), int.Parse(dataOne[1]), int.Parse(dataOne[0]));

            DateTime timeTwo = new DateTime(int.Parse(dataTwo[2]), int.Parse(dataTwo[1]), int.Parse(dataTwo[0]));

            TimeSpan diff;

            if (timeOne > timeTwo)
            {
                diff = timeOne.Subtract(timeTwo);
            }
            else
            {
                diff = timeTwo.Subtract(timeOne);
            }

            Console.WriteLine("Distance: " + diff.Days);
        }
    }
}
