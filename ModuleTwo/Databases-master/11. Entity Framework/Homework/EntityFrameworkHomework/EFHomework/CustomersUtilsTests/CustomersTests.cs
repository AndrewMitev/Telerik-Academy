namespace CustomersUtilsTests
{
    using System;
    using System.Linq;
    using TaskOne;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomersTests
    {
        [TestMethod]
        public void InsertCustomerShouldSuccessfullyInsertNewCustomer()
        {
            NorthwindEntities northDb = new NorthwindEntities();

            NorthwindOperations.InsertCustomer(northDb, "Progress", "val", "pesho", "john", "siblng", "feeling", "ultimate", "243nand", "random value", "unnecessary");

            using (northDb)
            {
                Customer insertedUser = northDb.Customers.Where(x => x.CompanyName == "Progress").FirstOrDefault();
                Assert.AreEqual("Progress", insertedUser.CompanyName, "Not equal.");
            }
        }
    }
}
