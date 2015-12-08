namespace TaskSix
{
    using System;
    using System.Data.OleDb;

    public class Program
    {
        private static string Task6Query = "SELECT * FROM [Sheet1$]";
        private static string Task7Query = "INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)";


        public static void Main(string[] args)
        {
            OleDbConnection excelDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                      "Data Source=../../Excel/Data.xlsx;" +
                                                      "Extended Properties=\"Excel 8.0\"");

            excelDbConnection.Open();

            using (excelDbConnection)
            {
                Console.WriteLine();
                Console.WriteLine("Displaying data ...");
                Task6(excelDbConnection);

                Console.WriteLine("Task Seven is being processed!");
                Task7(excelDbConnection);
                Console.WriteLine("Inserted!");
            }
        }

        public static void Task6(OleDbConnection dbConnection)
        {
            OleDbCommand command = new OleDbCommand(Task6Query, dbConnection);

            OleDbDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("\t{0} - {1}", name, score);
                }
            }
        }

      public static void Task7(OleDbConnection dbConnection)
        {
            OleDbCommand command = new OleDbCommand(Task7Query, dbConnection);

            command.Parameters.AddWithValue("@name", "SomeValue");
            command.Parameters.AddWithValue("@value", 112);

            command.ExecuteNonQuery();
        }
    }
}
