using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles.Library.Decorators;
using Vehicles.Library.Models;

namespace Vehicles.Library.Tests
{
    [TestClass]
    public class DecoratorsTests
    {
        [TestMethod]
        public void ShieldSwordDecoratorTest()
        {
            VehicleDecorator carDecorator = new ShieldDecorator(new Car());
            carDecorator = new SwordDecorator(carDecorator);

            Assert.AreEqual(8, carDecorator.GetDef());
            Assert.AreEqual(8, carDecorator.GetAtt());
        }

        [TestMethod]
        public void ArmorAxeDecoratorTest()
        {
            VehicleDecorator boatDecorator = new ArmorDecorator(new Boat());
            boatDecorator = new AxeDecorator(boatDecorator);

            Assert.AreEqual(10, boatDecorator.GetDef());
            Assert.AreEqual(7, boatDecorator.GetAtt());
        }

        [TestMethod]
        public void GlovesBowDecoratorTest()
        {
            VehicleDecorator planeDecorator = new GlovesDecorator(new Plane());
            planeDecorator = new BowDecorator(planeDecorator);

            Assert.AreEqual(2, planeDecorator.GetDef());
            Assert.AreEqual(8, planeDecorator.GetAtt());
        }

        [TestMethod]
        public void HelmetGunDecoratorTest()
        {
            VehicleDecorator droneDecorator = new HelmetDecorator(new Drone());
            droneDecorator = new GunDecorator(droneDecorator);

            Assert.AreEqual(6, droneDecorator.GetDef());
            Assert.AreEqual(10, droneDecorator.GetAtt());
        }

        [TestMethod]
        public void KnifeSwordDecoratorTest()
        {
            VehicleDecorator rocketDecorator = new KnifeDecorator(new Rocket());
            Assert.AreEqual(4, rocketDecorator.GetAtt());

            rocketDecorator = new SwordDecorator(rocketDecorator);
            Assert.AreEqual(12, rocketDecorator.GetAtt());
        }
    }
}
