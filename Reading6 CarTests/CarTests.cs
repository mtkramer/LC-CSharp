using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6_Unit_Tests;

namespace Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void GasTankFilled()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            Assert.AreEqual(16, car.GasTankLevel, .001);
        }
        [TestMethod]
        public void DriveWithinRange()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            car.Drive(100);
            Assert.AreEqual(12, car.GasTankLevel, .001);
            Assert.AreEqual(100, car.Odometer, .001);
        }
        [TestMethod]
        public void DriveBeyondRange()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            car.Drive(500);
            Assert.AreEqual(0, car.GasTankLevel, .001);
            Assert.AreEqual(400, car.Odometer, .001);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void GasTankCannotOverfill()
        {
            Car car = new Car("Toyota", "Supra", 16, 25);
            car.AddGas(5);
            Assert.Fail("Exception should be thrown before calling this test.");
        }
    }
}