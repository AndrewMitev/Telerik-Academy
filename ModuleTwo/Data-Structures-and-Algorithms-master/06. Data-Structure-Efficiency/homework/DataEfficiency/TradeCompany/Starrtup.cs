namespace TradeCompany
{
    using Wintellect.PowerCollections;

    public class Starrtup
    {
        public static void Main()
        {
            OrderedMultiDictionary <decimal, long> tradeCompanyData = new OrderedMultiDictionary<decimal, long>(true);

            for (long i = 0; i < 2000000; i++)
            {
                tradeCompanyData.Add((decimal)i + (0.30m * i), i);
            }

            System.Console.WriteLine("Articles Loaded!");

            var firstRange = tradeCompanyData.Range(1.0m, true, 158.0m, true);

            var secondRange = tradeCompanyData.Range(30m, true, 20000m, true);

            var thirdRange = tradeCompanyData.Range(3000m, true, 800000m, true);

            var forthRange = tradeCompanyData.Range(567m, true, 100000.2m, true);

            var fifthRange = tradeCompanyData.RangeFrom(2m, true);

            System.Console.WriteLine("Ranges loaded");
        }
    }
}
