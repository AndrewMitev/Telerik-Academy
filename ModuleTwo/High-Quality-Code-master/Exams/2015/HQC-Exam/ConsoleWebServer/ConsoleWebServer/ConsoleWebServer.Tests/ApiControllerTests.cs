namespace ConsoleWebServer.Tests
{
    using System;
    using Applicaton;
    using Framework;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApiControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetDateWithCorsShouldThrowIfDomainNameDoesntExist()
        {
            ApiController controller = new ApiController(new HttpRequest("GET", "/Home", "3.0"));
            controller.GetDateWithCors("imaginery");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetDateWithCorsShouldThrowIfDomainNameIsNull()
        {
            ApiController controller = new ApiController(new HttpRequest("GET", "/Home", "3.0"));
            controller.GetDateWithCors(null);
        }
    }
}
