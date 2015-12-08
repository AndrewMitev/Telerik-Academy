namespace ThirdTask
{
    using System;
    using System.Data.SqlClient;

    public class Startup
    {
        public static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server = .;" +
                "Database = Northwind;" +
                "Integrated Security = true");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c INNER JOIN Products p ON c.CategoryID = p.CategoryID;", dbCon);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string) reader["CategoryName"];
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine("{0} - {1}", categoryName, productName);
                    }
                }
            }
        }
    }
}
