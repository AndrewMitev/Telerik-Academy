using System;
using System.Collections.Generic;
using System.Text;

internal class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if(arr.Length == 0)
        {
            throw new ArgumentException("Subsequence(): Passed array cannot be empty!");
        }

        if (startIndex < 0 || startIndex > arr.Length - 1)
        {
            throw new ArgumentException("Subsequence(): startIndex must be in array's boundries.");
        }

        if (count < 1 || startIndex + count > arr.Length - 1)
        {
            throw new ArgumentException("Count cannot be negative and must not exceed array's length when added to startIndex!");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string sampleString, int count)
    {
        if (sampleString == null || sampleString.Length == 0)
        {
            throw new ArgumentNullException("ExtractEnding(): sample string cannot be empty or null!");
        }

        if (count > sampleString.Length)
        {
            throw new ArgumentException("ExtractEnding(): count must be less than string's length");
        }

        if (count < 0)
        {
            throw new ArgumentException("ExctractEnding(): count cannot be negative number!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = sampleString.Length - count; i < sampleString.Length; i++)
        {
            result.Append(sampleString[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("CheckPrime(): number cannot be negative number!");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArgumentException(string.Format("{0} is not prime!", number));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is prime.", number));
            }
        }
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(23);
        CheckPrime(33);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
