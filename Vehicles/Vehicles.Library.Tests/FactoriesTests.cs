using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Factories;
using Vehicles.Library.Models;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class FactoriesTests
    {
        [TestMethod]
        public void LandcraftFactoryTest()
        {
            var factory = new LandcraftFactory();
            var car = factory.Create<Car>();

            Assert.IsInstanceOfType(car, typeof(Vehicle));
        }

        [TestMethod]
        public void AircraftFactoryTest()
        {
            var factory = new AircraftFactory();
            var plane = factory.Create<Plane>();

            Assert.IsInstanceOfType(plane, typeof(Plane));
        }

        [TestMethod]
        public void WatercraftFactoryTest()
        {
            var factory = new WatercraftFactory();
            var boat = factory.Create<Boat>();

            Assert.IsInstanceOfType(boat, typeof(Boat));
        }
    }
}
