using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Factories;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void LandcraftFactorySingletonTest()
        {
            var landcraftFactory = LandcraftFactory.Instance;

            Assert.IsInstanceOfType(landcraftFactory, typeof(LandcraftFactory));
        }

        [TestMethod]
        public void WatercraftFactorySingletonTest()
        {
            var watercraftFactory = WatercraftFactory.Instance;

            Assert.IsInstanceOfType(watercraftFactory, typeof(WatercraftFactory));
        }

        [TestMethod]
        public void AircraftFactorySingletonTest()
        {
            var aircraftFactory = AircraftFactory.Instance;

            Assert.IsInstanceOfType(aircraftFactory, typeof(AircraftFactory));
        }
    }
}
