namespace TaskOne
{
    using System.Linq;

    public class NorthwindOperations
    {
        public static void InsertCustomer(NorthwindEntities northDb,
            string companyName = null,
            string contractName = null,
            string contractTitle = null,
            string address = null,
            string city = null,
            string region = null,
            string postalCode = null,
            string country = null,
            string phone = null,
            string fax = null)
        {

            using (northDb)
            {
                Customer newCustomer = new Customer();
                newCustomer.CustomerID = "temporaryUnique";
                newCustomer.CompanyName = companyName;
                newCustomer.ContactName = contractName;
                newCustomer.ContactTitle = contractTitle;
                newCustomer.Address = address;
                newCustomer.City = city;
                newCustomer.Region = region;
                newCustomer.PostalCode = postalCode;
                newCustomer.Country = country;
                newCustomer.Phone = phone;
                newCustomer.Fax = fax;

                northDb.Customers.Add(newCustomer);
                northDb.SaveChanges();
            }
        }

        public static void DeleteCustomer(NorthwindEntities northDb, string id)
        {
            using (northDb)
            {
                Customer customerToDelete = (Customer)northDb.Customers.Select(x => x.CustomerID == id);

                northDb.Customers.Remove(customerToDelete);
                northDb.SaveChanges();
            }
        }

        public static void UpdateCustomer(NorthwindEntities northDb, string id, string companyName)
        {
            using (northDb)
            {
                Customer customerToUpdate = (Customer)northDb.Customers.Select(x => x.CustomerID == id);

                customerToUpdate.CompanyName = companyName;
                northDb.SaveChanges();
            }
        }
    }
}
