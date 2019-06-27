using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Builders;
using Vehicles.Library.Enums;
using Vehicles.Library.Models;
using Vehicles.Library.Strategies.MoveStrategy;
using Vehicles.Library.Strategies.PaintStrategy;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class StrategiesTests
    {
        [TestMethod]
        public void FlyMoveStrategyTest()
        {
            var vehicle = new AircraftCarrier();
            Assert.AreEqual("Flying high", vehicle.MovingType.Move());
        }

        [TestMethod]
        public void DriveMoveStrategyTest()
        {
            var vehicle = new Motorbike();
            Assert.AreEqual("Drive strategy", vehicle.MovingType.Move());
        }

        [TestMethod]
        public void SwimMoveStrategyTest()
        {
            var vehicle = new Boat();
            Assert.AreEqual("Swim strategy", vehicle.MovingType.Move());
        }

        [TestMethod]
        public void ChangeMoveStrategyTest()
        {
            var vehicle = new Train();
            Assert.AreEqual("Drive strategy", vehicle.MovingType.Move());

            vehicle.Move<FlyStrategy>();
            Assert.AreEqual("Flying high", vehicle.MovingType.Move());

            vehicle.Move<SwimStrategy>();
            Assert.AreEqual("Swim strategy", vehicle.MovingType.Move());
        }
    }
}
