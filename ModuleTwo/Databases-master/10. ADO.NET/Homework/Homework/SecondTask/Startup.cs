namespace SecondTask
{
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
                SqlCommand command = new SqlCommand("Select CategoryName, Description FROM Categories;", dbCon);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string) reader["CategoryName"];
                        string description = (string)reader["Description"];

                        System.Console.WriteLine("{0} | {1}", name, description);
                    }
                }
            }
        }
    }
}
