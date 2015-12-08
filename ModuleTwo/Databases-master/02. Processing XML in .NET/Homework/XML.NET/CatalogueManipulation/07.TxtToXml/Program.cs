namespace _07.TxtToXml
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string name = string.Empty;
            string address = string.Empty;
            string phone = string.Empty;

            using (StreamReader fileReader = new StreamReader("../../data.txt"))
            {
                name = fileReader.ReadLine();
                address = fileReader.ReadLine();
                phone = fileReader.ReadLine();        
            }

            XElement personXml = new XElement("person",
                new XElement("name", name),
                new XElement("address", address),
                new XElement("phone", phone)
                );

            personXml.Save("../../person.xml");
            Console.WriteLine("Done. Check file person.xml. You may delete it and re-run this program.");
        }
    }
}
