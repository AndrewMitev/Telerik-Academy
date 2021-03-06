﻿using System;
using System.Text;

namespace Helper
{
    public static class RandomGenerator
    {
        private static Random random = new Random();
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";


        public static int GetRandomNumber(int min = 0, int max = int.MaxValue / 2)
        {
            return random.Next(min, max + 1);
        }

        public static string GetRandomString(int minLength = 0, int maxLength = int.MaxValue / 2 )
        {
            var length = random.Next(minLength, maxLength);

            var result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var currentRandomSymbol = Alphabet[random.Next(0, Alphabet.Length - 1)];
                result.Append(currentRandomSymbol);
            }

            return result.ToString();
        }

        public static DateTime GetRandomDate(DateTime? after = null, DateTime? before = null)
        {
            var minDate = after ?? new DateTime(1900, 1, 1, 0, 0, 0);
            var maxDate = before ?? new DateTime(2100, 12, 31, 12, 59, 59);
            ////TODO: check if date is greater than 28!!!
            var second = GetRandomNumber(minDate.Second, maxDate.Second);
            var minute = GetRandomNumber(minDate.Minute, maxDate.Minute); 
            var hour = GetRandomNumber(minDate.Hour, maxDate.Hour);
            var day = GetRandomNumber(minDate.Day, maxDate.Day); 
            var month = GetRandomNumber(minDate.Month, maxDate.Month);
            var year = GetRandomNumber(minDate.Year, maxDate.Year);

            return new DateTime(year, month, day, hour, minute, second);

        }
    }
}
