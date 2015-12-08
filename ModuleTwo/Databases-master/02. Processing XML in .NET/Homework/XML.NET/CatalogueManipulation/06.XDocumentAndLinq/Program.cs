/// <summary>
/// Rewrite the same using XDocument and LINQ query.
/// </summary>
namespace _06.XDocumentAndLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            XDocument xmlDoc = XDocument.Load("../../../../catalogue.xml");

            var songs =
                from album in xmlDoc.Descendants("album")
                select album.Element("songs");
            var songTitles =
                from song in songs.Descendants("song")
                select song.Element("title").Value;

            Console.WriteLine("All songs found with Linq.\n");

            foreach (var songTitle in songTitles)
            {
                Console.WriteLine(songTitle);
            }
        }
    }
}
