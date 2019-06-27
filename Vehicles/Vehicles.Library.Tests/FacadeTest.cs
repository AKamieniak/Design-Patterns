using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Enums;
using Vehicles.Library.Facade;
using Vehicles.Library.Models;
using Vehicles.Library.Strategies.PaintStrategy;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void CarFacadeTest()
        {
            var carFacade = new CarFacade();
            var car = carFacade.Build<StripesStrategy>(EngineType.Diesel, Color.Black, 60);

            Assert.AreEqual(Color.Black, car.Color);
            Assert.AreEqual(60, car.MaxSpeed);
            Assert.AreEqual(EngineType.Diesel, car.EngineType);

            var car2 = carFacade.Create();

            Assert.IsInstanceOfType(car2, typeof(Car));
        }
    }
}
