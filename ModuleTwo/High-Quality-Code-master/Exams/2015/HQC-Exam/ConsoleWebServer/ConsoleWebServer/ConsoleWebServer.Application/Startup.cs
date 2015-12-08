namespace ConsoleWebServer.Applicaton
{
    using System;
    using System.Text;
    using Framework;

    public class Startup
    {
        private static ResponseProvider responseProvider;

        public static void Main()
        {
            CreateResponseProvider();
            Start();
        }

        public static void Start()
        {
            var requestBuilder = new StringBuilder();
            string inputLine;

            while ((inputLine = Console.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    var response = responseProvider.GetResponse(requestBuilder.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(response);
                    Console.ResetColor();
                    requestBuilder.Clear();
                }

                requestBuilder.AppendLine(inputLine);
            }
        }

        private static void CreateResponseProvider()
        {
            responseProvider = new ResponseProvider();
        }
    }
}
