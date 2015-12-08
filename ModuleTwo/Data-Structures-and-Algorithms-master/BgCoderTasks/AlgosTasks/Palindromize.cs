namespace Palindromize
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var answer = Palindromize(input);

            Console.WriteLine(answer);
        }

        private static string Palindromize(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                var firstChars = text.Substring(0, i).ToCharArray();
                Array.Reverse(firstChars);
                var candidate = text + new string(firstChars);
                if (IsPalindrome(candidate))
                {
                    return candidate;
                }
            }

            return string.Empty;
        }

        private static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
