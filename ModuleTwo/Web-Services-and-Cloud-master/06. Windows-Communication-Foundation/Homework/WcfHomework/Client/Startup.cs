namespace Client
{ 
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
           // var serviceAddress = new Uri("http://localhost:52170/DateService.svc");

            var client = new ServiceReference1.DateServiceClient();

           var result = client.TellMeTheDayAsync(DateTime.Now).Result;
            Console.WriteLine(result);
        }
    }
}
