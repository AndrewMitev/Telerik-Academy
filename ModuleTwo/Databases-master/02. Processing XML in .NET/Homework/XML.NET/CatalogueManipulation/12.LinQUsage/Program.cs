namespace _12.LinQUsage
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            XDocument xDoc = XDocument.Load("../../../../catalogue.xml");

            int currentYear = DateTime.Now.Year;

            var newBooks =
                from album in xDoc.Descendants("album")
                where (int.Parse(album.Element("year").Value) - currentYear) <= 5
                select album.Element("price").Value;

            foreach (var book in newBooks)
            {
                Console.WriteLine("Price of new album:" + book);
            }            
        }
    }
}
