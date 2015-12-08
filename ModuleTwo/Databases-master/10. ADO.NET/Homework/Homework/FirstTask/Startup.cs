namespace FirstTask
{
    using System.Data.SqlClient;

    public class Startup
    {
        public static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server = .;" +
                "Database = Northwind;" +
                "Integrated Security = true;");

            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int numberOfRows = (int)command.ExecuteScalar();
                System.Console.WriteLine("Number of rows is {0}", numberOfRows);
            }
        }
    }
}
