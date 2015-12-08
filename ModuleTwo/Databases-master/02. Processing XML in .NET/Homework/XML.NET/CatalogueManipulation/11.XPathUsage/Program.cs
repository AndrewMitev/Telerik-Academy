namespace _11.XPathUsage
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> pricesOfModernAlbums = new List<int>();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../../catalogue.xml");

            string xPath = "/catalogue/album";

            XmlNodeList albums = xmlDoc.SelectNodes(xPath);

            int currentYear = DateTime.Now.Year;

            foreach (XmlNode album in albums)
            {
                int year = int.Parse(album.SelectSingleNode("year").InnerText);

                if (currentYear - year <= 5)
                {
                    pricesOfModernAlbums.Add(int.Parse(album.SelectSingleNode("price").InnerText));
                }

            }


            Console.WriteLine("Prices of all albums made not more than five years ago in $ separated by comma:");
            Console.WriteLine(string.Join(",", pricesOfModernAlbums.ToArray()));
        }
    }
}
