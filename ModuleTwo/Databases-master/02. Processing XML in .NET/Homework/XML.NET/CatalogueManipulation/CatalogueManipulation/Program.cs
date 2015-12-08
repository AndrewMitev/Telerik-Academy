namespace CatalogueManipulation
{
    using System;
    using System.Collections;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument catalog = new XmlDocument();
            catalog.Load("../../../../Catalogue.xml");

            Hashtable table = new Hashtable();
            XmlNode rootNode = catalog.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string key = node["artist"].InnerText;

                if (table.ContainsKey(key))
                {
                    int oldValue = (int)table[key];
                    table[key] = ++oldValue;
                }
                else
                {
                    table.Add(node["artist"].InnerText, 1);
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
