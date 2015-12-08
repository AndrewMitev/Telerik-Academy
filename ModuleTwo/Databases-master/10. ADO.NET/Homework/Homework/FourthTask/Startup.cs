namespace FourthTask
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
                    "INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                    "VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued);", dbCon);

                command.Parameters.AddWithValue("@productName", "Chungy");
                command.Parameters.AddWithValue("@supplierID", 1);
                command.Parameters.AddWithValue("@categoryID", 2);
                command.Parameters.AddWithValue("@quantityPerUnit", "Something maaan");
                command.Parameters.AddWithValue("@unitPrice", 22000.00f);
                command.Parameters.AddWithValue("@unitsInStock", 3);
                command.Parameters.AddWithValue("@unitsOnOrder", 2);
                command.Parameters.AddWithValue("@reorderLevel", 2);
                command.Parameters.AddWithValue("@discontinued", 0);

                Console.WriteLine("Successful Insert!");
                Console.WriteLine("Number of rows affected: [{0}]", command.ExecuteNonQuery());
            }
        }
    }
}
