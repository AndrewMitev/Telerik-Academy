/// <summary>
/// Write a program, which using XmlReader extracts all song titles from catalog.xml
/// </summary>
namespace _05.XmlReader
{
    using System;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../../../Catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element
                        && (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
