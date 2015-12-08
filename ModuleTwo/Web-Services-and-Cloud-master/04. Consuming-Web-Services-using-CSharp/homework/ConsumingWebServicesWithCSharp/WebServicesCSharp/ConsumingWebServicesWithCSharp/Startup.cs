namespace ConsumingWebServicesWithCSharp
{
    using System;
    using System.Net.Http;
    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            HttpClient client = new HttpClient();

            using (client)
            {
                client.BaseAddress = new Uri("http://api.guildwars2.com/v2/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                PrintAccounts(client);
            }

            Console.WriteLine(Console.ReadLine());
        }

        static void PrintAccounts(HttpClient client)
        {
            var response = client.GetAsync("account/").Result;

            if (response.IsSuccessStatusCode)
            {
                var itemJson = response.Content.ReadAsStringAsync().Result;

                var item = JsonConvert.DeserializeObject<Account>(itemJson);

                Console.WriteLine(item);
            }
        }
    }
}