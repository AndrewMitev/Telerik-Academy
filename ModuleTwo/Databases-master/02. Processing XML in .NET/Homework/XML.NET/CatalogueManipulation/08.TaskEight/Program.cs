/// <summary>
///  Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml
///  and creates the file album.xml,
///  in which stores in appropriate way the names of all albums and their authors.
/// </summary>
namespace _08.TaskEight
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            using (XmlReader reader = XmlReader.Create("../../../../catalogue.xml"))
            {
                string currentAlbum = string.Empty;

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "name"))
                    {
                        currentAlbum = reader.ReadElementString();
                    }
                    else if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "artist"))
                    {
                        string nameOfArtist = reader.ReadElementString();

                        if (!data.ContainsKey(nameOfArtist))
                        {
                            data.Add(nameOfArtist, new List<string>());
                        }

                        data[nameOfArtist].Add(currentAlbum);
                    }
                }

                WriteData(data);
                Console.WriteLine("Data exported to album.xml");
            }
        }

        private static void WriteData(Dictionary<string, List<string>> data)
        {
            string fileName = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("authors");
                foreach (var item in data)
                {
                    writer.WriteStartElement("author");
                    writer.WriteAttributeString("name", item.Key);
                    foreach (var album in item.Value)
                    {
                        writer.WriteElementString("album", album);
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
            }
        }
    }
}
