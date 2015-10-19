namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using Cars.Tests.JustMock.Mocks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MissingTests
    {
        private readonly ICarsRepository fakeCarsData;
        private CarsController controller;

        public MissingTests()
            : this(new MissingMocks())
        {
        }

        private MissingTests(ICarsRepositoryMock mockCarsData)
        {
            this.fakeCarsData = mockCarsData.CarsData;
        }

        [TestInitialize]
        public void TestInitialization()
        {
            this.controller = new CarsController();
            this.controller = new CarsController(this.fakeCarsData);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectExceptionWhenIdIsNotInCarsData()
        {
            var wrongID = 7676;
            this.controller.Details(wrongID);
        }

        [TestMethod]
        public void ExpectToReturnTheOnlyOneCarFromFakedCarRepo()
        {
            var collection = (ICollection<Car>)this.GetModel(() => this.controller.Search("audi"));
            Assert.AreEqual(1, collection.Count);
        }

        [TestMethod]
        public void ExpectToAddAllCarsInTheRepo()
        {
            var specialCount = 20;
            
            for (int i = 0; i < specialCount; i++)
            {
                var trabant = new Car()
                {
                    Id = (i + 1) * 1000,
                    Make = "GDR",
                    Model = "2" + i,
                    Year = DateTime.Now.Year - 50
                };

                this.controller.Add(trabant);
            }

            var collection = (ICollection<Car>)this.GetModel(() => this.controller.Search("GDR"));

            Assert.AreEqual(specialCount, collection.Count);
        }

        [TestMethod]
        public void ExpectedToReturnAEnpltyCollection()
        {
            var collection = (ICollection<Car>)this.GetModel(() => this.controller.Search(null));
            Assert.AreEqual(0, collection.Count);
        }

        [TestMethod]
        public void ExpectAddingDifferaneCarsInRepoThenReturnSortedByMakerToHaveCorrectResult()
        {
            var carMakers = new List<string>() { "BMW", "Audi", "Volkswagen" };
            var carModels = new List<string>() { "x5", "A7", "Golf 2", "X6", "A7", "Golf 3", "M3", "A8", "Golf 4" };

            IList<Car> carsFromEachGroup = new List<Car>();

            //// Clears all fakeCollection. see Mocks JustMockCarsRepo
            this.fakeCarsData.Remove(new Car());
            Assert.AreEqual(0, this.fakeCarsData.TotalCars);

            for (var i = 0; i < carModels.Count; i++)
            {
                var carToBeAdded = new Car
                {
                    Id = (i + 1) * 1000,
                    Make = carMakers[i % carMakers.Count],
                    Model = carModels[i],
                    Year = DateTime.Now.Year - i
                };

                this.controller.Add(carToBeAdded);
            }

            var sortedCarsByMaker = (ICollection<Car>)this.GetModel(() => this.controller.Sort("make"));
            sortedCarsByMaker.GroupBy(car => car.Make).ToList().ForEach(group => carsFromEachGroup.Add(group.FirstOrDefault()));

            Assert.AreEqual(carMakers.Count, carsFromEachGroup.Count);

            carMakers.Sort();
            for (var i = 0; i < carMakers.Count; i++)
            {
                Assert.AreEqual(carMakers[i], carsFromEachGroup[i].Make);
            }
        }

        [TestMethod]
        public void ExpectAddingCarsInRepoThenReturnSortedByYearToHaveCorrectResults()
        {
            byte specialCounter = 20;
            short[] years = { 2013, 2001, 2004, 2000, 2010 };

            List<int> expectedResultYears = new List<int>();
            this.fakeCarsData.Remove(new Car());

            for (var i = 0; i < specialCounter; i++)
            {
                var vartburg = new Car()
                {
                    Id = (i + 1) * 1945,
                    Make = "GDR2",
                    Model = "Kombi" + i,
                    Year = years[i % years.Length]
                };

                this.controller.Add(vartburg);
                expectedResultYears.Add(vartburg.Year);
            }

            var collection = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            expectedResultYears.Sort();

            for (int car = 0; car < expectedResultYears.Count; car++)
            {
                Assert.AreEqual(expectedResultYears[car], collection[car].Year);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid sorting parameter")]
        public void ExpectExceptionWhenWrongParameterPassedToSort()
        {
            var collection = (IList<Car>)this.GetModel(() => this.controller.Sort("id"));
        }

        [TestMethod]
        public void ExpectIDToHasDefaultIntValueWhenCarWithoutIDPased()
        {
            var someCar = new Car()
            {
                Make = "Some",
                Model = "Nowen",
                Year = DateTime.Now.Year
            };

            this.controller.Add(someCar);

            var collection = (IList<Car>)this.GetModel(() => this.controller.Index());
            var resultCar = collection.First(car => car.Make == "Some");

            Assert.AreEqual(0, resultCar.Id);
        }

        [TestMethod]
        public void ExpectToHaveNormaBehaviorWhenCarsWithSameIDAdded()
        {
            int specialLength = 20;
            int theId = 100;

            var simpleCar = new Car()
            {
                Id = theId,
                Make = "New One",
                Model = "Old One",
                Year = DateTime.Now.Year
            };

            for (int i = 0; i < specialLength; i++)
            {
                simpleCar.Make += i;
                this.controller.Add(simpleCar);
            }

            var collection = (List<Car>)this.GetModel(() => this.controller.Index());
            var count = collection.Count(car => car.Id == theId);

            Assert.AreEqual(specialLength, count);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}