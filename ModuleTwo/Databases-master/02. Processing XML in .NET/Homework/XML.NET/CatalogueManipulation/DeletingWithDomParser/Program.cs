namespace DeletingWithDomParser
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            XmlDocument catalog = new XmlDocument();
            catalog.Load("../../../../Catalogue.xml");

            XmlNode rootNode = catalog.DocumentElement;

            DisplayAlbums(rootNode);

            foreach (XmlNode currentNode in rootNode.ChildNodes)
            {
                if (int.Parse(currentNode["price"].InnerText) < 20)
                {
                    rootNode.RemoveChild(currentNode);
                }
            }

            catalog.Save("../../../../Catalogue.xml");

            Console.WriteLine("============ After Manipulation =================");

            DisplayAlbums(rootNode);
        }

        private static void DisplayAlbums(XmlNode rootNode)
        {
            foreach (XmlNode currentNode in rootNode.ChildNodes)
            {
                Console.WriteLine("Album Name : " + currentNode["name"].InnerText);
                Console.WriteLine("Author : " + currentNode["artist"].InnerText);
                Console.WriteLine("Price : " + currentNode["price"].InnerText);
            }
        }
    }
}
