namespace PetStore.ConsoleClient.Utils
{
    using System;
    using System.Text;

    public static class CustomRandomGenerator
    {
        private static Random random = new Random();
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";


        public static int GetRandomNumber(int min = 0, int max = int.MaxValue / 2)
        {
            return random.Next(min, max + 1);
        }

        public static double GetRandomDouble(double min = 0.0d, double max = 10000000000.0d)
        {
            return random.NextDouble() * (max - min) + min;
        }

        public static string GetRandomString(int minLength = 0, int maxLength = int.MaxValue / 2)
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

        public static string GetRandomColor()
        {
            int randomColorNumber = GetRandomNumber(0, 3);
            string[] colors = new string[] { "black", "white", "red", "mixed" };

            return colors[randomColorNumber];
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

            if (day > 28)
            {
                day = 28;
            }

            return new DateTime(year, month, day, hour, minute, second);
        }
    }
}
