namespace TaskThree
{
    using TaskOne;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            NorthwindEntities northDb = new NorthwindEntities();
        }

        private static void FindSpecificCustomers(NorthwindEntities northDb)
        {
            using (northDb)
            {
                var customers = northDb.Orders
                    .Where(x => x.OrderDate.Value.Year == 1997 && x.ShipCountry == "Canada")
                    .Select(i => new
                    {
                        CustomerName = i.Customer.ContactName,
                        OrderDare = i.OrderDate
                    })
                    .ToList();
            }
        }

        private static void NativeQueryImplementation(NorthwindEntities northDb)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID IN (SELECT CustomerID FROM Orders WHERE year(OrderDate) = 1997);";

            using (northDb)
            {
                var specificProducts = northDb.Customers.SqlQuery(query).ToList();
            }
        }
    }
}
