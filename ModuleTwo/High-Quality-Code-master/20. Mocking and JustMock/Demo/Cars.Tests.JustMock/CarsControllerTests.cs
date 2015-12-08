namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        //Custom Added Test that completes coverage of functionality of ICarsRepository interface.
        [TestMethod]
        public void MethodSearchShouldReturnOnlyBMWCars()
        {
            var beamers = (List<Car>)this.GetModel(() => this.controller.Search("bmw"));

            foreach (var car in beamers)
            {
                Assert.AreEqual(car.Make, "BMW");
            }
        }

        // Custom Test to show that the mocking of data is successful
        [TestMethod]
        public void SortedByMakeShouldMakeOpelLast()
        {
            var sortedCarsModel = (List<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(sortedCarsModel[3].Id, 4);
            Assert.AreEqual(sortedCarsModel[3].Make, "Opel");
            Assert.AreEqual(sortedCarsModel[3].Model, "Astra");
            Assert.AreEqual(sortedCarsModel[3].Year, 2010);
        }

        // Custom Test to show that the mocking of data is successful
        [TestMethod]
        public void SortedByMakeShouldPutMakerWithLetterAFirst()
        {
            var sortedCarsModel = (List<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(sortedCarsModel[0].Make[0], 'A');
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
