namespace FifthTask
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        public static void Main(string[] args)
        {
            byte[] imageInBytes;

            SqlConnection dbCon = new SqlConnection(
                "Server = .;" +
                "Database = Northwind;" +
                "Integrated Security = true");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT Picture FROM Categories;", dbCon);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    int fileNameNumber = 0;

                    while (reader.Read())
                    {
                        string fileName = "../../ExtractedImages/" + fileNameNumber.ToString() + ".jpg";

                        imageInBytes = (byte[])reader["Picture"];

                        WriteBinaryFile(fileName, imageInBytes);
                        fileNameNumber++;
                    }

                    Console.WriteLine("Images successfully extracted in ExtractedImages folder!");
                }
            }
        }

       private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);

            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}
