namespace ConsoleWebServer.Tests
{
    using System;
    using Framework;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ActionDescriptorTests
    {
        [TestMethod]
        public void ConstructorShouldSplitUriCorrectly()
        {
            ActionDescriptor descriptor = new ActionDescriptor("/cat/is/doge");

            Assert.AreEqual(descriptor.ControllerName, "cat", "Controller is not valid");
        }

        [TestMethod]
        public void ContsructorShouldSplitUriWithTooManySlashes()
        {
            ActionDescriptor descriptor = new ActionDescriptor("///cat///is///doge");

            Assert.AreEqual(descriptor.ControllerName, "cat", "Controller is not valid");
        }

        [TestMethod]
        public void IfEmptyUriIsPassedDefaultControllerShouldBeHome()
        {
            ActionDescriptor descriptor = new ActionDescriptor(string.Empty);

            Assert.AreEqual(descriptor.ControllerName, "Home", "Controller is not valid");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IfInvalidUrlIsPassedTheConstructorShouldReturnDefaultValues()
        {
            ActionDescriptor descriptor = new ActionDescriptor("Some random text");

            Assert.AreEqual(descriptor.ControllerName, "Home", "Controller is not valid");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IfNullValueIsPassedShouldThrow()
        {
            ActionDescriptor descriptor = new ActionDescriptor(null);
        }
    }
}
