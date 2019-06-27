using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Builders;
using Vehicles.Library.Enums;
using Vehicles.Library.Strategies.PaintStrategy;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void CarBuilderTest()
        {
            var car = new CarBuilder()
                .SetEngineType(EngineType.Oil)
                .SetColor<StripesStrategy>(Color.Gold)
                .SetMaxSpeed(120)
                .Build();

            Assert.AreEqual(Color.Gold, car.Color);
            Assert.AreEqual(120, car.MaxSpeed);
            Assert.AreEqual(EngineType.Oil, car.EngineType);
        }

        [TestMethod]
        public void BoatBuilderTest()
        {
            var boat = new BoatBuilder()
                .SetEngineType(EngineType.Diesel)
                .SetColor<StripesStrategy>(Color.Black)
                .SetMaxSpeed(1200)
                .Build();

            Assert.AreEqual(Color.Black, boat.Color);
            Assert.AreEqual(1200, boat.MaxSpeed);
            Assert.AreEqual(EngineType.Diesel, boat.EngineType);
        }


        [TestMethod]
        public void BikeBuilderTest()
        {
            var bike = new BikeBuilder()
                .SetColor<FillStrategy>(Color.Gray)
                .SetMaxSpeed(20)
                .Build();

            Assert.AreEqual(Color.Gray, bike.Color);
            Assert.AreEqual(20, bike.MaxSpeed);
        }

        [TestMethod]
        public void DroneBuilderTest()
        {
            var drone = new DroneBuilder()
                .SetEngineType(EngineType.Diesel)
                .SetColor<FillStrategy>(Color.LavaOrange)
                .SetMaxSpeed(200)
                .Build();

            Assert.AreEqual(Color.LavaOrange, drone.Color);
            Assert.AreEqual(200, drone.MaxSpeed);
            Assert.AreEqual(EngineType.Diesel, drone.EngineType);
        }
    }
}
