namespace _03.UsingXPath
{
    using System;
    using System.Collections;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument catalog = new XmlDocument();
            Hashtable table = new Hashtable();

            catalog.Load("../../../../catalogue.xml");

            string xPathQuery = "/catalogue/album";

            XmlNodeList albums = catalog.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
            {
                string key = album.SelectSingleNode("artist").InnerText;

                if (table.ContainsKey(key))
                {
                    int oldValue = (int)table[key];
                    table[key] = ++oldValue;
                }
                else
                {
                    table.Add(album["artist"].InnerText, 1);
                }
            }

            DisplayData(table);
        }

        private static void DisplayData(Hashtable table)
        {
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
